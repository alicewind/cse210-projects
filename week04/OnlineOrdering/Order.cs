using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    double totalCost = 0;
    double shipping = 0;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalcTotalCost()
    {
        // add if statement for calculating shipping
        foreach (Product product in _products)
        {
            totalCost += product.CalcProductTotalCost();
        }
        if (_customer.LivesInUSA())
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        return shipping + totalCost;
    }
    public void DisplayPackingLabel()
    {
        Console.WriteLine("-----Packing Label-----");
        foreach (Product product in _products)
        {
            product.Display();
        }
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine("-----Shipping Label-----");
        Console.WriteLine(_customer.GetDisplayText());
    }
}