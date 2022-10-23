using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using INMN3_1._2_RazorPages.Models;

namespace INMN3_1._2_RazorPages.Data
{
    public class NaszaBaza : DbContext
    {
        public NaszaBaza (DbContextOptions<NaszaBaza> options)
            : base(options)
        {
        }

        public DbSet<Miasto> Miasta { get; set; } = default!;
    }
}
