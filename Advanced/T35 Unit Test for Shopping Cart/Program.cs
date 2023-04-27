using System;
using System.Collections.Generic;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}


public class Program
{
    static void Main()
    {
     
        List<Product> productList = new List<Product>();

     
        productList.Add(new Product { Name = "Milk", Price = 1.4m });
        productList.Add(new Product { Name = "Bread", Price = 2.2m });
        productList.Add(new Product { Name = "Butter", Price = 3.2m });
        productList.Add(new Product { Name = "Cheese", Price = 4.2m });
        Console.WriteLine("Your products in shopping cart:");
        foreach (Product product in productList)
        {
            Console.WriteLine($"- product: {product.Name} {product.Price} e");
        }
        Console.WriteLine($"There are {productList.Count} products in the shopping cart.");
;
    }
}