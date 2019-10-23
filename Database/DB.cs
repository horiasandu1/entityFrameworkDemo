using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public static class DB
    {

        private static Demo1Entities myDb = new Demo1Entities();

        public static IEnumerable<Product> GetProducts()
        {
            return myDb.Products.ToList();
        }
        public static Product GetProduct (int id)
        {
            return myDb.Products.Find(id);
            
        }

        public static void addProduct(string prodDesc, string prodUpc)
        {
            Product newProd = new Product();
            
            newProd.ProductDescription = prodDesc;
            newProd.ProductUpc = prodUpc;
            myDb.Products.Add(newProd);
            myDb.SaveChanges();
        }

        public static IEnumerable<Customer> getCustomers()
        {
            return myDb.Customers.ToList();
        }

        public static Customer getCustomer(int id)
        {
            return myDb.Customers.Find(id);
        }

        public static void addCustomer(string cusFName, string cusLName)
        {
            Customer newCus = new Customer();
            newCus.CustomerFirstName = cusFName;
            newCus.CustomerLastName = cusLName;
            myDb.Customers.Add(newCus);
            myDb.SaveChanges();
        }

        public static IEnumerable<Sale> getSales()
        {
            return myDb.Sales.ToList();
        }

        public static Sale getSale(int id)
        {
            return myDb.Sales.Find(id);
        }

        public static void addSale(string preConDate,Product p, Customer c)
        {
            Sale newSale = new Sale();
            DateTime postConDate = Convert.ToDateTime(preConDate);

            newSale.SaleDate = postConDate;
            newSale.ProductId = p.ProductId;
            newSale.CustomerId = c.CustomerId;

            myDb.Sales.Add(newSale);
            myDb.SaveChanges();
        }

        public static void updateCustomer(int id,string cusFName, string cusLName)
        {
            Customer cust = getCustomer(id);
            cust.CustomerFirstName = cusFName;
            cust.CustomerLastName = cusLName;

            myDb.Entry(cust).State = System.Data.Entity.EntityState.Modified;
            myDb.SaveChanges();

        }
        
    }
}
