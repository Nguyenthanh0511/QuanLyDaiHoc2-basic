using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QuanLyDaiHoc.Models;

public partial class QuanLyDaiHoc2Context : DbContext
{
    public QuanLyDaiHoc2Context()
    {
    }

    public QuanLyDaiHoc2Context(DbContextOptions<QuanLyDaiHoc2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<GiamHieu> GiamHieus { get; set; }

    public virtual DbSet<Khoa> Khoas { get; set; }

    public virtual DbSet<Nguoidung> Nguoidungs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=103.159.50.22,64501;Database=QuanLyDaiHoc2;User Id=VuonUom;Password=123456;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GiamHieu>(entity =>
        {
            entity.ToTable("GiamHieu");

            entity.Property(e => e.Img)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.NhiemKy).HasColumnType("date");
        });

        modelBuilder.Entity<Khoa>(entity =>
        {
            entity.HasKey(e => e.KhoaId).HasName("PK_dbo.Khoa");

            entity.ToTable("Khoa");

            entity.Property(e => e.KhoaId).HasColumnName("khoaId");
            entity.Property(e => e.Mota).HasMaxLength(50);
            entity.Property(e => e.Sodienthoai)
                .HasMaxLength(15)
                .IsFixedLength();
            entity.Property(e => e.TenKhoa).HasMaxLength(50);
            entity.Property(e => e.TruongKhoa).HasMaxLength(50);
        });

        modelBuilder.Entity<Nguoidung>(entity =>
        {
            entity.HasKey(e => e.IdNguoiDung);

            entity.ToTable("Nguoidung");

            entity.Property(e => e.IdNguoiDung).ValueGeneratedNever();
            entity.Property(e => e.FieldA)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Md5Password).HasMaxLength(250);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Salt).HasMaxLength(50);
            entity.Property(e => e.TenNguoiDung).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
