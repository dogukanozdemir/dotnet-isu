using ISU_BT_PROJECT.Data;
using ISU_BT_PROJECT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ISU_BT_PROJECT.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly ILogin _loginUser;

        public LoginController(ILogger<LoginController> logger, ILogin loguser)
        {
            _logger = logger;
            _loginUser = loguser;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            var issuccess = _loginUser.AuthenticateUser(username, password);
            if (issuccess.Result != null)
            {
                ViewBag.username = string.Format("Successfully logged-in", username);
                return RedirectToAction("Contact", "Contact");
            }
            else
            {
                ViewBag.username = string.Format("Login Failed ", username);
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}