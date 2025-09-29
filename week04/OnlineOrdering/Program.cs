using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Initialize all mock data
        Customer.InitializeMockCustomers();
        Product.InitializeMockProducts();

        // Get customers and products from the mock lists
        List<Customer> customers = Customer.GetCustomers();
        List<Product> products = Product.GetProducts();

        Console.WriteLine("==========================================");
        Console.WriteLine("       ONLINE ORDER SYSTEM");
        Console.WriteLine("==========================================\n");

        // Creates Order# 1 - USA Customer with 2 products
        Console.WriteLine("CREATING ORDER #1...\n");
        Order order1 = new Order(customers[0]); // Alice Johnson (USA)
        order1.AddProduct(products[0]); // Laptop (x2)
        order1.AddProduct(products[2]); // Mechanical Keyboard (x3)
        
        order1.DisplayOrderSummary();

        // Creates Order# 2 - International Customer with 3 products
        Console.WriteLine("CREATING ORDER #2...\n");
        Order order2 = new Order(customers[5]); // Benito Torres (Argentina)
        order2.AddProduct(products[1]); // Wireless Mouse (x5)
        order2.AddProduct(products[3]); // USB-C Hub (x4)
        order2.AddProduct(products[5]); // Webcam (x1)
        
        order2.DisplayOrderSummary();

        // Display summary comparison
        Console.WriteLine("==========================================");
        Console.WriteLine("           ORDERS SUMMARY");
        Console.WriteLine("==========================================");
        Console.WriteLine($"Order #1 (USA): Total = ${order1.CalculateTotalPrice():0.00}");
        Console.WriteLine($"Order #2 (International): Total = ${order2.CalculateTotalPrice():0.00}");
        Console.WriteLine("==========================================\n");
    }
}