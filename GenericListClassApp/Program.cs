using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListClassApp
{
    class Program
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Shuvo",
                Salary = 4000,
                Type = "RetailCustome"

            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Shujon",
                Salary = 4500,
                Type = "RetailCustome"

            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Shanto",
                Salary = 5000,
                Type = "RetailCustome"

            };

            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "Anika",
                Salary = 40000,
                Type = "RetailCustome"

            };

            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "Eliyas Hossen",
                Salary = 500000,
                Type = "CorporateCustomer"

            };

            Customer customer6 = new Customer()
            {
                ID = 105,
                Name = "Samina Akter",
                Salary = 1000000,
                Type = "CorporateCustomer"

            };

            List<Customer> listRetailCustomers = new List<Customer>();
            listRetailCustomers.Add(customer1);
            listRetailCustomers.Add(customer2);
            listRetailCustomers.Add(customer3);
            listRetailCustomers.Add(customer4);

            List<Customer>listCorporateCustomers = new List<Customer>();
            listCorporateCustomers.Add(customer5);
            listCorporateCustomers.Add(customer6);

            listRetailCustomers.AddRange(listCorporateCustomers);
            List<Customer> customers = listRetailCustomers.GetRange(3, 3);


            foreach (Customer c in customers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3} ", c.ID, c.Name, c.Salary,c.Type);
            }

            Console.ReadKey();

        }
    }

    public class Customer
    {
        public int ID { get;set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }

    }

}
