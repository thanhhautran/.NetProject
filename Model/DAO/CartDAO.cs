using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Project.Models.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ProjectCore.Models.DAO
{
    public  class CartDAO
    {
        ProjectContext pt = null;
        public CartDAO()
        {
            pt = new ProjectContext();
        }
        public void writeDetailReceipt(chitietdonhang ctdh)
        {
            pt.Chitietdonhang.Add(ctdh);
            pt.SaveChanges();
        }
        public int writeRecipt(donhang dh)
        {
            pt.DonHang.Add(dh);
            pt.SaveChanges();
            return dh.id;
        }
        public int insertReceipt(donhang dh)
        {
            object[] parameters =
            {
            new SqlParameter("@idkhachhang", dh.khachhang.id),
            new SqlParameter("@ngaygd", dh.ngaygiaodich),
            new SqlParameter("@ngaygh", dh.ngaygiaohang),
            new SqlParameter("@diachigh", dh.diachigiaohang),
            new SqlParameter("@sdt", dh.sdtlienlac),
            new SqlParameter("@email", dh.emailLienLac),
            new SqlParameter("@giatridon", dh.giatridon)
        };
            var id = pt.Database.ExecuteSqlRaw("call insert_receipt(@idkhachhang,@ngaygd,@ngaygh,@diachigh,@sdt,@email,@giatridon)", parameters);
            return id;
        }
        public void insertDetailReceipt(chitietdonhang ctdh)
        {
            object[] parameters =
            {
            new SqlParameter("@iddonhang", ctdh.donhang.id),
            new SqlParameter("@idsp", ctdh.sanpham.id),
            new SqlParameter("@tensp", ctdh.sanpham.tensanpham),
            new SqlParameter("@soluong", ctdh.soluong),
            new SqlParameter("@gia", ctdh.gia),
            new SqlParameter("@tonggia", ctdh.tonggia)
            };
            pt.Database.ExecuteSqlRaw("call insert_detailReceipt(@iddonhang, @idsp, @tensp,@soluong,@gia,@tonggia)", parameters);
        }
    }
}
