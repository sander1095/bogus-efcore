using Bogus;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bogus_efcore;

public class BogusContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();
    public DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();

    public DbSet<ProductProductCategory> ProductProductCategories => Set<ProductProductCategory>();

    public BogusContext(DbContextOptions<BogusContext> options): base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new ProductProductCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());

        var categoryId = 1;
        var categoryFaker = new Faker<ProductCategory>()
            .RuleFor(x => x.Id, f => categoryId++)
            .RuleFor(x => x.Name, f => f.Commerce.Categories(1).First());

        var categories = Enumerable.Range(1, 50)
            .Select(i => SeedRow(categoryFaker, i))
            .ToList();

        var productId = 1;
        var productFaker = new Faker<Product>()
            .RuleFor(x => x.Id, f => productId++)
            .RuleFor(x => x.Name, f => f.Commerce.ProductName())
            .RuleFor(x => x.CreationDate, f => f.Date.FutureOffset(refDate: new DateTimeOffset(2023, 1, 16, 15, 15, 0, TimeSpan.FromHours(1))))
            .RuleFor(x => x.Description, f => f.Commerce.ProductDescription());

        var products = Enumerable.Range(1, 1000)
            .Select(i => SeedRow(productFaker, i))
            .ToList();

        var productProductCategoryFaker = new Faker<ProductProductCategory>()
            .RuleFor(x => x.ProductId, f => f.PickRandom(products).Id)
            .RuleFor(x => x.CategoryId, f => f.PickRandom(categories).Id);

        var productProductCategories = Enumerable.Range(1, 1000)
            .Select(i => SeedRow(productProductCategoryFaker, i))
            .GroupBy(x => new { x.ProductId, x.CategoryId })
            .Select(x => x.First())
            .ToList();

        modelBuilder.Entity<Product>().HasData(products);
        modelBuilder.Entity<ProductCategory>().HasData(categories);
        modelBuilder.Entity<ProductProductCategory>().HasData(productProductCategories);

        base.OnModelCreating(modelBuilder);

        static T SeedRow<T>(Faker<T> faker, int rowId) where T : class
        {
            var recordRow = faker.UseSeed(rowId).Generate();
            return recordRow;
        };
    }
}

internal class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Product");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.CreationDate).IsRequired();
        builder.Property(x => x.Description).IsRequired();
    }
}

internal class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.ToTable("ProductCategory");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired();
    }
}

internal class ProductProductCategoryConfiguration : IEntityTypeConfiguration<ProductProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductProductCategory> builder)
    {
        builder.ToTable("ProductProductCategory");

        builder.HasKey(x => new { x.ProductId, x.CategoryId });

        builder.HasOne(x => x.Product)
            .WithMany(x => x.ProductProductCategories)
            .HasForeignKey(x => x.ProductId);

        builder.HasOne(b => b.Category)
            .WithMany()
            .HasForeignKey(x => x.CategoryId);
    }
}
