using EF03_MonAn.Entities;
using EF03_MonAn.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF03_MonAn.Services
{
	public class NgayHocServices : INgayHocServices
	{
		private readonly AppDbContext db;
		public NgayHocServices()
		{
			db = new AppDbContext();
		}

		public bool ThemNgayHoc()
		{
			NgayHoc ngayHocMoi = new NgayHoc();
            Console.WriteLine("Nhap khoa hoc ID: ");
			ngayHocMoi.KhoaHocId = int.Parse(Console.ReadLine());
			KhoaHoc khoaHocCanTim = db.KhoaHoc.FirstOrDefault(x => x.KhoaHocId == ngayHocMoi.KhoaHocId);
			if(khoaHocCanTim == null)
			{
                Console.WriteLine("Khong tim thay khoa hoc!!");
				return false;
            }
			if (db.KhoaHoc.Count()>15)
			{
                Console.WriteLine("Khoa hoc da dat toi da so ngay hoc!!");
				return false;
            }
            Console.WriteLine("Nhap noi dung: ");
			ngayHocMoi.NoiDung = Console.ReadLine();
            Console.WriteLine("Nhap ghi chu: ");
			ngayHocMoi.GhiChu = Console.ReadLine();
			db.Add(ngayHocMoi);
			db.SaveChanges();
            Console.WriteLine("Them thanh cong");
            return true;
		}
	}
}
