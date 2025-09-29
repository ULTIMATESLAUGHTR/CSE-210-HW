using System;
using System.Collections.Generic;

class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    private static List<Address> addresses = new List<Address>();

    public static void InitializeMockAddresses()
    {
        addresses.Clear(); // Clear any existing addresses
        addresses.Add(new Address("123 Maple St", "Springfield", "IL", "USA"));
        addresses.Add(new Address("456 Oak St", "Metropolis", "IL", "USA"));
        addresses.Add(new Address("789 Pine St", "Gotham", "NJ", "USA"));
        addresses.Add(new Address("101 Elm St", "Smallville", "KS", "USA"));
        addresses.Add(new Address("1007 Mountain Dr", "Gotham", "NJ", "USA"));
        addresses.Add(new Address("Cabildo Abierto 123", "Mendoza", "", "Argentina"));
    }

    public static void AddAddress(Address address)
    {
        addresses.Add(address);
    }

    public static List<Address> GetAddresses()
    {
        return addresses;
    }

    public bool IsInUSA()
    {
        return country.ToLower() == "usa" || country.ToLower() == "united states" || country.ToLower() == "united states of america";
    }

    public bool IsInternational()
    {
        return !IsInUSA();
    }

    public string GetFormattedAddress()
    {
        if (string.IsNullOrEmpty(state))
        {
            return $"{street}, {city}, {country}";
        }
        return $"{street}, {city}, {state}, {country}";
    }

    public void DisplayAddress()
    {
        if (IsInUSA())
        {
            Console.WriteLine($"Domestic US Shipping Address, Subject to $5 Shipping Charge: {street}, {city}, {state}, {country}");
        }
        else if (IsInternational())
        {
            Console.WriteLine($"This is an international address and will be subject to a $35 Shipping Charge: {street}, {city}, {state}, {country}");
        }
    }
}