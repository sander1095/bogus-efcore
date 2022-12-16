using bogus_efcore;

using Microsoft.EntityFrameworkCore;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddHostedService<Worker>();

        services.AddDbContext<BogusContext>(x =>
        {
            x.UseSqlServer(hostContext.Configuration.GetConnectionString("Database"));
        });

    })
    .Build();

await host.RunAsync();
