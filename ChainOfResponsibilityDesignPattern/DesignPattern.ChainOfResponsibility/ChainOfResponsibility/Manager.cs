using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Manager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();

            if (req.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess(); //yeni bir işlem tanımladım 
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdürü - Kıymet Mangtay";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı, Müşteriye Talet Ettiği Tutar Ödendi";
                context.CustomerProcesses.Add(customerProcess); // customerprocess yukarıdaki değerleri tutmakta
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdürü - Kıymet Mangtay";
                customerProcess.Description = "Para Çekme Tutarı Şube Müdürü'nün  Günlük Ödeyebileceği Tutarı Aştığı İçin İşlem Bölge Müdürüne Aktarıldı ";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req); //Parametreden gelen verileri sonraki onaylayıcıya yönlendir 


            }
        }
    }
}
