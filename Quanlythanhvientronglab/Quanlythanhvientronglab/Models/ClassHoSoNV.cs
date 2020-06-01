using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythanhvientronglab.Models
{
    [Table("HoSoNV")]
    public class ClassHoSoNV
    {
        [Key]
        public string MaNV { set; get; }
        public string TenNV { set; get; }
        public string NgaySinh { set; get; }
        public string GioiTinh { set; get; }
        public string TonGiao { set; get; }
        public string SDT { set; get; }
        public string Email { set; get; }        
        public string TenChucVu { set; get; }
        public ClassChucVu ChucVu { set; get; }
    }
}
