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
        public UsersController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
           List<AppUser> users= _userManager.Users.ToList();
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
