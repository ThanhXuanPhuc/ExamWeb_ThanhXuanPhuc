using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_ThanhXuanPhuc.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> ops) : base(ops)
        {

        }
        public DbSet<Phim> Phims { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Phim>().HasData(
                new Phim { Id = 1, TuaDe = "Lật Mặt 6", DienVien = "Lý Hải", TrongNuoc = true, GiaVe = 75000, ThoiLuong = 110 },
                new Phim { Id = 2, TuaDe = "Avengers: Endgame", DienVien = "Robert Downey Jr.", TrongNuoc = false, GiaVe = 95000, ThoiLuong = 181 },
                new Phim { Id = 3, TuaDe = "Inception", DienVien = "Leonardo DiCaprio", TrongNuoc = false, GiaVe = 85000, ThoiLuong = 148 },
                new Phim { Id = 4, TuaDe = "Bố Già", DienVien = "Trấn Thành", TrongNuoc = true, GiaVe = 80000, ThoiLuong = 128 },
                new Phim { Id = 5, TuaDe = "Joker", DienVien = "Joaquin Phoenix", TrongNuoc = false, GiaVe = 90000, ThoiLuong = 122 },
                new Phim { Id = 6, TuaDe = "Hai Phượng", DienVien = "Ngô Thanh Vân", TrongNuoc = true, GiaVe = 78000, ThoiLuong = 98 }
            );
        }

    }
}
