using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.Data;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handler(CreateProductCommand createProductCommand)
        {
            _context.Products.Add(new Entites.Product
            {
                Description = createProductCommand.Description,
                Name = createProductCommand.Name,
                Price = createProductCommand.Price,
                Stock = createProductCommand.Stock,
            });
            _context.SaveChanges();
        }
    }
}
