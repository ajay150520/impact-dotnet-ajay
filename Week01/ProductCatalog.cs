public enum ProductCategory
{
    Electronics,
    Clothing,
    Food
}

public class Product
{
    public string Name { get; set; } = string.Empty;

    public double Price { get; set; }

    public ProductCategory Category { get; set; }
}

public class ProductCatalog
{
    private readonly List<Product> products;

    public ProductCatalog(IEnumerable<Product> products)
    {
        this.products = products.ToList();
    }

    public Dictionary<ProductCategory, List<Product>> GroupByCategory()
    {
        return products
            .GroupBy(product => product.Category)
            .ToDictionary(
                group => group.Key,
                group => group.ToList()
            );
    }
}