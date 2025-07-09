using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Order> listOfOrders = new List<Order>();
        listOfOrders.Add(new Order("Abe Appleton","Main Street","Manhattan","NY","USA"));
        listOfOrders[0].SetProductToOrder(1,"Dr. Pepper",0.99,6);
        listOfOrders[0].SetProductToOrder(2,"Pizza Big",19.99,1);
        listOfOrders[0].SetProductToOrder(3,"Apple Pie",5.99,2);
        listOfOrders.Add(new Order("Benjamin Bonilla","Calle Principal","Choloma","Cortes","Honduras"));
        listOfOrders[1].SetProductToOrder(4,"Copan Dry",0.99,10);
        listOfOrders[1].SetProductToOrder(5,"Baleadas",1.49,20);
        listOfOrders[1].SetProductToOrder(6,"German Chocolate",9.99,1);

        foreach (Order order in listOfOrders)
        {
            order.GetOrderTotal();
            order.GetPackingLabel();
            order.GetShippingLabel();
        }
    }
}
/*
Program 2: Encapsulation with Online Ordering

Scenario
You have been hired to help a company with their product ordering 
system. They sell many products online to a variety of customers 
and need to produce packing labels, shipping labels, and compute 
final prices for billing.

Program Specification
Write a program that has classes for Product, Customer, Address, and 
Order. The responsibilities of these classes are as follows:

Order
- Contains a list of products and a customer. 
    - Can calculate the total cost of the order. 
    - Can return a string for the packing label. 
    - Can return a string for the shipping label.
- The total price is calculated as the sum of the total cost of each 
    product plus a one-time shipping cost.
- This company is based in the USA. If the customer lives in the USA, 
    then the shipping cost is $5. If the customer does not live in 
    the USA, then the shipping cost is $35.
- A packing label should list the name and product id of each 
    product in the order.
- A shipping label should list the name and address of the customer

Product
- Contains the name, product id, price per unit, and quantity of 
    each product.
- The total cost of this product is computed by multiplying the 
    price per unit and the quantity. If the price per unit was $3 
    and they bought 5, the product total cost would be $15.

Customer
- The customer contains a name and an address.
- The name is a string, but the Address is a class.
- The customer should have a method that can return whether they 
    live in the USA or not. (Hint this should call a method on the 
    address to find this.)

Address
- The address contains a string for the street address, the city, 
    state/province, and country.
- The address should have a method that can return whether it is 
    in the USA or not.
- The address should have a method to return a string all of its 
    fields together in one string (with newline characters where 
    appropriate)

Other considerations
Make sure that all member variables are private and getters, setters, 
and constructors are created as needed.

Once you have created these classes, write a program that creates at 
least two orders with a 2-3 products each. Call the methods to get the 
packing label, the shipping label, and the total price of the order, 
and display the results of these methods.

*/