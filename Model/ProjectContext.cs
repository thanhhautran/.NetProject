using Microsoft.EntityFrameworkCore;
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
        public DbSet<khuyenmai> KhuyenMai { get; set; }
        public DbSet<danhmuc> Danhmuc { get; set; }
        public DbSet<khachhang> Khachhang { get; set; }
        public DbSet<giohang> Giohang { get; set; }
        public DbSet<usertable> usertable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=project_dotnet;user=root;password=StrongPass123");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<sanpham>(entity =>
           {
               entity.HasKey(e => e.idsanpham);
               entity.HasOne(p => p.khuyenmai).WithOne(d => d.sanpham).HasForeignKey<khuyenmai>(c => c.idKhuyenMai);
               entity.HasOne(p => p.thongso).WithOne(d => d.sanpham).HasForeignKey<thongso>(c => c.idthongso);
           });

            modelBuilder.Entity<khuyenmai>(entity =>
            {
                entity.HasKey(e => e.idKhuyenMai);
            });
            modelBuilder.Entity<danhmuc>(entity =>
            {
                entity.HasKey(e => e.iddanhmuc);
            });
            modelBuilder.Entity<khachhang>(entity =>
            {
                entity.HasKey(e => e.idkhachhang);
                entity.HasOne(p => p.giohang).WithOne(d => d.khachhang).HasForeignKey<giohang>(c => c.idGioHang);
            });
            modelBuilder.Entity<donhang>(entity =>
           {
               entity.HasKey(e => e.iddonhang);
               entity.HasOne(p => p.khachhang).WithMany(d => d.donhangs);
           });
            modelBuilder.Entity<roletable>(entity =>
            {
                entity.HasKey(e => e.idrole);
            });
            modelBuilder.Entity<usertable>(entity =>
            {
                entity.HasKey(e => e.idusertable);
                entity.HasOne(p => p.roletable).WithOne(d => d.Usertable).HasForeignKey<roletable>(c => c.idrole);
            });
            modelBuilder.Entity<resourcetable>(entity =>
            {
                entity.HasKey(e => e.idresourceTable);
                entity.HasOne(p => p.roletable).WithMany(d => d.Resourcetables);
            });
            
        }
    }
}