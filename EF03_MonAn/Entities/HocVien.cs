using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF03_MonAn.Entities
{
	public class HocVien
	{
		public int HocVienId { get; set; }
		public int KhoaHocId { get; set; }
		public KhoaHoc KhoaHoc { get; set; }

		public string HoTen { get; set; }
		public DateOnly NgaySinh { get; set; }
		public string QueQuan { get; set; }
		public string DiaChi { get; set; }
		public string SoDienThoai { get; set; }
	}
}
