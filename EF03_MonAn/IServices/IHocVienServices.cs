using EF03_MonAn.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF03_MonAn.IServices
{
	public interface IHocVienServices
	{
		public bool SuaHocVien();
		public bool XoaHocVien();
		public bool TimKiemHocVien();
		public void DoanhThu();

	}
}
