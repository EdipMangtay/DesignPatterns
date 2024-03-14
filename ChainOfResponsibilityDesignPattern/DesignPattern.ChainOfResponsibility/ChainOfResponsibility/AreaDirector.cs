using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Müdürü - Ali Edip Mangtay";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı, Müşteriye Talet Ettiği Tutar Ödendi";
                context.CustomerProcesses.Add(customerProcess); // customerprocess yukarıdaki değerleri tutmakta
                context.SaveChanges();
            }
            else 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Bölge Müdürü - Ali Edip Mangtay";
                customerProcess.Description = "Para Çekme Tutarı Bölge Müdürü'nün  Günlük Ödeyebileceği Tutarı Aştığı İçin İşlem Gerçekleştirilemedi, Müşterinin Günlük Çekebileceği Max Tutar 400K olduğu için daha fazla gün şubeye gelinmesi gerekmektedir... ";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
               
            }

        }
    }
}
