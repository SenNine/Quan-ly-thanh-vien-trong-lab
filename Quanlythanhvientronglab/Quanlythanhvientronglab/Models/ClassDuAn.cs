using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythanhvientronglab.Models
{
    [Table("DuAn")]
    public class ClassDuAn
    {
        [Key]
        public string MaDA { set; get; }
        public string TenDA { set; get; }
        public string ThongTinDA { set; get; }
        public string TienDo { set; get; }
        public string CongViec { set; get; }
    }
}
