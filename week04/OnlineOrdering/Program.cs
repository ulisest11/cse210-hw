using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Customer 1 (USA)
        Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M456", 25.50, 2));

        // Customer 2 (International)
        Address address2 = new Address("45 King St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alice Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Camera", "C789", 350.00, 1));
        order2.AddProduct(new Product("Tripod", "T101", 49.99, 1));
        order2.AddProduct(new Product("SD Card", "S202", 15.99, 2));

        // Display Order 1
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Order 1 Total Cost: ${order1.GetTotalCost():0.00}");
        Console.WriteLine();

        // Display Order 2
        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Order 2 Total Cost: ${order2.GetTotalCost():0.00}");
    }
}
