using DesignPattern.Observer.DAL;
using System;
using System.Runtime.CompilerServices;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            // Create a welcome message for the new user

            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name +" " + appUser.Surname,
                Content = "Welcome to our website " + appUser.Name + " " + appUser.Surname,

            });
            context.SaveChanges();

            
        }
    }
}
