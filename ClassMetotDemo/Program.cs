using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.ID = 12345;
            customer1.name = "Ayşe";
            customer1.surname = "Kaya";
            customer1.city = "Ankara";

            Customer customer2 = new Customer();
            customer2.ID = 54321;
            customer2.name = "Ali";
            customer2.surname = "Demirci";
            customer2.city = "Balıkesir";

            Customer customer3 = new Customer();
            customer3.ID = 543211245;
            customer3.name = "Ahmet";
            customer3.surname = "Kara";
            customer3.city = "Muğla";

            Customer[] cstmrs = new Customer[] { customer1, customer2,customer3 };
            Console.WriteLine("All Customers: ");
            int a = 0;
                while( a < cstmrs.Length)
                {
                Console.WriteLine(cstmrs[a].name+ " " +cstmrs[a].surname+" "+cstmrs[a].city);
                    a++;
            }
         
            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("                    ");
            customerManager.CustomerAdd(customer1);
            Console.WriteLine("                    ");
            customerManager.CustomerDelete(customer2);
            Console.WriteLine("                    ");
            customerManager.List(cstmrs);
        }

    }
    class Customer
    {

        public int ID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string city { get; set; }
    }
    class CustomerManager
    {
        private Customer musteri = new Customer();

        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine(customer.ID + " the consumer who has this ID deleted.");
        }
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("new customer added.");
        }
        
        public void List(Customer[] cstmrs)
        {
            foreach (var customers in cstmrs)
            {
                Console.WriteLine("Customer lists :");
                Console.WriteLine("Customer ID : " + customers.ID+ " name : " + customers.name);
                
            }
        }

    }
}


