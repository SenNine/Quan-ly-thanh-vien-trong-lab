using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythanhvientronglab.Models
{
    [Table("PhanCong")]
    public class ClassPhanCong
    {
        public ClassDuAn DuAn { set; get; }
        [Key]
        [Column(Order = 10)]
        public string MaDA { set; get; }
        public ClassHoSoNV HoSo { set; get; }
        [Key]
        [Column(Order = 20)]
        public string MaNV { set; get; }
        
        public string TenNV { set; get; }
    }
}
