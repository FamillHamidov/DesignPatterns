using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.Data;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetUpdateProductQueryHandler
    {
        private readonly Context _context;

        public GetUpdateProductQueryHandler(Context context)
        {
            _context = context;
        }
        public GetUpdateProductQueryResult Handle(GetUpdateProductByIdQuery getUpdateProductById)
        {
            var product = _context.Products.Find(getUpdateProductById.Id);
            return new GetUpdateProductQueryResult
            {
                Name = product.Name,
                 Price=product.Price,
                 Description = product.Description, 
                 Stock=product.Stock
            };
        }
    }
}
