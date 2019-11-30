using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLSV.Models
{
    public class LopHocPhan
    {
        [Key]
        public string MaLHP { get; set; }
        public string Namhoc { get; set; }
        public string Hocky { get; set; }
        public string Mon { get; set; }        
        public ICollection<SinhVien> Sinhvien { get; set; }
        public MonHoc Monhoc { get; set; }
    }
}
