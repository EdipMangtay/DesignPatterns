using DesignPattern.Observer.DAL;
using DesignPattern.Observer.Models;
using DesignPattern.Observer.ObserverPattern;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesignPattern.Observer.Controllers
{
    public class Default : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObserverObject _observerObject;

        public Default(UserManager<AppUser> userManager, ObserverObject observerObject)
        {
            _userManager = userManager;
            _observerObject = observerObject;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> Index(RegisterViewModel model)
        {
            var appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                UserName = model.UserName

            };
           var result =  await _userManager.CreateAsync(appUser, model.Password); // Create a new user
            if (result.Succeeded)
            {
                _observerObject.NotifyObserver(appUser); // gözlemen kullanıcdaki adımları tutar
                return View();
            }
            return View(); 
        }
    }
}
