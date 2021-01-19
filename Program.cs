using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to xxx Bank");

            CustomerManager elitCustomer = new CustomerManager();

            Customer customer1 = new Customer("Ali");
            Customer customer2 = new Customer("Veli");

            Customer customer3 = new Customer("Ahmet");


            elitCustomer.AddCustomer(customer1);
            elitCustomer.AddCustomer(customer2);
            elitCustomer.AddCustomer(customer3);

            elitCustomer.DelCustomer(customer1);

            elitCustomer.CustomerList(elitCustomer.CustomerInfo);
        }  // this is test messsages
    }
}
