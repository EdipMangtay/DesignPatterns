using DesignPattern.TemplateMerhod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMerhod.Controllers
{
    public class DefaultController1 : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
             ViewBag.v2 = netflixPlans.PlanType("Temel plan");
            //netflixPlans.CreatePlan();
            ViewBag.v3 = netflixPlans.CountPerson(1);
            ViewBag.v4 = netflixPlans.Price(99);
            ViewBag.v5 = netflixPlans.Content("Film/Dizi");
            ViewBag.v6 = netflixPlans.ReSolution("480px");
            
            return View();
        }
        public IActionResult StandartPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v2 = netflixPlans.PlanType("Standart plan");
            ViewBag.v3 = netflixPlans.CountPerson(5);
            ViewBag.v4 = netflixPlans.Price(150);
            ViewBag.v5 = netflixPlans.Content("Film/Dizi");
            ViewBag.v6 = netflixPlans.ReSolution("720px");

            return View();
        }
        public IActionResult Ultra()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v2 = netflixPlans.PlanType("Ultra plan");
            ViewBag.v3 = netflixPlans.CountPerson(10);
            ViewBag.v4 = netflixPlans.Price(200);
            ViewBag.v5 = netflixPlans.Content("Film/Dizi");
            ViewBag.v6 = netflixPlans.ReSolution("1080px");

            return View();
        }
    }
}
