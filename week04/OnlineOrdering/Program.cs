using System;
using System.Text;

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
public class Address
    {
        private string _street;
        private string _city;
        private string _stateOrProvince;
        private string _country;

        public Address(string street, string city, string stateOrProvince, string country)
        {
            _street = street;
            _city = city;
            _stateOrProvince = stateOrProvince;
            _country = country;
        }

        public bool IsInUSA()
        {
            return _country.ToLower() == "usa";
        }

        public string GetFullAddress()
        {
            return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
        }
    }

    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public string GetName()
        {
            return _name;
        }

        public Address GetAddress()
        {
            return _address;
        }

        public bool LivesInUSA()
        {
            return _address.IsInUSA();
        }
    }

    public class Product
    {
        private string _name;
        private string _productId;
        private double _price;
        private int _quantity;

        public Product(string name, string productId, double price, int quantity)
        {
            _name = name;
            _productId = productId;
            _price = price;
            _quantity = quantity;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetProductId()
        {
            return _productId;
        }

        public double GetTotalCost()
        {
            return _price * _quantity;
        }
    }

    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _products = new List<Product>();
            _customer = customer;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double GetTotalPrice()
        {
            double productTotal = 0;
            foreach (var product in _products)
            {
                productTotal += product.GetTotalCost();
            }

            double shippingCost = _customer.LivesInUSA() ? 5 : 35;
            return productTotal + shippingCost;
        }

        public string GetPackingLabel()
        {
            StringBuilder packingLabel = new StringBuilder("Packing Label:\n");
            foreach (var product in _products)
            {
                packingLabel.AppendLine($"Product: {product.GetName()}, ID: {product.GetProductId()}");
            }
            return packingLabel.ToString();
        }

        public string GetShippingLabel()
        {
            StringBuilder shippingLabel = new StringBuilder("Shipping Label:\n");
            shippingLabel.AppendLine($"Name: {_customer.GetName()}");
            shippingLabel.AppendLine($"Address:\n{_customer.GetAddress().GetFullAddress()}");
            return shippingLabel.ToString();
        }
    }