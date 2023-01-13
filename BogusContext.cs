using Bogus;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bogus_efcore;

public class BogusContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductProductCategory> ProductProductCategories { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }

    public BogusContext(DbContextOptions<BogusContext> options): base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new ProductProductCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());

        base.OnModelCreating(modelBuilder);
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

        //var categoryId = 1;
        //var categoryFaker = new Faker<ProductCategory>()
        //    .RuleFor(x => x.Id, f => categoryId++)
        //    .RuleFor(x => x.Name, f => f.Commerce.Categories(1).First());

        //var productId = 1;
        //var productFaker = new Faker<Product>()
        //    .RuleFor(x => x.Id, f => productId++)
        //    .RuleFor(x => x.Name, f => f.Commerce.ProductName())
        //    .RuleFor(x => x.CreationDate, f => f.Date.FutureOffset(refDate: new DateTimeOffset(2023, 1, 16, 15, 15, 0, TimeSpan.FromHours(1))));

        //builder.HasData(productFaker.UseSeed(1338).Generate(100));
    }
}

internal class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.ToTable("ProductCategory");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired();

        //var id = 1;
        //var events = new Faker<ProductCategory>()
        //    .RuleFor(x => x.Id, f => id++)
        //    .RuleFor(x => x.Name, f => f.Commerce.ProductName())
        //    .RuleFor(x => x.Date, f => f.Date.FutureOffset(refDate: new DateTimeOffset(2022, 12, 16, 15, 15, 0, TimeSpan.FromHours(1))));

        //builder.HasData(events.UseSeed(1338).Generate(1000));
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
