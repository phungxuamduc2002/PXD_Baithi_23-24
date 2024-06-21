using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PXDBaiThi_23_24.Models;

namespace PXDBaiThi_23_24
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PXDBaiThi_23_24.Models.Person> Person { get; set; } = default!;
    }
}
