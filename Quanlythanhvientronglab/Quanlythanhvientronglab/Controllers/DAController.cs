using Quanlythanhvientronglab.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythanhvientronglab.Controllers
{
    public class DAController
    {
        public static bool AddDuAn(ClassDuAn da)
        {
            try
            {
                using (var _context = new DBManageContext())
                {
                    //add duan voi listcongviec rong
                    ClassDuAn duan = new ClassDuAn { MaDA = da.MaDA, TenDA = da.TenDA, ChiTiet = da.ChiTiet, fromDate = da.fromDate, toDate = da.toDate };
                    _context.tbDuAn.Add(duan);
                    _context.SaveChanges();
                }
                using (var _context = new DBManageContext())
                {
                    //lay du an
                    var dbda = (from proj in _context.tbDuAn
                                where proj.MaDA == da.MaDA
                                select proj).Single();

                    foreach (ClassCongViec cv in da.listCV)
                    {
                        //lay congviec tu sql
                        var dbcv = (from d in _context.tbCongViec
                                    where d.MaCV == cv.MaCV
                                    select d).Single();
                        //them vao listcv cua dbda
                        dbda.listCV.Add(dbcv);
                    }
                    _context.tbDuAn.AddOrUpdate(dbda);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
          
            
            
                      
        }
        public static ClassDuAn GetDuAn(string MaDa)
        {
            using(var _context=new DBManageContext())
            {
                var da = (from d in _context.tbDuAn
                          where MaDa == d.MaDA
                          select d).ToList();
                if (da.Count == 1)
                    return da[0];
                else
                    return null;
            }
        }
        public static bool DeleteDuAn(string MaDa)
        {
            try
            {
                using (var _context = new DBManageContext())
                {
                    var da = (from d in _context.tbDuAn
                              where MaDa == d.MaDA
                              select d).Single();
                    _context.tbDuAn.Remove(da);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
            
        }
        public static List<ClassDuAn> GetListDA()
        {
            using (var _context=new DBManageContext())
            {
                var da = _context.tbDuAn.Include(a => a.listCV).ToList();
                
                return da;
            }
        }

        public static bool UpdateDA(ClassDuAn da)
        {
            try
            {
                using (var _context = new DBManageContext())
                {
                    //update duan voi listcongviec rong
                    
                    _context.tbDuAn.AddOrUpdate(da);
                    _context.SaveChanges();
                }
                using (var _context = new DBManageContext())
                {
                    //lay du an
                    var dbda = (from proj in _context.tbDuAn
                                where proj.MaDA == da.MaDA
                                select proj).Single();

                    foreach (ClassCongViec cv in da.listCV)
                    {
                        //lay congviec tu sql
                        var dbcv = (from d in _context.tbCongViec
                                    where d.MaCV == cv.MaCV
                                    select d).Single();
                        //them vao listcv cua dbda
                        dbda.listCV.Add(dbcv);
                    }
                    _context.tbDuAn.AddOrUpdate(dbda);
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
