using DesignPattern.Observer.Data;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        Context context = new Context();

        public void CreateUser(AppUser user)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = user.Name + " " + user.Surname,
                Content = "Test"
            });
            context.SaveChanges();
        }
    }
}
