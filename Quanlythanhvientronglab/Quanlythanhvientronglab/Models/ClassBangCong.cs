using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythanhvientronglab.Models
{
    public class ClassBangCong
    {
        public ClassHoSoNV HoSo { set; get; }
        [Key]
        [Column(Order = 10)]
        public string MaNV { set; get; }
        [Key]
        [Column(Order = 20)]
        public string TenNV { set; get; }
        public float SoNgayCong { set; get; }
        public float GioTangCa { set; get; }
    }
}
