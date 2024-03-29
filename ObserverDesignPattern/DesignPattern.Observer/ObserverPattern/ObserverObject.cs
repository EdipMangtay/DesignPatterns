using DesignPattern.Observer.DAL;
using DesignPattern.Observer.Migrations;
using System.Collections.Generic;

namespace DesignPattern.Observer.ObserverPattern
{
    public class ObserverObject
    {
        private readonly List<IObserver> _observers;
        public ObserverObject()
        {
             _observers = new List<IObserver>(); // Create a list of observers

        }
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer); // Add observer to the list // burası bir abonelik 
        }
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer); // Remove observer from the list // burası bir abonelikten çıkma
        }
        public void NotifyObserver(AppUser appUser)
        {
            _observers.ForEach(x =>
            {
                x.CreateNewUser(appUser); // Nesnenin içini dolaşarak her bir observer'a bildirim gönderiyoruz.
            });
        }
    }
}
