using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("32 cally road", "utah", "idaho", "USA");
        Address address2 = new Address("665 miami street", "idaho", "provo", "Canada");

        Customer customer1 = new Customer("Victor Patrick", address1);
        Customer customer2 = new Customer("Peter Ekpang", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Kettle", "P653", 850.00, 1));
        order1.AddProduct(new Product("Pot", "47u2", 78.00, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Music Player", "P903", 870.00, 1));
        order2.AddProduct(new Product("Laptop", "T860", 39.00, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: ${order1.GetTotalPrice():0.00}");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: ${order2.GetTotalPrice():0.00}");
    }
}
