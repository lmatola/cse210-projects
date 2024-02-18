using System;

public class Address
{
    

    // Member Variables
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    // Constructors
    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = state;
        _country = country;
    }

    // Methods (Getters and Setters)
    public bool GetCountry()
    {
        return _country.ToLower() == "usa";
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    public string GetAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }

    public void SetAddress(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = state;
        _country = country;
    }


}