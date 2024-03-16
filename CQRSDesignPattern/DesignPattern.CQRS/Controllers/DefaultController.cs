using DesignPattern.CQRS.CQRSPattern.Handlers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;

        public DefaultController(GetProductQueryHandler getProductQueryHandler)
        {
            this._getProductQueryHandler = getProductQueryHandler;
        }

        public IActionResult Index()
        {
            // burasi verileri listeleyecek
            var values = _getProductQueryHandler.Handle();
            return View(values);

        }
    }
}
