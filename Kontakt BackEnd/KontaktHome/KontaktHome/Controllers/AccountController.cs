using KontaktHome.DAL;
using KontaktHome.Helpers;
using KontaktHome.Models;
using KontaktHome.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly AppDbContext _context;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
            RoleManager<IdentityRole> roleManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
        }
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction(nameof(MyAccount));
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM Login)
        {
            if (!ModelState.IsValid) return View();
            AppUser user = await _userManager.FindByNameAsync(Login.UserName);
            if (user == null)
            {
                ModelState.AddModelError("", "İstifadəçi adı və ya Şifrə yanlışdır!");
                return View();
            }
            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Zəhmət olmasa E-Poçtu təsdiqləyin!");
                return View(Login);
            }
            Microsoft.AspNetCore.Identity.SignInResult signInResult =
            await _signInManager.PasswordSignInAsync(user, Login.Password, Login.RemmemberMe, true);
            if (user.IsDeleted)
            {
                ModelState.AddModelError("", "Sizin hesabınız hazırda aktiv deyil!");
                return View();
            }
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
            if ((await _userManager.GetRolesAsync(user))[0] == Roles.Admin.ToString())
            {
                return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
            }

            return RedirectToAction(nameof(MyAccount));

        }
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }
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
                UserName = register.UserName,
                
            };
            IdentityResult identityResult = await _userManager.CreateAsync(newUser, register.Password);
         
            if (identityResult.Succeeded)
            {
                Balans Balans = new Balans
                {
                    AppUserId = newUser.Id,
                    Amount = 0

                };
                _context.Balans.Add(Balans);
                await _context.SaveChangesAsync();

                var code = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
                var confirmationLink = Url.Action(nameof(ConfirmEmail), "Account", new { userName = newUser.UserName, code }, Request.Scheme);
                var mailto = newUser.Email;
                var messageBody = $"<p>Emaili təsdiqləmək üçün <a href=\"{confirmationLink}\"> buraya daxil </a>  olun</p>" +
                    $"</br><p>Qeydiyatı yalnız bir dəfə təsdiqləyə bilərsiz</p>";
                var messageSubject = "Email Təsdiqləmə";
                await Helper.SendMessageAsync(messageSubject, messageBody, newUser.Email);
                await _userManager.AddToRoleAsync(newUser, Roles.Müştəri.ToString());
                return RedirectToAction("VerifyEmail", "Account");
              

            }

            else
            {
                foreach (IdentityError error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
        
        }
        public IActionResult VerifyEmail()
        {
            return View();
        }
        public async Task<IActionResult> ConfirmEmail(string userName, string code)
        {
            if (userName == null || code == null)
            {
                return NotFound();
            }
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null)
            {
                return NotFound();
            }
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                TempData["Response"] = "Email has been confirmed";
                return RedirectToAction("Login", "Account");
            }
            else
                return NotFound();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult MyAccount()
        {
            string username = User.Identity.Name;
            if (username == null) return RedirectToAction(nameof(Login));
            var result = _context.AppUsers.FirstOrDefault(u => u.UserName == username);
            AppUser appUser = _context.AppUsers.Where(u => u.Id == result.Id).Include(u => u.Balans).FirstOrDefault();
            return View(appUser);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult MyAccount(AppUser balanss)
        {
            if (balanss == null) return NotFound();
            string username = User.Identity.Name;
            if (username == null) return RedirectToAction(nameof(Login));
            var result = _context.AppUsers.FirstOrDefault(u => u.UserName == username);
            AppUser appUser = _context.AppUsers.Where(u => u.Id == result.Id).Include(u => u.Balans).FirstOrDefault();

            Balans oldbalans = _context.Balans.FirstOrDefault(u => u.AppUserId == result.Id);
           
            if (oldbalans != null)
            {
                oldbalans.Amount += balanss.Balans.Amount;
                _context.Balans.Update(oldbalans);

            }

            _context.SaveChanges();
            return RedirectToAction(nameof(MyAccount));
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


