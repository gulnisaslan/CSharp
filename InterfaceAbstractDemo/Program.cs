using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concreate;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());

            //baseCustomerManager.Save(new Customer { DateOfYear = new DateTime(1997, 4, 20), FirstName = "Ercan ", LastName = "Aslan", NationalId = "12389208014" });
        
           /baseCustomerManager.Save(new Customer { DateOfYear = new DateTime(2000, 4, 23), FirstName = "Semih Sercan ", LastName = "Aslan", NationalId = "11969222440" });
         

            baseCustomerManager.Save(new Customer { DateOfYear = new DateTime(1996,4,1), FirstName = "Gülnisa ", LastName = "Aslan", NationalId = "12401207636" });
        

           baseCustomerManager.Save(new Customer { DateOfYear = new DateTime(1985, 1, 6), FirstName = "Engin ", LastName = "Demiroğ", NationalId = "28861499108" });  
            Console.ReadLine();
        }
    }
}
//hatıra niyetine  kalsın.....