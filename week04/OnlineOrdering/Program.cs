using System;
using System.Text;
namespace ProductOrderingSystem;

class Program
{
    static void Main(string[] args)
    {
            // Create addresses
            Address address1 = new Address("123 Main St", "New York", "NY", "USA");
            Address address2 = new Address("456 Elm St", "London", "England", "UK");

            // Create customers
            Customer customer1 = new Customer("Alice Smith", address1);
            Customer customer2 = new Customer("Bob Johnson", address2);

            // Create products
            Product product1 = new Product("Iphone16", "LAP123", 1200.00, 1);
            Product product2 = new Product("Backpack", "MOU456", 25.50, 2);
            Product product3 = new Product("Professional men's clipper", "KEY789", 45.00, 1);
            Product product4 = new Product("USB Desk Fan", "MON101", 300.00, 1);

            // Create orders
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product3);
            order2.AddProduct(product4);

            // Display order details
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}");

            Console.WriteLine("\n" + new string('-', 40) + "\n");

            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}
