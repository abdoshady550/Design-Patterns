using System;

namespace Prototype.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer1 = new Customer
            {
                Name = "Abdelrahman",
                Age = 25,
                BirthDate = new DateTime(2001, 1, 30),

                Address = new Address
                {
                    DoorNumber = 123,
                    Street = "El-Gomhoria",
                    City = "Menofia",
                    Country = "Egypt"
                }
            };

            var shallowCopy =(Customer)customer1.ShallowCopy();

            var deepCopy = (Customer)customer1.Clone();

            Console.WriteLine("-BEFORE CHANGE- \n");

            PrintCustomer("Original", customer1);
            PrintCustomer("Shallow Copy", shallowCopy);
            PrintCustomer("Deep Copy", deepCopy);

            Console.WriteLine();

            customer1.Name = "Ahmed";

            customer1.Address.DoorNumber = 999;
            customer1.Address.City = "Cairo";

            Console.WriteLine("-AFTER CHANGE \n");

            PrintCustomer("Original", customer1);
            PrintCustomer("Shallow Copy", shallowCopy);
            PrintCustomer("Deep Copy", deepCopy);

            Console.ReadKey();
        }

        static void PrintCustomer(string title, Customer customer)
        {
            Console.WriteLine(title);

            Console.WriteLine($"Name       : {customer.Name}");
            Console.WriteLine($"Age        : {customer.Age}");
            Console.WriteLine($"BirthDate  : {customer.BirthDate:yyyy-MM-dd}");

            Console.WriteLine($"DoorNumber : {customer.Address.DoorNumber}");
            Console.WriteLine($"Street     : {customer.Address.Street}");
            Console.WriteLine($"City       : {customer.Address.City}");
            Console.WriteLine($"Country    : {customer.Address.Country}");

            Console.WriteLine(new string('-', 40));
        }
    }
}