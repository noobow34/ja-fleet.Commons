using Microsoft.EntityFrameworkCore;

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
        public virtual DbSet<TypeDetailView> TypeDetailView { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<LineUserProfileImage> LineUserProfileImage { get; set; }
        public virtual DbSet<AircraftHistory> AircraftHistory { get; set; }
        public virtual DbSet<AircraftHistoryView> AircraftHistoryView { get; set; }

        public jafleetContext(DbContextOptions<jafleetContext> options) : base(options) { }

    }
}