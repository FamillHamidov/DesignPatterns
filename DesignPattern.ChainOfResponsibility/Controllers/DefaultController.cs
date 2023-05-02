using DesignPattern.ChainOfResponsibility.ChainOfResponsibility;
using DesignPattern.ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.ChainOfResponsibility.Controllers
{
	public class DefaultController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(CustomerProcessViewModel viewModel)
		{
			Employee treasurer=new Treasurer();
			Employee managerAssistant = new ManagerAssistant();
			Employee manager = new Manager();
			Employee areaDirectory = new AreaDirectory();

			treasurer.SetNextApprover(managerAssistant);
			managerAssistant.SetNextApprover(manager);
			manager.SetNextApprover(areaDirectory);

			treasurer.ProcessRequest(viewModel);
			return View();
		}
	}
}
