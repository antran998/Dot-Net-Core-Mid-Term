using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLSV.Models
{
    public class SinhVien
    {
        [Key]
        public string MaSV { get; set; }
        public string Hoten { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Dienthoai { get; set; }
        public double DiemGK { get; set; }
        public double DiemCK { get; set; }
        public Khoa Khoa { get; set; }
        public LopHocPhan LopHocPhan { get; set; }

    }
}
