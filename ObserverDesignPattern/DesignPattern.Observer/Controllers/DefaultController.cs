using DesignPattern.Observer.Data;
using DesignPattern.Observer.Models;
using DesignPattern.Observer.ObserverPattern;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Observer.Controllers
{

    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObserverObject _observer;
		public DefaultController(UserManager<AppUser> userManager, ObserverObject observer)
		{
			_userManager = userManager;
			_observer = observer;
		}

		[HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            var user = new AppUser
            {
                Name=model.Name,
                Surname=model.Surname,
                Email=model.Email,
                UserName=model.Username,
            };
            var result=await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                _observer.NotifyObserver(user);
                return View();
            }
            return View();
        }
    }
}
