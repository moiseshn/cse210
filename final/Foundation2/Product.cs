using System;
using System.Runtime.CompilerServices;
public class Product
{
    // Attributes
    private int _productId;
    private string _productName;
    private double _productPrice;
    private int _productQty;

    // Constructors
    public Product(int id, string name, double price, int quantity)
    {
        _productId = id;
        _productName = name;
        _productPrice = price;
        _productQty = quantity;
    }
    // Getters
    public int GetProductId()
    {
        return _productId;
    }
    public string GetProductName()
    {
        return _productName;
    }

    // Methods
    public double GetProductTotal()
    {
        return _productPrice * _productQty;
    }
}