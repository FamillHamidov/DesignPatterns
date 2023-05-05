using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.Data;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateProductCommand command)
        {
            var product = _context.Products.Find(command.Id);
            product.Name = command.Name;
            product.Description = command.Description;
            product.Price = command.Price;
            product.Stock = command.Stock;
            _context.SaveChanges();
        }
    }
}
