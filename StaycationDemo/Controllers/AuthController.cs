using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StaycationDemo.Data;
using StaycationDemo.Models;
using StaycationDemo.Models.Abstractions;
using StaycationDemo.Services;
using StaycationDemo.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace StaycationDemo.Controllers
{
	public class AuthController : Controller
	{
        private readonly IUserServices _userServices;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        public AuthController(IUserServices userServices, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userServices = userServices;
            _userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Login()
		{
			return View();
		}
        
		public IActionResult Register()
		{
			return View();
		}

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {

                var user = _userManager.Users.FirstOrDefault(x => x.Email == model.Email);
                if(user == null)
                {
                    ModelState.AddModelError("Password", "user does not exist");
                    return View(model);
                    // throw error message that user does not exist
                }
                var login = await signInManager.PasswordSignInAsync(user, model.Password, true, true);

         
                if (login.Succeeded)
                {
                    //HttpContext.Session.SetString("Fullname", $"{user.FirstName} {user.LastName}");
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("Password", "Invalid password");
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                bool registered = _userServices.Register(model);

                var user = new ApplicationUser
                {
                    FirstNAme = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    UserName = model.Email                };
              var result =   await _userManager.CreateAsync(user, model.Password);
                if(result.Succeeded)
                {
                    return RedirectToAction("Login");
                }

                return View();
                //if (registered)
                //{
                //    return RedirectToAction("Login");
                //}
            }
            return View();
        }
    }
}
