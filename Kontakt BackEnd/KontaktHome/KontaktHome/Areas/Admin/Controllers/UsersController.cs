using KontaktHome.DAL;
using KontaktHome.Models;
using KontaktHome.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AppDbContext _context;
        public UsersController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole> roleManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
    }
        public async Task<IActionResult> Index()
        {
           List<AppUser> users= _userManager.Users.Where(x => x.EmailConfirmed == true).ToList();
            List<UsersVM> userVMs = new List<UsersVM>();
            foreach (AppUser user in users)
            {
                UsersVM userVm = new UsersVM
                {
                    id=user.Id,
                    UserName = user.UserName,
                    Email=user.Email,
                    IsDeleted=user.IsDeleted,
                    Role=(await _userManager.GetRolesAsync(user))[0]
                };
                userVMs.Add(userVm);
            }
            
            return View(userVMs);
        }
        public async Task<IActionResult> ChangeRole(string id)
        {
            if (id == null) return NotFound();
            AppUser appuser = await _userManager.FindByIdAsync(id);
            if (appuser == null) return NotFound();
            string role = (await _userManager.GetRolesAsync(appuser)).First();
            ViewBag.MyRole = role;
            List<IdentityRole> roles = _roleManager.Roles.ToList();
            return View(roles);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeRole(string id, string newRole)
        {
            List<IdentityRole> roles = _roleManager.Roles.ToList();
            if (id == null) return NotFound();
            AppUser appuser = await _userManager.FindByIdAsync(id);
            if (appuser == null) return NotFound();
            string oldRole = (await _userManager.GetRolesAsync(appuser)).First();
            if (oldRole != newRole)
            {
                IdentityResult addresult = await _userManager.AddToRoleAsync(appuser, newRole);
                if (!addresult.Succeeded)
                {
                    ModelState.AddModelError("", "Some problem exist");

                    return View(roles);
                }
                IdentityResult removeresult = await _userManager.RemoveFromRoleAsync(appuser, oldRole);
                if (!removeresult.Succeeded)
                {
                    ModelState.AddModelError("", "Some problem exist");

                    return View(roles);
                }

                await _userManager.UpdateAsync(appuser);

            }
                  
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Activity(string id)
        {

            if (id == null) return View();
            AppUser appUser = await _userManager.FindByIdAsync(id);
            if (appUser == null) return NotFound();
            if (appUser.IsDeleted)
            {
                appUser.IsDeleted = false;
            }
            else
            {
                appUser.IsDeleted = true;
            }
            await _userManager.UpdateAsync(appUser);
            return RedirectToAction(nameof(Index));
        }
    }
}
