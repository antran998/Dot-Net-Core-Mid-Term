using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLSV.Models
{
    public class MonHoc
    {
        [Key]
        public string Mamon { get; set; }
        public string Tenmon { get; set; }
        public string Sotinhi { get; set; }
        public ICollection<LopHocPhan> Lophocphan { get; set; }
    }
}
