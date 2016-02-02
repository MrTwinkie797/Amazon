using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;
using Amazon.ViewModels;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Amazon.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        UserManager<IdentityUser> _userManager;
        SignInManager<IdentityUser> _signInManager;
        IdentityDbContext _identityContext;

        public AccountController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IdentityDbContext dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _identityContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel, string returnUrl)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            // Skapa DB-schema
            await _identityContext.Database.EnsureCreatedAsync();

            // Skapa användaren
            var result = await _userManager.CreateAsync(new IdentityUser(
                viewModel.UserName), viewModel.Password);

            if (!result.Succeeded)
            {
                ModelState.AddModelError(nameof(LoginViewModel.Password), result.Errors.First().Description);
                return View(viewModel);
            }

            // Logga in användaren
            await _signInManager.PasswordSignInAsync(viewModel.UserName, viewModel.Password,
                false, false);

            // Omdirigera användaren
            if (string.IsNullOrWhiteSpace(returnUrl))
                return RedirectToAction("Home");
            else
                return Redirect(returnUrl);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            await _identityContext.Database.EnsureCreatedAsync();

            var result = await _userManager.CreateAsync(new IdentityUser(model.UserName));
                if (!result.Succeeded);
            {
                ModelState.AddModelError("UserName", result.Errors.First().Description);
                return View(model);
            }

            await _signInManager.PasswordSignInAsync(model.UserName, model.Password,
                false, false);
            return RedirectToAction(nameof(MembersController.Index), "Members");
        }
    }
}
