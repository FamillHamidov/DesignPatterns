using DesignPattern.Observer.Data;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateDiscount : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();
        public CreateDiscount(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateUser(AppUser user)
        {
            context.Discounts.Add(new Discount
            {
                DiscountCode = "Test",
                DiscountAmount = 30,
                DiscountCodeStatus = true
            });
            context.SaveChanges();
        }
    }
}
