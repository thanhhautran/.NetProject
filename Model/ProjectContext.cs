
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Model.POJOs;
using Project.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore.Models
{
    public class ProjectContext : DbContext
    {
        public DbSet<sanpham> Sanpham { get; set; }
        public DbSet<thongso> Thongso { get; set; }
        public DbSet<danhmuc> Danhmuc { get; set; }
        public DbSet<khachhang> Khachhang { get; set; }
        public DbSet<danhgia> Danhgia { get; set; }
        public DbSet<roleTable> RoleTable { get; set; }
        public DbSet<donhang> DonHang { get; set; }
        public DbSet<chitietdonhang> Chitietdonhang { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=project_dotnet;user=root;password=StrongPass123")
           .UseLoggerFactory(LoggerFactory.Create(b => b
                    .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<sanpham>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.HasOne(p => p.danhmuc).WithMany(d => d.sanphams).HasForeignKey(c => c.danhmucid);
                entity.HasOne(p => p.thongso).WithOne(d => d.sanpham).HasForeignKey<thongso>(c => c.id);
            });
            modelBuilder.Entity<danhmuc>(entity =>
            {
                entity.HasKey(e => e.id);

            });
            modelBuilder.Entity<khachhang>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.HasMany(d => d.donhangs).WithOne(p => p.khachhang);
                entity.HasOne(d => d.roleTable).WithOne(r => r.khachhang).HasForeignKey<roleTable>(c => c.id);
                // entity.HasOne(p => p.roleTable).WithOne(d => d.khachhang).HasForeignKey<roleTable>(c => c.id);

            });
            modelBuilder.Entity<donhang>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.HasOne(p => p.khachhang).WithMany(d => d.donhangs).HasForeignKey(c => c.khachhangid);
            });
            modelBuilder.Entity<roleTable>(entity =>
            {
                entity.HasKey(e => e.id);
                // entity.HasOne(p => p.role_name).WithMany(d => d.khachhang).HasForeignKey<khachhang>(c => c.id);

                // entity.HasOne(p => p.giohang).WithOne(d => d.khachhang).HasForeignKey<giohang>(c => c.id);
                // entity.HasOne(p => p.roleTable).WithOne(d => d.khachhang).HasForeignKey<roleTable>(c => c.id);

            });
            modelBuilder.Entity<donhang>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.HasOne(p => p.khachhang).WithMany(d => d.donhangs);
            });
            modelBuilder.Entity<roleTable>(entity =>
            {
                entity.HasKey(e => e.id);
                // entity.HasOne(p => p.role_name).WithMany(d => d.khachhang).HasForeignKey<khachhang>(c => c.id);

            });
            modelBuilder.Entity<danhgia>(entity =>
            {
                entity.HasKey(d => d.id);
                entity.HasOne(d => d.sanpham).WithMany(s => s.Danhgias);
                entity.HasOne(d => d.khachhang).WithMany(k => k.Danhgias);
            });
            modelBuilder.Entity<chitietdonhang>(entity =>
            {
                entity.HasKey(d => d.id);
                entity.HasOne(d => d.sanpham).WithMany(s => s.Chitietdonhangs);
            });

        }
    }
}