using KontaktHome.Helpers;
using KontaktHome.Models;
using KontaktHome.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KontaktHome.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM Login)
        {
            if (!ModelState.IsValid) return View();
            AppUser user = await _userManager.FindByNameAsync(Login.UserName);
            if (user==null)
            {
                ModelState.AddModelError("", "İstifadəçi adı və ya Şifrə yanlışdır!");
                return View();
            }
            if (user.IsDeleted)
            {
                ModelState.AddModelError("", "Sizin hesabınız hazırda aktiv deyil!");
                return View();
            }
            var signInResult= await _signInManager.PasswordSignInAsync(user, Login.Password, Login.RemmemberMe,true);
            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError("", "Lütfən bir neçə dəqiqədən sonra yenidən cəhd edin!");
                return View();
            }
            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "İstifadəçi adı və ya Şifrə yanlışdır!");
                return View();
            }
            if ((await _userManager.GetRolesAsync(user))[0]==Roles.Admin.ToString())
            {
                return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
            }

            return RedirectToAction("Index", "Home");
        
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View();

            AppUser newUser = new AppUser
            {
                Email = register.Email,
                UserName = register.UserName

            };

            IdentityResult identityResult = await _userManager.CreateAsync(newUser, register.Password);
            if (!identityResult.Succeeded)
            {
                foreach (IdentityError error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            await _userManager.AddToRoleAsync(newUser, Roles.Admin.ToString());
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        #region CreateRoles
        //public async Task CreateRoles()
        //{
        //    foreach (var role in Enum.GetValues(typeof(Roles)))
        //    {
        //        if (!(await _roleManager.RoleExistsAsync(role.ToString())))
        //        {
        //            await _roleManager.CreateAsync(new IdentityRole { Name = role.ToString() });
        //        }
        //    }
        //}
        #endregion
    }
}


