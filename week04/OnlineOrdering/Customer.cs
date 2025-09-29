using System;
using System.Collections.Generic;

class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    private static List<Customer> customers = new List<Customer>();

    public static void InitializeMockCustomers()
    {
        customers.Clear(); // Clear any existing customers
        customers.Add(new Customer("Alice Johnson", new Address("123 Maple St", "Springfield", "IL", "USA")));
        customers.Add(new Customer("Bye Felicia", new Address("456 Oak St", "Metropolis", "IL", "USA")));
        customers.Add(new Customer("John Doe", new Address("789 Pine St", "Gotham", "NJ", "USA")));
        customers.Add(new Customer("Jane Smith", new Address("101 Elm St", "Smallville", "KS", "USA")));
        customers.Add(new Customer("Bruce Wayne", new Address("1007 Mountain Dr", "Gotham", "NJ", "USA")));
        customers.Add(new Customer("Benito Torres", new Address("Cabildo Abierto 123", "Mendoza", "", "Argentina")));
    }

    public static void AddCustomer(Customer customer)
    {
        customers.Add(customer);
    }

    public static List<Customer> GetCustomers()
    {
        return customers;
    }

    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }

    public void DisplayCustomerInfo()
    {
        string location = LivesInUSA() ? "USA" : "International";
        Console.WriteLine($"Customer Information: Name: {name}, Location: {location}");
        address.DisplayAddress();
    }

    public string GetName()
    {
        return name;
    }

    public Address GetAddress()
    {
        return address;
    }
}