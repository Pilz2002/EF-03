using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF03_MonAn.Entities
{
	public class KhoaHoc
	{
		public int KhoaHocId { get; set; }
		public string TenKhoaHoc { get; set; }
		public string MoTa { get; set; }
		public double HocPhi { get; set; }
		public DateOnly NgayBatDau { get; set; }
		public DateOnly NgayKetThuc { get; set; }

		public IEnumerable<NgayHoc> NgayHocs { get; set; }
		public IEnumerable<HocVien> HocViens { get; set; }

	}
}
