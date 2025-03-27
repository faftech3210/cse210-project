using System.Collections.Generic;
using System.Text;

namespace ProductOrderingSystem
{
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
}
