using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF03_MonAn.Entities
{
	public class NgayHoc
	{
		public int NgayHocId { get; set; }
		public int KhoaHocId { get; set; }
		public KhoaHoc KhoaHoc { get; set; }
		public string NoiDung { get; set; }
		public string GhiChu { get; set; }
	}
}
