using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class ManagerAsistant : Employee // this person an employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess(); //yeni bir işlem tanımladım 
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı - Vehbi Mangtay";
                customerProcess.Description = "Para Çekme İşlemi Onaylandı, Müşteriye Talet Ettiği Tutar Ödendi";
                context.CustomerProcesses.Add(customerProcess); // customerprocess yukarıdaki değerleri tutmakta
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Şube Müdür Yardımcısı - Vehbi Mangtay";
                customerProcess.Description = "Para Çekme Tutarı Şube Müdür Yardımcısı'nın  Günlük Ödeyebileceği Tutarı Aştığı İçin İşlem Şube Müdürüne Aktarıldı ";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req); //Parametreden gelen verileri sonraki onaylayıcıya yönlendir 


            }
        }
    }
}
