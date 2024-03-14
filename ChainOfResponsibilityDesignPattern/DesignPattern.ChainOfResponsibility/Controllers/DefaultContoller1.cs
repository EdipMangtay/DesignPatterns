using DesignPattern.ChainOfResponsibility.ChainOfResponsibility;
using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.ChainOfResponsibility.Controllers
{
    public class DefaultContoller1 : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasurer = new Treasurer();
            Employee managerasistant = new ManagerAsistant();
            Employee manager = new Manager();
            Employee areadirector = new AreaDirector();
            // bunlar zincirin halkalarında birbirlerine işaret edecekler

            treasurer.SetNextApprover(managerasistant);
            managerasistant.SetNextApprover(manager);
            manager.SetNextApprover(areadirector); // burada supervisor bu yüzden employee türünde eklendi çünkü bir sonraki çalışana aktarım yapılıyor
            //burası zincirlemeyi temsil ediyor

            
            treasurer.ProcessRequest(model);
            return View();



        }
    }
}
