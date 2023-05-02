using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
	public class Treasurer : Employee
	{
		public override void ProcessRequest(CustomerProcessViewModel req)
		{
			Context context = new Context();
			CustomerProcess customerProcess = new CustomerProcess();
			if (req.Amount<=100000)
			{
				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Xəzinədar - Famil Həmidli";
				customerProcess.Description = "Müştərinin istədiyi pul ödəndi";
				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
			}
			else if (NextApprover!=null)
			{
				customerProcess.Amount = req.Amount.ToString();
				customerProcess.Name = req.Name;
				customerProcess.EmployeeName = "Xəzinədar - Famil Həmidli";
				customerProcess.Description = "Müştərinin istədiyi pul ödənmədiyi üçün əməliyyat Şöbə Müdiri Yardımçısı-na yönləndirildi";
				context.CustomerProcesses.Add(customerProcess);
				context.SaveChanges();
				NextApprover.ProcessRequest(req);
			}
		}
	}
}
