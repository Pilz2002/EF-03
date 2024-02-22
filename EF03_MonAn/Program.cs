using EF03_MonAn.IServices;
using EF03_MonAn.Services;

void Main()
{
	INgayHocServices ngayHocServices = new NgayHocServices();
	ngayHocServices.ThemNgayHoc();
	IHocVienServices hocVienServices = new HocVienServices();
	hocVienServices.SuaHocVien();
	hocVienServices.XoaHocVien();
	hocVienServices.TimKiemHocVien();
	hocVienServices.DoanhThu();
}

Main();