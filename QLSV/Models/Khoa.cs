using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLSV.Models
{
    public class Khoa
    {        
        [Key]
        public string Makhoa { get; set; }
        public string Tenkhoa { get; set; }
        public ICollection<SinhVien> Sinhvien { get; set; }
    }
}
