using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor to initialize the order with a customer
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate the total cost of the order, including shipping
    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    // Method to get the packing label for the order
    public string GetPackingLabel()
    {
        string label = "PACKING LABEL\n";

        foreach (Product product in _products)
        {
            label += $"{product.GetName()} - {product.GetProductId()}\n";
        }
        return label;
    }

    // Method to get the shipping label for the order
    public string GetShippingLabel()
    {
        string label = "SHIPPING LABEL\n";
        label += $"{_customer.GetName()}\n";
        label += _customer.GetAddress().GetAddressString();

        return label;
    }
}