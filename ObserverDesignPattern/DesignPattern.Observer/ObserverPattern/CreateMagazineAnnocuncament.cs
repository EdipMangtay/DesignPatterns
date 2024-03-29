using DesignPattern.Observer.DAL;
using System;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateMagazineAnnocuncament : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateMagazineAnnocuncament(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine = "We have a new magazine for you ",
                Content = "We have a new magazine for you " + appUser.Name + " " + appUser.Surname,

            });
            context.SaveChanges();
        }
    }
}
