using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythanhvientronglab.Models
{
    public class DBManageContext:DbContext
    {
        public DBManageContext() : base("name=DBManageMembers") { }
        public DbSet<ClassChucVu> tbChucVu { set; get; }
        public DbSet<ClassHoSoNV> tbHoSoNV { set; get; }
        public DbSet<ClassDuAn> tbDuAn { set; get; }
        public DbSet<ClassPhanCong> tbPhanCong { set; get; }
        public DbSet<ClassBangCong> tbBangCong { set; get; }
        public DbSet<ClassBangLuong> tbBangLuong { set; get; }
        public DbSet<ClassThanNhan> tbThanNhan { set; get; }
    }
}
