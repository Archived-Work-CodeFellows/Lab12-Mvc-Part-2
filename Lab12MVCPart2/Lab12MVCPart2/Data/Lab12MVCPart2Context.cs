using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab12MVCPart2.Models
{
    public class Lab12MVCPart2Context : DbContext
    {
        public Lab12MVCPart2Context (DbContextOptions<Lab12MVCPart2Context> options)
            : base(options)
        {
        }

        public DbSet<Lab12MVCPart2.Models.Movie> Movie { get; set; }
    }
}
