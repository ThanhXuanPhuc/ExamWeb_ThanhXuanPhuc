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
    }
}
