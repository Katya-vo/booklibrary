using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Models
{
    public partial class BookLibraryContext : DbContext
    {
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public BookLibraryContext()
        {
        }
        public BookLibraryContext(DbContextOptions<BookLibraryContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookLibrary;Integrated Security=True;");

            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FirstName).IsRequired();
                entity.Property(e => e.Surname).IsRequired();
                entity.Property(e => e.DateOfBirth);
            });
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Title).IsRequired();
                entity.Property(e => e.Pages).IsRequired();
                entity.Property(e => e.Price).IsRequired();
                entity.Property(e => e.YearOfPublishing).IsRequired();
                entity.HasOne(d => d.Author)
                      .WithMany(p => p.Books)
                      .HasForeignKey(d => d.AuthorId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Clients");

                entity.HasKey(e => e.id);

                entity.Property(e => e.id).HasColumnName("Id");
                entity.Property(e => e.name).HasColumnName("Name").IsRequired();
                entity.Property(e => e.username).HasColumnName("Username").IsRequired();
                entity.Property(e => e.password).HasColumnName("Password").IsRequired();
                entity.Property(e => e.bookId).HasColumnName("BookId");
                entity.Property(e => e.borrowUntil).HasColumnName("BorrowUntil");

                entity.HasIndex(e => e.username).IsUnique();
            });
        }
    }
}
