using DesignPattern.CQRS.Entites;
using Microsoft.EntityFrameworkCore;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.CQRSPattern.Queries;

namespace DesignPattern.CQRS.Data
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DELL;Database=CQRS;Trusted_Connection=True;TrustServerCertificate=True");
		}
		public DbSet<Product> Products { get; set; }	
		public DbSet<DesignPattern.CQRS.CQRSPattern.Results.GetProductByIdQueryResult> GetProductByIdQueryResult { get; set; } = default!;
		public DbSet<DesignPattern.CQRS.CQRSPattern.Queries.GetUpdateProductByIdQuery> GetUpdateProductByIdQuery { get; set; } = default!;
		public DbSet<DesignPattern.CQRS.CQRSPattern.Results.GetUpdateProductQueryResult> GetUpdateProductQueryResult { get; set; } = default!;
	}
}
