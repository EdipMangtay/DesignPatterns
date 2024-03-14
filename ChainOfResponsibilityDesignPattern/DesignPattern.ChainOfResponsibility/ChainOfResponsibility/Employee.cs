using DesignPattern.ChainOfResponsibility.Models;
using System.Security.Cryptography.X509Certificates;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public abstract class Employee
    {
        //abstract method imzaları ve implementasyonları taşır/Interface method imzası taşır

        protected Employee NextApprover;

        public void SetNextApprover(Employee SuperVisor)
        {
            this.NextApprover = SuperVisor;
            // protected Employee NextApprover;: Bu bir sonraki onaylayıcıyı tutan bir korumalı (protected) sınıf değişkeni tanımlar. Bu, zincirdeki bir sonraki onaylayıcıyı temsil eder.
            // supervisor ilgili kurumda bir çalışan 

        }
        public abstract void ProcessRequest(CustomerProcessViewModel req);


    }

}

