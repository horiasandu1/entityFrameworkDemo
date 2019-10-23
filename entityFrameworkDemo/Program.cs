using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
namespace entityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var salesList = DB.getSales();

            for (var i = 0; i < salesList.Count(); i++)
            {

                Console.WriteLine(salesList.ElementAt(i).SaleId + " " 
                    + DB.getCustomer(salesList.ElementAt(i).CustomerId).CustomerFirstName + " " +
           DB.getCustomer(salesList.ElementAt(i).CustomerId).CustomerLastName + " " + DB.GetProduct(salesList.ElementAt(i).ProductId).ProductDescription);
                Console.WriteLine();
            }

            

            //  Database.DB.updateCustomer(3, "Lea", "Sandu");

            // Database.DB.addCustomer("Lea", "Ambrosoli");/*
            var myCustomer = Database.DB.getCustomer(3);

                       //Console.Write(myCustomer.CustomerLastName);
                    

             //  Database.DB.addSale("01/01/2011", Database.DB.GetProduct(6), Database.DB.getCustomer(2));

        }
    }
}
