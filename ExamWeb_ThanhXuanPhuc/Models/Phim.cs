using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_ThanhXuanPhuc.Models
{
    public class Phim
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Chưa nhập tựa đề")]
        [StringLength(250)]
        public string TuaDe { get; set; }
        [Required(ErrorMessage = "Chưa nhập diễn viên")]
        public string DienVien { get; set; }
        public bool TrongNuoc { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Giá vé không hợp lệ")]
        public double GiaVe { get; set; }
        [Range(60, 180, ErrorMessage = "Thời lượng phải từ 60 đến 180 phút")]
        public int ThoiLuong { get; set; }
    }
}
