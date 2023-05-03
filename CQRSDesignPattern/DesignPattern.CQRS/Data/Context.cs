using DesignPattern.CQRS.Entites;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.Data
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DELL;Database=CQRS;Trusted_Connection=True;TrustServerCertificate=True");
		}
		public DbSet<Product> Products { get; set; }	
	}
}
