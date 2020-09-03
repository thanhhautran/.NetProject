using Microsoft.EntityFrameworkCore.Storage.Internal;
using Project.Models.DAO;
using ProjectCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Areas.Admin.Data
{
    public class ChartDao
    {
        ProjectContext context;

        public ChartDao()
        {
            this.context = new ProjectContext();
        }

        public int[] earningByQuarter()
        {
            int[] result = new int[4];
            int tmp = 0;

            for (int i = 0; i < 4; i++)
            {
                int tmp2 = tmp + 3;
                result[i] = (int)context.DonHang.Where(d => d.ngaygiaodich.Value.Month >= tmp && d.ngaygiaodich.Value.Month <= tmp2 && d.ngaygiaodich.Value.Year == DateTime.Now.Year).Sum(s => s.giatridon);
                tmp += 3;
            }
            return result;
        }

        public string[] getProductStatisticsLabel()
        {
            var type = context.Danhmuc.ToList();
            List<string> list = new List<string>();

            foreach (var i in type)
            {
                if (!list.Contains(i.loaiSanPham))
                    list.Add(i.loaiSanPham);

            }
            return list.ToArray();
        }

        public int[] getProductStatisticsType(string[] label)
        {
            int[] result = new int[label.Length];
            var products = context.Sanpham.ToList();

            for (int p = 0; p < label.Length; p++)
                foreach (var i in products)
                { 
                    if (i.danhmuc.loaiSanPham.Equals(label[p]))
                    {
                        result[p]++;
                    }
                }

            return result;
        }

        public int[] getProductSoldByMonth(string label)
        {
            int[] result = new int[12];

            for (int i = 0; i < 12; i++)
            {
                var receiptDetail = context.Chitietdonhang.Where(s => s.sanpham.danhmuc.loaiSanPham == label 
                                                                    && s.donhang.ngaygiaodich.Value.Month == i).ToList();
                   
                    foreach (var j in receiptDetail)
                    {
                    result[i] += j.tonggia;                  
                    }
                   
            }
            return result;
        }

        public int[] getProductSoldForHome(string label)
        {
            int[] result = new int[12];
            if (label.Equals("Phone"))
            {
                

                for (int i = 0; i < 12; i++)
                {
                    var receiptDetail = context.Chitietdonhang.Where(s => s.sanpham.danhmuc.loaiSanPham == label
                                                                        && s.donhang.ngaygiaodich.Value.Month == i).ToList();

                    foreach (var j in receiptDetail)
                    {
                        result[i] += j.tonggia;
                    }

                }
            }
            if (!label.Equals("Phone"))
            {


                for (int i = 0; i < 12; i++)
                {
                    var receiptDetail = context.Chitietdonhang.Where(s => s.sanpham.danhmuc.loaiSanPham != label
                                                                        && s.donhang.ngaygiaodich.Value.Month == i).ToList();

                    foreach (var j in receiptDetail)
                    {
                        result[i] += j.tonggia;
                    }

                }
            }
            return result;
        }

        public int[] getStatusOfOrder(string[] labels)
        {
            int[] result = new int[labels.Length];
            var order = context.DonHang.ToList();
            for(int i = 0; i < labels.Length; i++)
            {
                foreach(var o in order)
                {
                    if (o.trangthai.Equals(labels[i]))
                    {
                        result[i]++;
                    }
                }
            }
            return result;
        }
    }
}
