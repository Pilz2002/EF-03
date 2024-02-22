using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF03_MonAn.Entities
{
	public class AppDbContext : DbContext
	{
		public virtual DbSet<HocVien> HocVien { get; set; }
		public virtual DbSet<KhoaHoc> KhoaHoc { get; set; }
		public virtual DbSet<NgayHoc> NgayHoc { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server = QUYEN; Database = QLKhoaHoc; Trusted_Connection = True;" +
				"TrustServerCertificate=True");
		}
	}
}
