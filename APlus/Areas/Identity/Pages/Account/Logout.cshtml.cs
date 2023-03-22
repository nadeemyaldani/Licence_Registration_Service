using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using APlus.Data.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace APlus.Areas.Identity.Pages.Account
{

    //    [AllowAnonymous]
    //    [IgnoreAntiforgeryToken]
    //    public class LogoutModel : PageModel
    //    {
    //        private readonly SignInManager<ApplicationUser> _signInManager;
    //        private readonly ILogger<LogoutModel> _logger;

    //        public LogoutModel(SignInManager<ApplicationUser> signInManager, ILogger<LogoutModel> logger)
    //        {
    //            _signInManager = signInManager;
    //            _logger = logger;
    //        }

    //        public void OnGet()
    //        {
    //        }
    //        public async Task<IActionResult> OnPost()
    //        {
    //            await _signInManager.SignOutAsync();
    //            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    //            _logger.LogInformation("User logged out.");
    //            return Redirect("Login");
    //        }
    //    }
//}
[AllowAnonymous]
public class LogoutModel : PageModel
{
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly ILogger<LogoutModel> _logger;

    public LogoutModel(SignInManager<ApplicationUser> signInManager, ILogger<LogoutModel> logger)
    {
        _signInManager = signInManager;
        _logger = logger;
    }

    public async Task<IActionResult> OnPost(string returnUrl = null)
    {
        await _signInManager.SignOutAsync();
        //await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        _logger.LogInformation("User logged out.");
        if (returnUrl != null)
        {
            return LocalRedirect(returnUrl);
        }
        else
        {
            // This needs to be a redirect so that the browser performs a new
            // request and the identity for the user gets updated.
            return Redirect("Login");
        }
    }
}
}
