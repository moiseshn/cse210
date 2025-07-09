using System;
using System.Linq;
using System.Reflection.Emit;
public class Order
{
    // Attributes
    private List<Product> _products = new List<Product>();
    private Customer _customer = new Customer();
    private double _total;

    // Constructors
    public Order()
    { }
    public Order(string customerName, string street, string city, string state, string country)
    {
        _customer.SetCustomerName(customerName);
        _customer.SetCustomerAddress(street, city, state, country);
    }

    // Setters
    public void SetProductToOrder(int id, string name, double price, int quantity)
    {
        _products.Add(new Product(id, name, price, quantity));
    }

    // Methods
    public void GetOrderTotal()
    {
        // foreach (Product product in _products)
        // {
        //     float total = 0f;
        //     total += product.GetProductTotal();
        // }
        // LINQ METHOD: https://stackoverflow.com/questions/23891682/how-to-get-the-sum-of-list-object-property-values-using-foreach
        _total = _products.Sum(p => p.GetProductTotal()) + GetShippingCost();
        Console.WriteLine($"\n*****************\nOrder Total: {_total}");
    }
    public double GetShippingCost()
    {
        if (_customer.IsUsaCustomer() == true)
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
    public void GetPackingLabel()
    {
        Console.WriteLine("\nPacking List:");
        foreach (var product in _products)
        {
            Console.WriteLine($" - ID: {product.GetProductId()}, {product.GetProductName()}");
        }
    }
    public void GetShippingLabel()
    {
        Console.WriteLine($"\nShip to: ");
        Console.WriteLine(_customer.GetCustomerName());
        Console.WriteLine(_customer.GetCustomerAddress());
    }
}

/*
cannot implicitly convert type string to class object in c#
https://stackoverflow.com/questions/25890675/cannot-implicitly-convert-type-string-to-consoleapplication1-kategori

*/