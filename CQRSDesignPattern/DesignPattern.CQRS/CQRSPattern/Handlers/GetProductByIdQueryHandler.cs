using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.Data;
using DesignPattern.CQRS.Entites;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
	public class GetProductByIdQueryHandler
	{
		private readonly Context _context;

		public GetProductByIdQueryHandler(Context context)
		{
			_context = context;
		}
		public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
		{
			var product = _context.Set<Product>().Find(query.Id);
			return new GetProductByIdQueryResult
			{
				Id = product.Id,
				Name = product.Name,
				Price = product.Price,
				Stock = product.Stock,
				Description = product.Description
			};
		}
	}
}
