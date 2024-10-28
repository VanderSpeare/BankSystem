using System;
using System.Collections.Generic;
using BankSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace BankSystem.Models;

public partial class BankSystemContext : DbContext
{
    public BankSystemContext()
    {
    }

    public BankSystemContext(DbContextOptions<BankSystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountModel> Accounts { get; set; }

    public virtual DbSet<BankTransaction> BankTransactions { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WILLIAMVANDERSP\\SQLEXPRESS;Database=BankSystem;TrustServerCertificate=True;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Account__3214EC07984FD00B");

            entity.ToTable("Account");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CustomerId)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Customer).WithMany(p => p.Accounts )
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Account__Custome__3D5E1FD2");
        });

        modelBuilder.Entity<BankTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bank_Tra__3214EC073F2726FF");

            entity.ToTable("Bank_Transaction");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BranchId)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Pin)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Branch).WithMany(p => p.BankTransactions)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK__Bank_Tran__Branc__4316F928");

            entity.HasOne(d => d.Employee).WithMany(p => p.BankTransactions)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__Bank_Tran__Emplo__4222D4EF");

            entity.HasOne(d => d.FromAccount).WithMany(p => p.BankTransactionFromAccounts)
                .HasForeignKey(d => d.FromAccountId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Bank_Tran__FromA__403A8C7D");

            entity.HasOne(d => d.ToAccount).WithMany(p => p.BankTransactionToAccounts)
                .HasForeignKey(d => d.ToAccountId)
                .HasConstraintName("FK__Bank_Tran__ToAcc__412EB0B6");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Branch__3214EC0715C4C4E2");

            entity.ToTable("Branch");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HouseNo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC07414309EF");

            entity.ToTable("Customer");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HouseNo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Pin)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC0709B79D0B");

            entity.ToTable("Employee");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Role)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
