using System;
namespace ClassMetotDemo
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }

        public Customer(int Id, String Name, String LastName) {

            CustomerId = Id;
            CustomerName = Name;
            CustomerLastName = LastName;

        }
        public Customer(String Name)
        {

           
            CustomerName = Name;

            CustomerId = 1;
        }

        // this is test messsages
        // Github a ekleme

    }
}
