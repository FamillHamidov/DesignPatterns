using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{


	public class AreaDirectory : Employee
	{
		Context context=new Context();	
		public override void ProcessRequest(CustomerProcessViewModel req)
		{
			CustomerProcess customerProcess=new CustomerProcess();
			if (req.Amount <= 400000)
			{
				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Bölgə Müdiri - Nəsibə Həmidova";
				customerProcess.Description = "Müştərinin istədiyi pul ödəndi";
				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
			}
			else 
			{
				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Bölgə Müdiri - Nəsibə Həmidova";
				customerProcess.Description = "Müştərinin istədiyi pul ödənmədi. Max ödənilə bilinəcək məbləğ 400000 AZN.";
				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
			}
		}
	}
}
