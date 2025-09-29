using System;
using System.Collections.Generic;

class Product
{
    private string productName;
    private string productId;
    private double price;
    private int quantity;

    public Product(string productName, string productId, double price, int quantity)
    {
        this.productName = productName;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    private static List<Product> products = new List<Product>();

    public static void InitializeMockProducts()
    {
        products.Clear();
        products.Add(new Product("Gamer Laptop", "P001", 899.99, 2));
        products.Add(new Product("Wireless Gamer Mouse", "P002", 25.50, 5));
        products.Add(new Product("RGB Mechanical Keyboard", "P003", 89.99, 3));
        products.Add(new Product("USB-C WireHub", "P004", 45.00, 4));
        products.Add(new Product("Monitor Stand", "P005", 35.75, 2));
        products.Add(new Product("BlueYeti Webcam", "P006", 69.99, 1));
    }

    public static void AddProduct(Product product)
    {
        products.Add(product);
    }

    public static List<Product> GetProducts()
    {
        return products;
    }

    public string GetName()
    {
        return productName;
    }

    public double GetPrice()
    {
        return price;
    }

    public string GetProductId()
    {
        return productId;
    }

    public int GetQuantity()
    {
        return quantity;
    }

    public void SetProductId(string newProductId)
    {
        productId = newProductId;
    }

    public void SetQuantity(int newQuantity)
    {
        quantity = newQuantity;
    }

    public double CalculateTotalCost()
    {
        return price * quantity;
    }

    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product ID: {productId}");
        Console.WriteLine($"Product Name: {productName}");
        Console.WriteLine($"Price per unit: ${price:0.00}");
        Console.WriteLine($"Quantity: {quantity}");
        Console.WriteLine($"Total Cost: ${CalculateTotalCost():0.00}");
    }
}