using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class ShoppingCartTests
{
    [Test]
    public void Test_ShoppingCart_With_No_Products()
    {
        // Arrange
        List<Product> productList = new List<Product>();

        // Act
        string result = GetShoppingCartSummary(productList);

        // Assert
        Assert.AreEqual("There are 0 products in the shopping cart.", result);
    }

    [Test]
    public void Test_ShoppingCart_With_One_Product()
    {
        // Arrange
        List<Product> productList = new List<Product>
        {
            new Product { Name = "Milk", Price = 1.4m }
        };

        // Act
        string result = GetShoppingCartSummary(productList);

        // Assert
        Assert.AreEqual("There are 1 product in the shopping cart.", result);
    }

    [Test]
    public void Test_ShoppingCart_With_Two_Products()
    {
        // Arrange
        List<Product> productList = new List<Product>
        {
            new Product { Name = "Milk", Price = 1.4m },
            new Product { Name = "Bread", Price = 2.2m }
        };

        // Act
        string result = GetShoppingCartSummary(productList);

        // Assert
        Assert.AreEqual("There are 2 products in the shopping cart.", result);
    }

    [Test]
    public void Test_ShoppingCart_With_Five_Products()
    {
        // Arrange
        List<Product> productList = new List<Product>
        {
            new Product { Name = "Milk", Price = 1.4m },
            new Product { Name = "Bread", Price = 2.2m },
            new Product { Name = "Butter", Price = 3.2m },
            new Product { Name = "Cheese", Price = 4.2m },
            new Product { Name = "Eggs", Price = 2.5m }
        };

        // Act
        string result = GetShoppingCartSummary(productList);

        // Assert
        Assert.AreEqual("There are 5 products in the shopping cart.", result);
    }

    // Helper method to get shopping cart summary
    private string GetShoppingCartSummary(List<Product> productList)
    {
        int count = productList.Count;
        return $"There are {count} {(count == 1 ? "product" : "products")} in the shopping cart.";
    }
}
