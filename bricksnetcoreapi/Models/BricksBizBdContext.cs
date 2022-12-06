using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace bricksnetcoreapi.Models;

public partial class BricksBizBdContext : DbContext
{
    public BricksBizBdContext()
    {
    }

    public BricksBizBdContext(DbContextOptions<BricksBizBdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblCustomer> Customers { get; set; }

    public virtual DbSet<TblCustomerArchive> CustomerArchives { get; set; }

    public virtual DbSet<TblException> Exceptions { get; set; }

    public virtual DbSet<TblOrder> Orders { get; set; }

    public virtual DbSet<TblUser> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=BricksBizBD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblCustomer>(entity =>
        {
            entity.HasKey(e => e.CustomerId);

            entity.ToTable("tbl_customer", tb =>
                {
                    tb.HasTrigger("Customer_OnUpdate_ArchiveCustomer");
                    tb.HasTrigger("ID_Customer_MarkAsInactive");
                });

            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(50)
                .HasColumnName("customer_address");
            entity.Property(e => e.CustomerContact)
                .HasMaxLength(50)
                .HasColumnName("customer_contact");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .HasColumnName("customer_name");
            entity.Property(e => e.CustomerPwd)
                .HasMaxLength(50)
                .HasColumnName("customer_pwd");
            entity.Property(e => e.CustomerStatus)
                .HasMaxLength(50)
                .HasColumnName("customer_status");
            entity.Property(e => e.CustomerUserid)
                .HasMaxLength(50)
                .HasColumnName("customer_userid");
        });

        modelBuilder.Entity<TblCustomerArchive>(entity =>
        {
            entity.HasKey(e => e.ArchId).HasName("PK_tbl_CustomerArchive");

            entity.ToTable("tbl_customer_archive");

            entity.Property(e => e.ArchId).HasColumnName("arch_id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerNewName)
                .HasMaxLength(50)
                .HasColumnName("customer_new_name");
            entity.Property(e => e.CustomerOldName)
                .HasMaxLength(50)
                .HasColumnName("customer_old_name");
        });

        modelBuilder.Entity<TblException>(entity =>
        {
            entity.HasKey(e => e.ExceptionId);

            entity.ToTable("tbl_exception");

            entity.Property(e => e.ExceptionId).HasColumnName("exception_id");
            entity.Property(e => e.ExceptionDetails)
                .HasMaxLength(500)
                .HasColumnName("exception_details");
            entity.Property(e => e.ExceptionType)
                .HasMaxLength(50)
                .HasColumnName("exception_type");
            entity.Property(e => e.MethodName)
                .HasMaxLength(50)
                .HasColumnName("method_name");
        });

        modelBuilder.Entity<TblOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.ToTable("tbl_order");

            entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("order_id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.OrderCode).HasColumnName("order_code");
            entity.Property(e => e.Qty).HasColumnName("qty");
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Total).HasColumnName("total");
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.Userid);

            entity.ToTable("tbl_user");

            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
