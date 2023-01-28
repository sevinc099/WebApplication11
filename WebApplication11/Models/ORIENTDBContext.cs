using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication11.Models
{
    public partial class ORIENTDBContext : DbContext
    {
        public ORIENTDBContext()
        {
        }

        public ORIENTDBContext(DbContextOptions<ORIENTDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kitablar> Kitablars { get; set; }
        public virtual DbSet<Kitablar2> Kitablar2s { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Table3> Table3s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-G6VBVFM\\SQLEXPRESS01;Database=ORIENTDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Kitablar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Kitablar");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.KitabAd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KITAB_AD");

                entity.Property(e => e.KitabCapevi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KITAB_CAPEVI");

                entity.Property(e => e.KitabQiymet)
                    .HasColumnType("money")
                    .HasColumnName("KITAB_QIYMET");

                entity.Property(e => e.KitabSehife).HasColumnName("KITAB_SEHIFE");

                entity.Property(e => e.KitabTarix)
                    .HasColumnType("date")
                    .HasColumnName("KITAB_TARIX");

                entity.Property(e => e.KitabYazar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KITAB_YAZAR");
            });

            modelBuilder.Entity<Kitablar2>(entity =>
            {
                entity.ToTable("KITABLAR2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KitabAd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KITAB_AD");

                entity.Property(e => e.KitabCapev)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KITAB_CAPEV");

                entity.Property(e => e.KitabQiymet)
                    .HasColumnType("money")
                    .HasColumnName("KITAB_QIYMET");

                entity.Property(e => e.KitabSehife).HasColumnName("KITAB_SEHIFE");

                entity.Property(e => e.KitabTarixi)
                    .HasColumnType("date")
                    .HasColumnName("KITAB_TARIXI");

                entity.Property(e => e.KitabYazar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KITAB_YAZAR");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY");

                entity.Property(e => e.MadedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MADED_BY");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Price)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("PRICE");

                entity.Property(e => e.ProductDate)
                    .HasColumnType("date")
                    .HasColumnName("PRODUCT_DATE");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.ToTable("REGISTRATION");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GENDER")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("STUDENT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Approved).HasColumnName("APPROVED");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MOBILE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SURNAME");
            });

            modelBuilder.Entity<Table3>(entity =>
            {
                entity.ToTable("Table_3");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KitabAd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KITAB_AD");

                entity.Property(e => e.KitabCapevi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KITAB_CAPEVI");

                entity.Property(e => e.KitabQiymet)
                    .HasColumnType("money")
                    .HasColumnName("KITAB_QIYMET");

                entity.Property(e => e.KitabSehife).HasColumnName("KITAB_SEHIFE");

                entity.Property(e => e.KitabTarix)
                    .HasColumnType("date")
                    .HasColumnName("KITAB_TARIX");

                entity.Property(e => e.KitabYazar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KITAB_YAZAR");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
