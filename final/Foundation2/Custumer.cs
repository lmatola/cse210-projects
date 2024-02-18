using System;

public class Customer
{
    // Member Variables
    private string _customerName;
    private Address _customerAddress;

    // Constructors
    public Customer(string customerName, Address address)
    {
        _customerAddress = address;
        _customerName = customerName;
    }

    // Methods
    public string GetCustomerName()
    {
        return _customerName;
    }

    public void SetCustomerName(string name)
    {
        _customerName = name;
    }

    public Address GetCustomerAddress()
    {
        return _customerAddress;
    }

}