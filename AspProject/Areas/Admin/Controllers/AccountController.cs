using AspProject.Areas.Admin.Models;
using AspProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace AspProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManagar;
        public AccountController(UserManager<AppUser> userManagar)
        {
            _userManagar = userManagar;
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
        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid) return View();
            AppUser user = new AppUser
            {
                FullName = register.FullName,
                Email = register.Email,
                UserName = register.UserName
            };

            IdentityResult identityResult = await _userManagar.CreateAsync(user, register.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var item in identityResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(register);
            }
            return RedirectToAction("login","account");
        }
    }
}
