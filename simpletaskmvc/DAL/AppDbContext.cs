using Microsoft.EntityFrameworkCore;
using simpletaskmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simpletaskmvc.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options ):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
    }
}
