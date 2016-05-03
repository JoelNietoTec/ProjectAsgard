namespace ProjectWebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SalesModel : DbContext
    {
        public SalesModel()
            : base("name=SalesModel")
        {
        }

        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientType> ClientTypes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BillDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Bill>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Bill>()
                .HasMany(e => e.BillDetails)
                .WithRequired(e => e.Bill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClientType>()
                .HasMany(e => e.Clients)
                .WithRequired(e => e.ClientType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.BillDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendor>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.Vendor)
                .WillCascadeOnDelete(false);
        }
    }
}
