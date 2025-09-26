using System;

public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string productName, string productID, double price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public double CalcProductTotalCost()
    {
        return _price * _quantity;
    }
    public void Display()
    {
        Console.WriteLine($"Product ID: {_productID} Item: {_productName} ");
    }
}