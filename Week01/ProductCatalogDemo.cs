public static class ProductCatalogDemo
{
    public static void Run()
    {
        Console.WriteLine("----- Mini Q1: Product Catalog -----");

        List<Product> products = new()
        {
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
        };

        ProductCatalog catalog = new ProductCatalog(products);

        Dictionary<ProductCategory, List<Product>> groupedProducts =
            catalog.GroupByCategory();

        foreach (ProductCategory category in Enum.GetValues<ProductCategory>())
        {
            if (!groupedProducts.TryGetValue(category, out List<Product>? categoryProducts))
            {
                continue;
            }

            Console.WriteLine();
            Console.WriteLine(category);
            Console.WriteLine(new string('-', category.ToString().Length));

            foreach (Product product in categoryProducts)
            {
                Console.WriteLine(
                    $"{product.Name} - ₹{product.Price:0.00}"
                );
            }
        }
    }
}