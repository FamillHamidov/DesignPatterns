using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.CQRSPattern.Handlers;
using DesignPattern.CQRS.CQRSPattern.Queries;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.Controllers
{
	public class DefaultController : Controller
	{
		private readonly GetProductQueryHandler _getProductQueryHandler;
		private readonly CreateProductCommandHandler _createProductCommandHandler;
		private readonly GetProductByIdQueryHandler _getProductByIdQueryHandler;
		private readonly RemoveProductCommandHandler _removeProductCommandHandler;
		private readonly GetUpdateProductQueryHandler _getUpdateProductQueryHandler;
		private readonly UpdateProductCommandHandler _updateProductCommandHandler;
        public DefaultController(GetProductQueryHandler getProductQueryHandler, CreateProductCommandHandler createProductCommandHandler, GetProductByIdQueryHandler getProductByIdQueryHandler, RemoveProductCommandHandler removeProductCommandHandler, GetUpdateProductQueryHandler getUpdateProductQueryHandler, UpdateProductCommandHandler updateProductCommandHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
            _getProductByIdQueryHandler = getProductByIdQueryHandler;
            _removeProductCommandHandler = removeProductCommandHandler;
            _getUpdateProductQueryHandler = getUpdateProductQueryHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
        }

        public IActionResult Index()
		{
			var values = _getProductQueryHandler.Handler();
			return View(values);
		}
		[HttpGet]
		public IActionResult NewProduct()
		{
			return View();
		}
		[HttpPost]
		public IActionResult NewProduct(CreateProductCommand createProductCommand)
		{
			_createProductCommandHandler.Handler(createProductCommand);
			return RedirectToAction("Index");
		}
		public IActionResult GetById(int id) 
		{
			var product=_getProductByIdQueryHandler.Handle(new GetProductByIdQuery(id));
			return View(product);
		}
		public IActionResult RemoveProduct(int id)
		{
			_removeProductCommandHandler.Handle(new RemoveProductCommand(id));
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateProduct(int id)
		{
			var product=_getUpdateProductQueryHandler.Handle(new GetUpdateProductByIdQuery(id));	
			return View(product);
		}
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand command)
        {
			_updateProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
