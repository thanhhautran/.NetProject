
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
        public DbSet<giohang> Giohang { get; set; }
        public DbSet<danhgia> Danhgia { get; set; }
        public DbSet<usertable> usertable { get; set; }
        public DbSet<donhang> DonHang { get; set; }
        public DbSet<chitietdonhang> Chitietdonhang { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
              optionsBuilder.UseMySQL("server=localhost;database=project_dotnet;user=root;password=1234")
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
               entity.HasOne(p => p.thongso).WithOne(d => d.sanpham).HasForeignKey<thongso>(c => c.id);
           });
            modelBuilder.Entity<danhmuc>(entity =>
            {
                entity.HasKey(e => e.id);
            });
            modelBuilder.Entity<khachhang>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.HasOne(p => p.giohang).WithOne(d => d.khachhang).HasForeignKey<giohang>(c => c.id);
            });
            modelBuilder.Entity<donhang>(entity =>
           {
               entity.HasKey(e => e.id);
               entity.HasOne(p => p.khachhang).WithMany(d => d.donhangs);
           });
            modelBuilder.Entity<roletable>(entity =>
            {
                entity.HasKey(e => e.id);
            });
            modelBuilder.Entity<usertable>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.HasOne(p => p.roletable).WithOne(d => d.Usertable).HasForeignKey<roletable>(c => c.id);
            });
            modelBuilder.Entity<resourcetable>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.HasOne(p => p.roletable).WithMany(d => d.Resourcetables);
            });
            modelBuilder.Entity<danhgia>(entity =>
            {
                entity.HasKey(d => d.id);              
                entity.HasOne(d => d.sanpham).WithMany(s => s.Danhgias);
                entity.HasOne(d => d.khachhang).WithMany(k => k.Danhgias);
            });
            
        }
    }
}