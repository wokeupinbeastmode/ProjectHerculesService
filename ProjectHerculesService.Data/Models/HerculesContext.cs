using Microsoft.EntityFrameworkCore;

namespace ProjectHerculesService.Data.Models
{
    public partial class HerculesContext : DbContext
    {
        public HerculesContext(string connectionString)
        {
        }

        public HerculesContext(DbContextOptions<HerculesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Months> Months { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<SalesTypes> SalesTypes { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<Years> Years { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS01;Database=Hercules;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Months>(entity =>
            {
                entity.HasKey(e => e.MonthId);

                entity.Property(e => e.MonthId).ValueGeneratedOnAdd();

                entity.Property(e => e.Month)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sales>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TotalMonthly).IsUnicode(false);

                entity.Property(e => e.TotalYearly).IsUnicode(false);

                entity.Property(e => e.PercentChangeSalesMonth).IsUnicode(false);

                entity.Property(e => e.PercentChangeSalesYear).IsUnicode(false);

                entity.HasOne(d => d.SalesTypes)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.SalesTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sales_SalesTypes");

                entity.Property(e => e.PercentChangeByType).IsUnicode(false);

                entity.Property(e => e.CustomerCount).IsUnicode(false);

                entity.Property(e => e.PercentChangeCustomer).IsUnicode(false);

                entity.Property(e => e.Month).IsUnicode(false);
            });

            modelBuilder.Entity<SalesTypes>(entity =>
            {
                entity.HasKey(e => e.SaleTypeId);

                entity.Property(e => e.SaleTypeId).ValueGeneratedOnAdd();

                entity.Property(e => e.SalesByType).IsUnicode(false);

                entity.Property(e => e.TypeName).IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId);
                entity.Property(e => e.UserId).ValueGeneratedOnAdd();

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_UserType");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.HasKey(e => e.UserTypeId);
                entity.Property(e => e.UserTypeId).ValueGeneratedOnAdd();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Years>(entity =>
            {
                entity.HasKey(e => e.YearId);

                entity.Property(e => e.YearId).ValueGeneratedOnAdd();

                entity.Property(e => e.Year).HasMaxLength(50);

                entity.HasOne(d => d.Month)
                    .WithMany(p => p.Years)
                    .HasForeignKey(d => d.MonthId)
                    .HasConstraintName("FK_Years_Months");
            });
        }
    }
}
