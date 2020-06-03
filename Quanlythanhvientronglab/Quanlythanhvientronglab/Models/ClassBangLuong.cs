using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythanhvientronglab.Models
{
    public class ClassBangLuong
    {
        public ClassHoSoNV hoso { set; get; }
        [Key]
        [Column(Order =10)]
        public string MaNV { set; get; }
        [Key]
        [Column(Order = 20)]
        public string tenNV { set; get; }
        public float HeSoLuong { set; get; }
        public float Luong { set; get; }
    }
}
