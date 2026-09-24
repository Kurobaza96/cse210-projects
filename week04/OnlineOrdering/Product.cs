public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor to initialize the product with variables
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Methods to retrieve the product details
    public string GetName()
    {
        return _name;
    }

    // Method to retrieve the product ID
    public string GetProductId()
    {
        return _productId;
    }

    // Method to retrieve the product price
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}