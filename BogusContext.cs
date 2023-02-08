using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bogus_efcore;

public class BogusContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();
    public DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();
    public DbSet<ProductProductCategory> ProductProductCategories => Set<ProductProductCategory>();

    public BogusContext(DbContextOptions<BogusContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure the tables
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new ProductProductCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());

        // Generate seed data with Bogus
        var databaseSeeder = new DatabaseSeeder();

        // Apply the seed data on the tables
        modelBuilder.Entity<Product>().HasData(databaseSeeder.Products);
        modelBuilder.Entity<ProductCategory>().HasData(databaseSeeder.ProductCategories);
        modelBuilder.Entity<ProductProductCategory>().HasData(databaseSeeder.ProductProductCategories);

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