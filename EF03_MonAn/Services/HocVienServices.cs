using EF03_MonAn.Entities;
using EF03_MonAn.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF03_MonAn.Services
{
	public class HocVienServices : IHocVienServices
	{
		private readonly AppDbContext db;

		public HocVienServices()
		{
			db = new AppDbContext();
		}

		public void DoanhThu()
		{
			double doanhThu = 0;
			var KhoaHoc_HocVien = db.HocVien.Include(x => x.KhoaHoc).ToList();
            foreach (var item in KhoaHoc_HocVien)
            {
				doanhThu += item.KhoaHoc.HocPhi;
            }
            Console.WriteLine($"Doanh thu: {doanhThu}");
        }

		public bool SuaHocVien()
		{
            Console.WriteLine("Nhap Id hoc vien can sua: ");
			int id = int.Parse(Console.ReadLine());
			HocVien hocVienUpdate = db.HocVien.FirstOrDefault(x => x.HocVienId == id);
			if(hocVienUpdate == null)
			{
                Console.WriteLine("Khong tim thay hoc vien");
				return false;
            }
            Console.WriteLine("Sua ho ten: ");
			hocVienUpdate.HoTen = Console.ReadLine();
            Console.WriteLine("Sua ngay sinh: ");
			hocVienUpdate.NgaySinh = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Sua que quan: ");
			hocVienUpdate.QueQuan = Console.ReadLine();
            Console.WriteLine("Sua dia chi: ");
			hocVienUpdate.DiaChi = Console.ReadLine();
            Console.WriteLine("Sua so dien thoai: ");
			hocVienUpdate.SoDienThoai = Console.ReadLine();
			db.Update(hocVienUpdate);
			db.SaveChanges();
            Console.WriteLine("Update thanh cong");
            return true;
		}

		public bool TimKiemHocVien()
		{
			List<HocVien> lst = new List<HocVien>();
            Console.WriteLine("Nhap ho ten: ");
			string hoTen = Console.ReadLine();
			hoTen = hoTen.ToLower().ToUpper();
            Console.WriteLine("Nhap id khoa hoc: ");
			int id = int.Parse(Console.ReadLine());
			lst = db.HocVien.Where(x => x.HoTen.ToLower().ToUpper().Contains(hoTen) && x.KhoaHocId == id).ToList();
			if(lst.Count == 0)
			{
                Console.WriteLine("Khong tim thay hoc vien");
				return false;
            }
            Console.WriteLine("Cac hoc vien hop le: ");
            foreach (var item in lst)
            {
                Console.WriteLine(item.HoTen);
            }

            return true;
		}

		public bool XoaHocVien()
		{
            Console.WriteLine("Nhap Id hoc vien muon xoa: ");
			int id = int.Parse(Console.ReadLine());
			HocVien hocVienDelete = db.HocVien.FirstOrDefault(x => x.HocVienId == id);
			if (hocVienDelete == null)
			{
				Console.WriteLine("Khong tim thay hoc vien");
				return false;
			}
			db.Remove(hocVienDelete);
			db.SaveChanges();
            Console.WriteLine("Xoa thanh cong");
            return true;
		}
	}
}
