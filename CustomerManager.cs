using System;
using System.Collections.ObjectModel;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public  Collection <Customer> CustomerInfo { get; set; }



        public CustomerManager() {

            CustomerInfo = new Collection<Customer> ();

        }
        
        // tester
        public void AddCustomer(Customer customer) {

            CustomerInfo.Add(customer);
            Console.WriteLine("Müsteri eklendi!!");

            }

        public void DelCustomer(Customer customer)
        {
           CustomerInfo.Remove(customer);
            Console.WriteLine("Müsteri Silindi.!!");

        }

        public void CustomerList(Collection <Customer> list)
        {
            Console.WriteLine("Mevcut Müşterilerimiz:");


            foreach (Customer item in list)
            {
                Console.WriteLine(item.CustomerName);
            }


        }


    }




    }

