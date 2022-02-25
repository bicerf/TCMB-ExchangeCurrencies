using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ExchangeCurrencies.Models
{
    public partial class ExchangeContext : DbContext
    {
    
        public ExchangeContext(DbContextOptions<ExchangeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dovizkurlari> Dovizkurlaris { get; set; }
        public virtual DbSet<Dovizkurlari2> Dovizkurlari2s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Dovizkurlari>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DOVIZKURLARI");

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_");

                entity.Property(e => e.Isim)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dovizkurlari2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DOVIZKURLARI2");

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_");

                entity.Property(e => e.Isim)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
