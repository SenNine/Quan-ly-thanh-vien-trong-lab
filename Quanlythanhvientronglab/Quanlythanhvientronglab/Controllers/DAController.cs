using Quanlythanhvientronglab.Models;
using System;
using System.Collections.Generic;
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
                    _context.tbDuAn.Add(da);
                    _context.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;           
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
    }
}
