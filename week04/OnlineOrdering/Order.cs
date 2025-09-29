using System;
using System.Collections.Generic;

class Order
{
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public string GetPackingLabel()
    {
        string label = "=== PACKING LABEL ===\n";
        foreach (Product product in products)
        {
            label += $"Product: {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "=== SHIPPING LABEL ===\n";
        label += $"Customer: {customer.GetName()}\n";
        label += $"Address: {customer.GetAddress().GetFormattedAddress()}\n";
        return label;
    }

    public double CalculateTotalPrice()
    {
        double productTotal = 0;
        foreach (Product product in products)
        {
            productTotal += product.CalculateTotalCost();
        }

        // Add shipping cost based on location
        double shippingCost = customer.LivesInUSA() ? 5.00 : 35.00;
        return productTotal + shippingCost;
    }

    public void DisplayOrderSummary()
    {
        Console.WriteLine("\n" + GetPackingLabel());
        Console.WriteLine(GetShippingLabel());
        
        Console.WriteLine("\n=== ORDER TOTAL ===");
        double productTotal = 0;
        foreach (Product product in products)
        {
            double productCost = product.CalculateTotalCost();
            Console.WriteLine($"{product.GetName()} (x{product.GetQuantity()}): ${productCost:0.00}");
            productTotal += productCost;
        }
        
        double shippingCost = customer.LivesInUSA() ? 5.00 : 35.00;
        string shippingType = customer.LivesInUSA() ? "Domestic" : "International";
        
        Console.WriteLine($"\nSubtotal: ${productTotal:0.00}");
        Console.WriteLine($"Shipping ({shippingType}): ${shippingCost:0.00}");
        Console.WriteLine($"Total Price: ${CalculateTotalPrice():0.00}");
        Console.WriteLine("==========================================\n");
    }
}