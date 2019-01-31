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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aircraft>(entity =>
            {
                entity.HasKey(e => e.RegistrationNumber);

                entity.ToTable("AIRCRAFT");

                entity.Property(e => e.RegistrationNumber)
                    .HasColumnName("REGISTRATION_NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Airline).HasColumnName("AIRLINE");

                entity.Property(e => e.CreationTime).HasColumnName("CREATION_TIME");

                entity.Property(e => e.OperationCode).HasColumnName("OPERATION_CODE");

                entity.Property(e => e.RegisterDate).HasColumnName("REGISTER_DATE");

                entity.Property(e => e.Remarks).HasColumnName("REMARKS");

                entity.Property(e => e.SerialNumber).HasColumnName("SERIAL_NUMBER");

                entity.Property(e => e.TypeCode).HasColumnName("TYPE_CODE");

                entity.Property(e => e.TypeDetailCode).HasColumnName("TYPE_DETAIL_CODE");

                entity.Property(e => e.UpdateTime).HasColumnName("UPDATE_TIME");

                entity.Property(e => e.WifiCode).HasColumnName("WIFI_CODE");

                entity.Property(e => e.LinkUrl).HasColumnName("LINK_URL");

                entity.Property(e => e.ActualUpdateTime).HasColumnName("ACTUAL_UPDATE_TIME");
            });

            modelBuilder.Entity<AircraftView>(entity =>
            {
                entity.HasKey(e => e.RegistrationNumber);

                entity.ToTable("aircraft_view");

                entity.Property(e => e.RegistrationNumber)
                    .HasColumnName("REGISTRATION_NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Airline).HasColumnName("AIRLINE");

                entity.Property(e => e.AirlineGroupCode).HasColumnName("AIRLINE_GROUP_CODE");

                entity.Property(e => e.AirlineNameJpShort).HasColumnName("AIRLINE_NAME_JP_SHORT");

                entity.Property(e => e.CreationTime).HasColumnName("CREATION_TIME");

                entity.Property(e => e.DisplayOrder).HasColumnName("DISPLAY_ORDER");

                entity.Property(e => e.Operation).HasColumnName("OPERATION");

                entity.Property(e => e.OperationCode).HasColumnName("OPERATION_CODE");

                entity.Property(e => e.RegisterDate).HasColumnName("REGISTER_DATE");

                entity.Property(e => e.Remarks).HasColumnName("REMARKS");

                entity.Property(e => e.SerialNumber).HasColumnName("SERIAL_NUMBER");

                entity.Property(e => e.TypeCode).HasColumnName("TYPE_CODE");

                entity.Property(e => e.TypeName).HasColumnName("TYPE_NAME");

                entity.Property(e => e.TypeDetailCode).HasColumnName("TYPE_DETAIL_CODE");

                entity.Property(e => e.TypeDetailName).HasColumnName("TYPE_DETAIL_NAME");

                entity.Property(e => e.UpdateTime).HasColumnName("UPDATE_TIME");

                entity.Property(e => e.Wifi).HasColumnName("WIFI");

                entity.Property(e => e.WifiCode).HasColumnName("WIFI_CODE");

                entity.Property(e => e.LinkUrl).HasColumnName("LINK_URL");

                entity.Property(e => e.ActualUpdateTime).HasColumnName("ACTUAL_UPDATE_TIME");
            });

            modelBuilder.Entity<Code>(entity =>
            {
                entity.HasKey(e => new { e.CodeType, e.Key });

                entity.ToTable("CODE");

                entity.Property(e => e.CodeType).HasColumnName("CODE_TYPE");

                entity.Property(e => e.Key).HasColumnName("KEY");

                entity.Property(e => e.Value).HasColumnName("VALUE");
            });

            modelBuilder.Entity<TypeDetail>(entity =>
            {
                entity.HasKey(e => new { e.TypeCode, e.TypeDetailCode });

                entity.ToTable("TYPE_DETAIL");

                entity.Property(e => e.TypeCode).HasColumnName("TYPE_CODE");

                entity.Property(e => e.TypeDetailCode).HasColumnName("TYPE_DETAIL_CODE");

                entity.Property(e => e.TypeDetailName).HasColumnName("TYPE_DETAIL_NAME");
            });

        }
    }
}
