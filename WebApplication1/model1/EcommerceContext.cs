using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication1.model1
{
    public partial class EcommerceContext : DbContext
    {
        public EcommerceContext()
        {
        }

        public EcommerceContext(DbContextOptions<EcommerceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tbl1> Tbl1s { get; set; }
        public virtual DbSet<Tbl2> Tbl2s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-1HF3V25;Initial Catalog=Ecommerce;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Tbl1>(entity =>
            {
                entity.HasKey(e => e.Categoryid);

                entity.ToTable("Tbl_1");

                entity.Property(e => e.Categoryid)
                    .ValueGeneratedNever()
                    .HasColumnName("categoryid");

                entity.Property(e => e.Cateogaryname)
                    .HasMaxLength(200)
                    .HasColumnName("cateogaryname")
                    .IsFixedLength(true);

                entity.Property(e => e.IsActive10).HasColumnName("IsActive(1,0)");
            });

            modelBuilder.Entity<Tbl2>(entity =>
            {
                entity.HasKey(e => e.Productid);

                entity.ToTable("tbl_2");

                entity.Property(e => e.Productid)
                    .ValueGeneratedNever()
                    .HasColumnName("productid");

                entity.Property(e => e.Prodctname)
                    .HasMaxLength(200)
                    .HasColumnName("prodctname")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
