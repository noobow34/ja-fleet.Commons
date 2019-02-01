using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace jafleet.Commons.EF
{
    public partial class jafleetContext : DbContext
    {
        public virtual DbSet<Aircraft> Aircraft { get; set; }
        public virtual DbSet<AircraftView> AircraftView { get; set; }
        public virtual DbSet<Airline> Airline { get; set; }
        public virtual DbSet<AirlineGroup> AirlineGroup { get; set; }
        public virtual DbSet<Code> Code { get; set; }
        public virtual DbSet<Maker> Maker { get; set; }
        public virtual DbSet<Type> Type { get; set; }
        public virtual DbSet<TypeDetail> TypeDetail { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<LineUser> LineUser { get; set; }
        public virtual DbSet<SearchCondition> SearchCondition { get; set; }
        public virtual DbSet<DailyStatistics> DailyStatistics { get; set; }
        public virtual DbSet<AdminUser> AdminUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                var connectionString = config.GetConnectionString("DefaultConnection");

                IServiceCollection serviceCollection = new ServiceCollection();
                serviceCollection.AddLogging(builder => builder
                .AddConsole()
                .AddFilter(level => level >= LogLevel.Information)
                );
                var loggerFactory = serviceCollection.BuildServiceProvider().GetService<ILoggerFactory>();

                optionsBuilder.UseLoggerFactory(loggerFactory).UseMySql(connectionString,
                    mySqlOptions =>
                    {
                        mySqlOptions.ServerVersion(new Version(10,3), ServerType.MariaDb);
                    }
                );
            }
        }
    }
}
