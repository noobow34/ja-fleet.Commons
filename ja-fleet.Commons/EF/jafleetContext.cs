using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace jafleet.Commons.EF
{
    public partial class jafleetContext : DbContext
    {
        public jafleetContext()
        {
        }

        public jafleetContext(DbContextOptions<jafleetContext> options)
            : base(options)
        {
        }

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

        public static readonly LoggerFactory MyLoggerFactory
            = new LoggerFactory(new[]
            {
            new ConsoleLoggerProvider((category, level)
                => category == DbLoggerCategory.Database.Command.Name
                && level == LogLevel.Information, true)
            });


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                var connectionString = config.GetConnectionString("DefaultConnection");
                optionsBuilder.UseLoggerFactory(MyLoggerFactory).UseMySql(connectionString,
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

            modelBuilder.Entity<Airline>(entity =>
            {
                entity.HasKey(e => e.AirlineCode);

                entity.ToTable("AIRLINE");

                entity.Property(e => e.AirlineCode)
                    .HasColumnName("AIRLINE_CODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.AirlineGroupCode).HasColumnName("AIRLINE_GROUP_CODE");

                entity.Property(e => e.AirlineNameEn).HasColumnName("AIRLINE_NAME_EN");

                entity.Property(e => e.AirlineNameEnShort).HasColumnName("AIRLINE_NAME_EN_SHORT");

                entity.Property(e => e.AirlineNameJp).HasColumnName("AIRLINE_NAME_JP");

                entity.Property(e => e.AirlineNameJpShort).HasColumnName("AIRLINE_NAME_JP_SHORT");

                entity.Property(e => e.DisplayOrder).HasColumnName("DISPLAY_ORDER");
            });

            modelBuilder.Entity<AirlineGroup>(entity =>
            {
                entity.HasKey(e => e.AirlineGroupCode);

                entity.ToTable("AIRLINE_GROUP");

                entity.Property(e => e.AirlineGroupCode)
                    .HasColumnName("AIRLINE_GROUP_CODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.AirlineGroupName).HasColumnName("AIRLINE_GROUP_NAME");
            });

            modelBuilder.Entity<Code>(entity =>
            {
                entity.HasKey(e => new { e.CodeType, e.Key });

                entity.ToTable("CODE");

                entity.Property(e => e.CodeType).HasColumnName("CODE_TYPE");

                entity.Property(e => e.Key).HasColumnName("KEY");

                entity.Property(e => e.Value).HasColumnName("VALUE");
            });

            modelBuilder.Entity<Maker>(entity =>
            {
                entity.HasKey(e => e.MakerCode);

                entity.ToTable("MAKER");

                entity.Property(e => e.MakerCode)
                    .HasColumnName("MAKER_CODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.MakerNameEn).HasColumnName("MAKER_NAME_EN");

                entity.Property(e => e.MakerNameJp).HasColumnName("MAKER_NAME_JP");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.HasKey(e => e.TypeCode);

                entity.ToTable("TYPE");

                entity.Property(e => e.TypeCode)
                    .HasColumnName("TYPE_CODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisplayOrder).HasColumnName("DISPLAY_ORDER");

                entity.Property(e => e.MakerCode).HasColumnName("MAKER_CODE");

                entity.Property(e => e.TypeName).HasColumnName("TYPE_NAME");
            });

            modelBuilder.Entity<TypeDetail>(entity =>
            {
                entity.HasKey(e => new { e.TypeCode, e.TypeDetailCode });

                entity.ToTable("TYPE_DETAIL");

                entity.Property(e => e.TypeCode).HasColumnName("TYPE_CODE");

                entity.Property(e => e.TypeDetailCode).HasColumnName("TYPE_DETAIL_CODE");

                entity.Property(e => e.TypeDetailName).HasColumnName("TYPE_DETAIL_NAME");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("log");

                entity.Property(e => e.LogId)
                .HasColumnName("LOG_ID")
                .ValueGeneratedOnAdd();

                entity.Property(e => e.LogDate).HasColumnName("LOG_DATE");

                entity.Property(e => e.LogType).HasColumnName("LOG_TYPE");

                entity.Property(e => e.LogDetail).HasColumnName("LOG_DETAIL");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.LogDateYyyyMmDd).HasColumnName("LOG_DATE_YYYYMMDD");

                entity.Property(e => e.IsAdmin).HasColumnName("IS_ADMIN");
            });

            modelBuilder.Entity<LineUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("LINE_USER");

                entity.Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .ValueGeneratedNever();

                entity.Property(e => e.UserName).HasColumnName("USER_NAME");

                entity.Property(e => e.ProfileImage).HasColumnName("PROFILE_IMAGE");

                entity.Property(e => e.LastAccess).HasColumnName("LAST_ACCESS");

                entity.Property(e => e.FollowDate).HasColumnName("FOLLOW_DATE");

                entity.Property(e => e.UnfollowDate).HasColumnName("UNFOLLOW_DATE");
            });

            modelBuilder.Entity<SearchCondition>(entity =>
            {
                entity.HasKey(e => e.SearchConditionKey);

                entity.ToTable("SEARCH_CONDITION");

                entity.Property(e => e.SearchConditionKey)
                .HasColumnName("SEARCH_CONDITION_KEY")
                .ValueGeneratedNever();

                entity.Property(e => e.SearchConditionJson).HasColumnName("SEARCH_CONDITOIN");

                entity.Property(e => e.SearchCount).HasColumnName("SEARCH_COUNT");

                entity.Property(e => e.FirstSearchDate).HasColumnName("FIRST_SEARCH_DATE");

                entity.Property(e => e.LastSearchDate).HasColumnName("LAST_SEARCH_DATE");
            });

            modelBuilder.Entity<DailyStatistics>(entity =>
            {
                entity.HasKey(e => e.LogDateYyyyMmDd);

                entity.ToTable("DAILY_STATISTICS");

                entity.Property(e => e.LogDateYyyyMmDd)
                .HasColumnName("LOG_DATE_YYYYMMDD")
                .ValueGeneratedNever();

                entity.Property(e => e.SearchCount).HasColumnName("SEARCH_COUNT");

                entity.Property(e => e.LineCount).HasColumnName("LINE_COUNT");

                entity.Property(e => e.PhotoCount).HasColumnName("PHOTO_COUNT");

                entity.Property(e => e.ExCount).HasColumnName("EX_COUNT");

            });
        }
    }
}
