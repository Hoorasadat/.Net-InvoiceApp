﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lab_3.Models;

public partial class CustomersBillsContext : DbContext
{
    public CustomersBillsContext()
    {
    }

    public CustomersBillsContext(DbContextOptions<CustomersBillsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=HooraVM\\SQLEXPRESS; Initial Catalog=CustomersBills;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.AccountNumber).ValueGeneratedNever();
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasOne(d => d.AccountNumberNavigation).WithMany(p => p.Invoices).HasConstraintName("FK_Invoices_Customers");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
