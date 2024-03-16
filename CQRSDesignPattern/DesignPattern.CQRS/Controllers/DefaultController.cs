using DesignPattern.CQRS.CQRSPattern.Command;
using DesignPattern.CQRS.CQRSPattern.Comment;
using DesignPattern.CQRS.CQRSPattern.Handlers;
using DesignPattern.CQRS.CQRSPattern.Handlers.DesignPattern.CQRS.CQRSPattern.Handlers;
using DesignPattern.CQRS.CQRSPattern.Queries;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace DesignPattern.CQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;
        private readonly GetProductByIDQueryHandler _getProductByIDQueryHandler;
        private readonly RemoveProductCommandHandler _removeProductCommandHandler;
        private readonly GetProductUpdateByIDQueryHandler  _getProductUpdateByIDQueryHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;

        public DefaultController(GetProductQueryHandler getProductQueryHandler, CreateProductCommandHandler createProductCommandHandler, GetProductByIDQueryHandler getProductByIDQueryHandler, RemoveProductCommandHandler removeProductCommandHandler, GetProductUpdateByIDQueryHandler getProductUpdateByIDQueryHandler, UpdateProductCommandHandler updateProductCommandHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
            _getProductByIDQueryHandler = getProductByIDQueryHandler;
            _removeProductCommandHandler = removeProductCommandHandler;
            _getProductUpdateByIDQueryHandler = getProductUpdateByIDQueryHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
        }

        public IActionResult Index()
        {
            // burasi verileri listeleyecek
            var values = _getProductQueryHandler.Handle();
            return View(values);

        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult GetProduct(int id)
        {
            var values = _getProductByIDQueryHandler.Handle(new CQRSPattern.Queries.GetProductByIDQuery(id));
            return View(values);

        }
        public IActionResult DeleteProduct(int id)
        {

            _removeProductCommandHandler.Handle(new RemoveProductCommand(id));
            return RedirectToAction("Index");

        }
        //Güncelleme
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = _getProductUpdateByIDQueryHandler.Handle(new GetProductUpdateByIDQuery(id));
            return View(values); //id ye göre getirecek

        }
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand command)
        {
            _updateProductCommandHandler.Handle(command);
            return RedirectToAction("Index");



        }

    }
}
