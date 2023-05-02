namespace DesignPattern.ChainOfResponsibility.Models
{
	public class CustomerProcessViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public int Amount { get; set; } 
		public string EmployeeName { get; set; } = null!;
		public string? Description { get; set; }
	}
}
