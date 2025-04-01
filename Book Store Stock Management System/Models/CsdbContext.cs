using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Book_Store_Stock_Management_System.Models;

public partial class CsdbContext : DbContext
{
    public CsdbContext()
    {
    }

    public CsdbContext(DbContextOptions<CsdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=bookstore-cs.database.windows.net;Database=csdb;User ID=cs-admin;Password=SQL-server;Encrypt=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.AuthorId).HasName("PK__Authors__70DAFC34FBD58B4D");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Isbn).HasName("PK__Books__447D36EB4BC1C9B4");

            entity.Property(e => e.Isbn).ValueGeneratedNever();

            entity.HasOne(d => d.Author).WithMany(p => p.Books)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Books__AuthorId__0F624AF8");

            entity.HasOne(d => d.Category).WithMany(p => p.Books)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Books__CategoryI__10566F31");

            entity.HasOne(d => d.Publisher).WithMany(p => p.Books)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Books__Publisher__114A936A");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Categori__19093A0B70947B04");
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.PublisherId).HasName("PK__Publishe__4C657FABC05C0C50");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK__Supplier__4BE666B4BB11FE4B");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Transact__3214EC07FF9660E5");

            entity.HasOne(d => d.IsbnNavigation).WithMany(p => p.Transactions).HasConstraintName("FK__Transactio__ISBN__151B244E");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Transactions).HasConstraintName("FK__Transacti__Suppl__17036CC0");

            entity.HasOne(d => d.User).WithMany(p => p.Transactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Transacti__UserI__160F4887");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4C0BEC9104");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
