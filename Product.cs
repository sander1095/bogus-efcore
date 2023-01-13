namespace bogus_efcore;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTimeOffset CreationDate { get; set; }
    public ICollection<ProductCategory> Categories { get; set; } = new List<ProductCategory>();
}

public class ProductCategory
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public ICollection<Product> Products { get; set; } = new List<Product>();
}