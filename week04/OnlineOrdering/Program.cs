using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main ST", "Seattle", "WA","USA");
        Customer customer1 = new Customer ("Mary Kay", address1);
        Order order1 = new Order(customer1);
        Product p1 = new Product("Wireless Mouse", "P101", 25.50, 2);
        Product p2 = new Product("Mechanical Keyboard", "P102", 75.00, 1);
        Product p3 = new Product("USB-C Cable", "P103", 9.99, 3);

        order1.AddProduct(p1);
        order1.AddProduct(p2);
        order1.AddProduct(p3);

        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Sarah Connor", address2);
        Order order2 = new Order(customer2);
        Product p4 = new Product("HD Monitor 27\"", "P201", 180.00, 1);
        Product p5 = new Product("HDMI Cable 6ft", "P202", 12.00, 2);

        order2.AddProduct(p4);
        order2.AddProduct(p5);

        
        Console.WriteLine("ORDER 1 DETAILS");
        Console.WriteLine("==========================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}\n");
        Console.WriteLine();

        
        Console.WriteLine("ORDER 2 DETAILS");
        Console.WriteLine("==========================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}\n");
        Console.WriteLine();
    }
}