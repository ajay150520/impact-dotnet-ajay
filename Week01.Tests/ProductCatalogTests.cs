using Xunit;

public class ProductCatalogTests
{
    [Fact]
    public void GroupByCategory_ShouldGroupProductsCorrectly()
    {
        List<Product> products =
        [
            new Product
            {
                Name = "Laptop",
                Price = 75000,
                Category = ProductCategory.Electronics
            },
            new Product
            {
                Name = "Mouse",
                Price = 1200,
                Category = ProductCategory.Electronics
            },
            new Product
            {
                Name = "T-Shirt",
                Price = 1500,
                Category = ProductCategory.Clothing
            },
            new Product
            {
                Name = "Jeans",
                Price = 2500,
                Category = ProductCategory.Clothing
            },
            new Product
            {
                Name = "Coffee",
                Price = 450,
                Category = ProductCategory.Food
            }
        ];

        ProductCatalog catalog = new ProductCatalog(products);

        Dictionary<ProductCategory, List<Product>> result =
            catalog.GroupByCategory();

        Assert.Equal(3, result.Count);
        Assert.Equal(2, result[ProductCategory.Electronics].Count);
        Assert.Equal(2, result[ProductCategory.Clothing].Count);
        Assert.Single(result[ProductCategory.Food]);

        Assert.Contains(
            result[ProductCategory.Electronics],
            product => product.Name == "Laptop");

        Assert.Contains(
            result[ProductCategory.Clothing],
            product => product.Name == "Jeans");

        Assert.Contains(
            result[ProductCategory.Food],
            product => product.Name == "Coffee");
    }


    [Fact]
    public void GroupByCategory_ShouldHandleEmptyProductList()
    {
        ProductCatalog catalog = new ProductCatalog([]);

        Dictionary<ProductCategory, List<Product>> result =
            catalog.GroupByCategory();

        Assert.Empty(result);
    }
}