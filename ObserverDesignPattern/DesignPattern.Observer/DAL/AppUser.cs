using Microsoft.AspNetCore.Identity;

namespace DesignPattern.Observer.DAL
{
    public class AppUser :IdentityUser<int>
    {
        //identiy kütüphanesi login ve register gibi işlemleri otomatik olarak yapmamı sağlar
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string District { get; set; }
    }
}
