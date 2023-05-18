using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DesignPattern.PresentationLayer.Controllers
{
	public class ProductController : Controller
	{
		private readonly IProductService _productService;
		private readonly ICategoryService _categoryService;

		public ProductController(IProductService productService, ICategoryService categoryService)
		{
			_productService = productService;
			_categoryService = categoryService;
		}

		public IActionResult Index()
		{
			var products=_productService.TGetList();
			return View(products);
		}
		public IActionResult Index2()
		{
			var products = _productService.TProductListWithCategoryName();
			return View(products);
		}
		[HttpGet]
		public IActionResult AddProduct()
		{
			List<SelectListItem> categoryList = (from x in _categoryService.TGetList()
												 select new SelectListItem
												 {
													 Text = x.Name,
													 Value = x.Id.ToString()
												 }).ToList();
			ViewBag.c = categoryList;
			return View();
		}
		[HttpPost]
		public IActionResult AddProduct(Product product)
		{
			_productService.TInsert(product);
			return RedirectToAction("Index");
		}
		public IActionResult DeleteProduct(int id)
		{
			var category = _productService.TGetById(id);
			_productService.TDelete(category);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateProduct(int id)
		{
			List<SelectListItem> categoryList = (from x in _categoryService.TGetList()
												 select new SelectListItem
												 {
													 Text = x.Name,
													 Value = x.Id.ToString()
												 }).ToList();
			ViewBag.c = categoryList;
			var category = _productService.TGetById(id);
			return View(category);
		}
		[HttpPost]
		public IActionResult UpdateProduct(Product product)
		{
			_productService.TUpdate(product);
			return RedirectToAction("Index");
		}
	}
}
