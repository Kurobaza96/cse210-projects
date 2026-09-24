class Program
{
    static void Main(string[] args)
    {
        // Order 1 - Customer in USA
        Address address1 = new Address(
            "456 Davidson Ave",
            "Bronx",
            "New York",
            "USA"
        );

        Customer customer1 = new Customer(
            "John Doe",
            address1
        );

        Product product1 = new Product(
            "Laptop",
            "P001",
            500.00,
            1
        );

        Product product2 = new Product(
            "Wireless Mouse",
            "P002",
            25.50,
            2
        );

        Product product3 = new Product(
            "Keyboard",
            "P003",
            15.00,
            1
        );

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);


        // Order 2 - Customer outside USA
        Address address2 = new Address(
            "15 Ave 10-25",
            "Guatemala City",
            "Guatemala",
            "Guatemala"
        );

        Customer customer2 = new Customer(
            "Maria Jose Alvarez",
            address2
        );

        Product product4 = new Product(
            "Headphones",
            "P004",
            75.00,
            1
        );

        Product product5 = new Product(
            "USB Cable",
            "P005",
            10.00,
            3
        );

        Product product6 = new Product(
            "Webcam",
            "P006",
            30.00,
            1
        );

        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);


        // Display Order 1
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("-----------------------------------------");

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");

        Console.WriteLine();


        // Display Order 2
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("-----------------------------------------");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}