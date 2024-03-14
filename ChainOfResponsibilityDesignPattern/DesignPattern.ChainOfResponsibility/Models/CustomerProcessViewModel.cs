namespace DesignPattern.ChainOfResponsibility.Models
{
    public class CustomerProcessViewModel
    { // burası entityden örnek alıyor // bu aradaki bir sanal sınıf gibi hareket edecek
        public int CustomerProcessID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string EmployeeName { get; set; }
        public string Description { get; set; }
    }
}
