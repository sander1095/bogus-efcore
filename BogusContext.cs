using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bogus;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bogus_efcore
{
    public class BogusContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EventMap());
            base.OnModelCreating(modelBuilder);
        }
    }

    internal class EventMap : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Date).IsRequired();

            var id = 0;
            var events = new Faker<Event>()
                .RuleFor(x => x.Id, f => id++)
                .RuleFor(x => x.Name, f => f.Commerce.ProductName())
                .RuleFor(x => x.Date, f => f.Date.FutureOffset(refDate: new DateTimeOffset(2022, 12, 16, 15, 15, 0, TimeSpan.FromHours(1))));
            
            builder.HasData(events.UseSeed(1338).Generate(1000));
        }
    }    
}
