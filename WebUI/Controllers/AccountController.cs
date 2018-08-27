using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Entities;
//using DAL.Abstract;
//using DAL.Concrete;
using DAL.Infrastructure;
using WebUI.Infrastructure;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;
using WebUI.Models;
using System.Security.Claims;
using Microsoft.Owin.Security;

namespace WebUI.Controllers
{
    public class AccountController : Controller
    {
        private AppUserManager UserManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<AppUserManager>();
            }
        }

        private IAuthenticationManager AuthManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        private void AddErrorsFromResult(IdentityResult result)
        {
            foreach(string error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        public ActionResult Settings()
        {
            AccountSettingsViewModel vm = new AccountSettingsViewModel();

            AppUser user =  UserManager.FindByName(User.Identity.Name);

            vm.FirstName = user.FirstName;
            vm.LastName = user.LastName;
            vm.Email = user.Email;
            vm.Username = user.UserName;

            return View(vm);
        }

        [HttpPost]
        public async Task<ActionResult> ChangeFirstName(AccountSettingsViewModel vm)
        {
            if(ModelState.IsValid)
            {
                AppUser user = await UserManager.FindByNameAsync(User.Identity.Name);
                user.FirstName = vm.NewFirstName;

                IdentityResult result = await UserManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Settings", "Account");
                }

                else
                {
                    AddErrorsFromResult(result);
                }
            }

            return View(vm);
        }

        [HttpPost]
        public async Task<ActionResult> ChangeLastName(AccountSettingsViewModel vm)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await UserManager.FindByNameAsync(User.Identity.Name);
                user.LastName = vm.NewLastName;

                IdentityResult result = await UserManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Settings", "Account");
                }

                else
                {
                    AddErrorsFromResult(result);
                }
            }

            return View(vm);
        }



        [HttpPost]
        public async Task<ActionResult> ChangeEmailAddress(AccountSettingsViewModel vm)
        {
            if(ModelState.IsValid)
            {

                AppUser user = await UserManager.FindByNameAsync(User.Identity.Name);
                user.Email = vm.NewEmail;

                IdentityResult result = await UserManager.UpdateAsync(user);
                
                if(result.Succeeded)
                {
                return RedirectToAction("Settings", "Account");
                }

                else
                {
                    AddErrorsFromResult(result);
                }
            }

            return View(vm);
        }

        [HttpPost]
        public async Task<ActionResult> ChangePassword(AccountSettingsViewModel vm)
        {
            if(ModelState.IsValid)
            {
                AppUser user = await UserManager.FindByNameAsync(User.Identity.Name);
                IdentityResult result = await UserManager.ChangePasswordAsync(user.Id, vm.OldPassword, vm.NewPassword);

                if (result.Succeeded)
                {
                    return RedirectToAction("LogOut", "Account");
                }

                else
                {
                    AddErrorsFromResult(result);
                }
            }

            return View(vm);
        }

        [HttpPost]
        public async Task<ActionResult> SignUp(SignUpViewModel vm)
        {
            if(ModelState.IsValid)
            {
                AppUser user = new AppUser();

                user.FirstName = vm.FirstName;
                user.LastName = vm.LastName;
                user.UserName = vm.Username;
                user.Email = vm.Email;

                IdentityResult result = await UserManager.CreateAsync(user, vm.Password);

                if(result.Succeeded)
                {
                    return RedirectToAction("LogIn", "Home");
                }

                else
                {
                    AddErrorsFromResult(result);
                }
            }

            return View(vm);
        }

        [HttpPost]
        public async Task<ActionResult> LogIn(LogInViewModel vm)
        {
            if(ModelState.IsValid)
            {
                AppUser user = await UserManager.FindAsync(vm.Username, vm.Password);

                if(user == null)
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }

                else
                {
                    ClaimsIdentity ident = await UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
                    AuthManager.SignOut();
                    AuthManager.SignIn(new AuthenticationProperties { IsPersistent = false }, ident);
                    return RedirectToAction("Index", "MainDashboard");
                }
            }

            return View(vm);
        }

        public ActionResult LogOut()
        {
            AuthManager.SignOut();
            return RedirectToAction("Index", "Home");
        }



    }
}