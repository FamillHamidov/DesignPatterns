using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.Data;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
	public class GetProductQueryHandler
	{
		private readonly Context _context;

		public GetProductQueryHandler(Context context)
		{
			_context = context;
		}
		public List<GetProductQueryResult> Handler()
		{
			var values = _context.Products.Select(x => new GetProductQueryResult
			{
				Id = x.Id,
				Price = x.Price,
				Name = x.Name,
				Description = x.Description,
				Stock = x.Stock,
			}).ToList();
			return values;
		}
	}
}
