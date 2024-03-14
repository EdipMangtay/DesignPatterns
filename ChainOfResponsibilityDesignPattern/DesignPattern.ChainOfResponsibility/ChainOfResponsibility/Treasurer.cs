using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;
using System.Security.Cryptography;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            
            if (req.Amount <= 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Veznedar - Edip Mangtay";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı, Müşteriye Talet Ettiği Tutar Ödendi";
                context.CustomerProcesses.Add(customerProcess); // customerprocess yukarıdaki değerleri tutmakta
                context.SaveChanges();


            }
            else if(NextApprover !=null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Veznedar - Edip Mangtay";
                customerProcess.Description = "Para Çekme Tutarı Veznedarın Günlük Ödeyebileceği Tutarı Aştığı İçin İşlem Şube Müdür Yardımcısına Aktarıldı ";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req); //Parametreden gelen verileri sonraki onaylayıcıya yönlendir 


            }
        }
    }
}
