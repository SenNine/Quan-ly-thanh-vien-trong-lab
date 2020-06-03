using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythanhvientronglab.Models
{
    [Table("ThanNhan")]
    public class ClassThanNhan
    {
        public ClassHoSoNV hoso { set; get; }
        [Key]
        [Column(Order =10)]
        public string MaNV { set; get; }        
        public string TenNV { set; get; }
        [Key]
        [Column(Order =20)]
        public string TenThanNhan { set; get; }
        public string QuanHe { set; get; }

    }
}
