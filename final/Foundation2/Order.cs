using System;
using System.Collections.Generic;

public class Order
{
    // Member Variables
    private List<Product> _productList = new List<Product>();

    private Customer _customer;

    // Constructors
    public Order(string customerName, string street, string city, string state, string country)
    {
        Address address = new Address(street, city, state, country); 
         _customer = new Customer(customerName, address); 
    }

    // Methods
    public void PrintPackingSlip()
    {    
        
        Console.WriteLine("Packing List:");
        foreach(Product product in _productList)
        {
            Console.WriteLine($"{product.GetProductID()}: {product.GetProductName()} ({product.GetProductQuantity()})");
        }
    }

    public void PrintShippingLabel()
    {
        
        Console.WriteLine("
        Shipping Label: ");
        Console.WriteLine(_customer.GetCustomerName());
        Console.WriteLine(_customer.GetCustomerAddress().GetAddress());
    }

    public double CalculateShippingCosts()
    {
       
        if (_customer.GetCustomerAddress().GetCountry())
            return 5;
        else
            return 35;
    }

    public double TotalOrderPrice()
    {
        double productOrder = 0 + CalculateShippingCosts(); 
        foreach(Product product in _productList)
        {
            productOrder += product.GetSubtotalPrice();
        }
        
        return Math.Round(productOrder, 2);
    }

    public void AddProduct(string name, string id, double price, int quantity)
    {
        Product product = new Product(name, id, price, quantity);
        _productList.Add(product);
    }
}