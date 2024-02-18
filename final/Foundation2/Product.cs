using System;

public class Product
{
    // Member variables
    private string _productName;
    private string _productID;
    private double _productPrice;
    private int _productQuantity;

    // Constructors
    public Product(string name, string id, double price, int quantity)
    {
        _productName = name;
        _productID = id;
        _productPrice = price;
        _productQuantity = quantity;
    }

    // Methods
    public double GetSubtotalPrice()
    {
        return _productPrice * _productQuantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public int GetProductQuantity()
    {
        return _productQuantity;
    }

}