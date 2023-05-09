using DesignPattern.Observer.Data;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();
        public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }


        public void CreateUser(AppUser user)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = user.Name + " " + user.Surname,
                Content = "Test",
                Magazine = "Test"
            });
            context.SaveChanges();
        }
    }
}
