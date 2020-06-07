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
    public class CongViecController
    {
        public static bool AddCV(ClassCongViec cv)
        {
            try
            {
                using (var _context = new DBManageContext())
                {
                    _context.tbCongViec.Add(cv);
                    _context.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static List<ClassCongViec> GetListCV()
        {
            using (var _context = new DBManageContext())
            {
                var cv = (from c in _context.tbCongViec.Include("listDA")
                          select c).ToList();
                return cv;
            }
        }
        public static List<ClassCongViec> GetListCV(string macv)
        {
            using (var _context = new DBManageContext())
            {
                
                var cv = (from c in _context.tbCongViec.Include("listDA")
                          where c.MaCV.Contains(macv)
                          select c).ToList();
                return cv;
            }
        }
        public static ClassCongViec GetCV(string MaCV)
        {
            using (var _context = new DBManageContext())
            {
                var cv = (from d in _context.tbCongViec
                          where MaCV == d.MaCV
                          select d).ToList();
                if (cv.Count == 1)
                    return cv[0];
                else
                    return null;
            }
        }
        public static bool DeleteCV(ClassCongViec cv)
        {
            try
            {
                using (var _context = new DBManageContext())
                {
                    var task = (from t in _context.tbCongViec
                                where t.MaCV == cv.MaCV
                                select t).Single();
                    _context.tbCongViec.Remove(task);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
            
        }
        public static bool UpdateCV(ClassCongViec cv)
        {
            try
            {
                using (var _context = new DBManageContext())
                {
                    _context.tbCongViec.AddOrUpdate(cv);
                    _context.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
