using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Basketball", "S105", 24.99, 1);
        Product product2 = new Product("Pickleball Set", "S211", 17.99, 2);
        Product product3 = new Product("Baseball Bat", "S575", 12.99, 1);

        Address address1 = new Address("25 West Barley St", "Wilsonville", "Montana", "USA");
        Customer customer1 = new Customer("Bob Smith", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();

        Console.WriteLine($"Total Cost: ${order1.CalcTotalCost()}");

        Product product4 = new Product("Sheets", "B414", 65.00, 1);
        Product product5 = new Product("Comforter", "B173", 86.10, 1);
        Product product6 = new Product("Pillow", "B085", 6.99, 4);

        Address address2 = new Address("1475 Country Lane", "Peach City", "Georgia", "USA");
        Customer customer2 = new Customer("Marilyn Jones", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();

        Console.WriteLine($"Total Cost: ${order2.CalcTotalCost()}");

        Product product7 = new Product("Pants", "B414", 45.00, 1);
        Product product8 = new Product("Shirt", "B173", 34.80, 1);
        Product product9 = new Product("Socks", "B085", 4.50, 3);

        Address address3 = new Address("673 Mountain Spring Drive", "Jamestown", "BC", "Canada");
        Customer customer3 = new Customer("Clyde Heath", address3);
        Order order3 = new Order(customer3);

        order3.AddProduct(product7);
        order3.AddProduct(product8);
        order3.AddProduct(product9);

        order3.DisplayPackingLabel();
        order3.DisplayShippingLabel();

        Console.WriteLine($"Total Cost: ${order3.CalcTotalCost()}");
    }
}