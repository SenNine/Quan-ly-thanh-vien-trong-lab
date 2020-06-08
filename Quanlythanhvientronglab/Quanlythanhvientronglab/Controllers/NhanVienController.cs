using Quanlythanhvientronglab.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythanhvientronglab.Controllers
{
    public class NhanVienController
    {
        public static ClassNhanVien GetNV(string MaNhanVien)
        {
            using (var _context = new DBManageContext())
            {
                var nv = (from n in _context.tbNhanVien
                          where MaNhanVien == n.MaChucVu
                          select n).ToList();
                if (nv.Count == 1)
                    return nv[0];
                else
                    return null;
            }
        }
        public static bool AddNV(ClassNhanVien nv)
        {
            try
            {
                using (var _context = new DBManageContext())
                {
                    _context.tbNhanVien.Add(nv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static List<ClassNhanVien> GetListNV()
        {
            using (var _context = new DBManageContext())
            {
                var nv = (from nvien in _context.tbNhanVien.AsEnumerable()
                          select new
                          {
                              MaNV = nvien.MaNV,
                              TenNV = nvien.TenNV,
                              GioiTinh =nvien.GioiTinh,
                              DiaChi=nvien.DiaChi,
                              NgaySinh=nvien.NgaySinh,
                              SDT=nvien.SDT,
                              Email=nvien.Email,
                              MaChucVu=nvien.MaChucVu
                          }).Select(x => new ClassNhanVien
                          {
                              MaNV = x.MaNV,
                              TenNV = x.TenNV,
                              GioiTinh = x.GioiTinh,
                              DiaChi = x.DiaChi,
                              NgaySinh = x.NgaySinh,
                              SDT = x.SDT,
                              Email = x.Email,
                              MaChucVu = x.MaChucVu

                          }).ToList();
                return nv;
            }
        }
        public static bool DeleteNV(string Manv)
        {
            try
            {
                using(var _context=new DBManageContext())
                {
                    var dbnv = (from nv in _context.tbNhanVien
                                where nv.MaNV == Manv
                                select nv).Single();
                    _context.tbNhanVien.Remove(dbnv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool UpdateNV(ClassNhanVien nvien)
        {
            try
            {
                using (var _context=new DBManageContext())
                {
                    _context.tbNhanVien.AddOrUpdate(nvien);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
