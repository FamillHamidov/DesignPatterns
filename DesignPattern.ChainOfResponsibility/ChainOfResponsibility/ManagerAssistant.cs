using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
	public class ManagerAssistant : Employee
	{
		Context context = new Context();
		public override void ProcessRequest(CustomerProcessViewModel req)
		{
			CustomerProcess customerProcess = new CustomerProcess();
			if (req.Amount <= 150000)
			{
				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Şöbə Müdiri Yardımçısı - Tural Həmidli";
				customerProcess.Description = "Müştərinin istədiyi pul ödəndi";
				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
			}
			else if (NextApprover != null)
			{
				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Şöbə Müdiri Yardımçısı - Tural Həmidli";
				customerProcess.Description = "Müştərinin istədiyi pul ödənmədiyi üçün əməliyyat Şöbə Müdiri-nə yönləndirildi";
				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
				NextApprover.ProcessRequest(req);
			}
		}
	}
}
