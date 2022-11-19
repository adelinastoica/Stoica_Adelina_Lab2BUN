using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stoica_Adelina_Lab2.Models;

namespace Stoica_Adelina_Lab2.Data
{
    public class Stoica_Adelina_Lab2Context : DbContext
    {
        public Stoica_Adelina_Lab2Context (DbContextOptions<Stoica_Adelina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Stoica_Adelina_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Stoica_Adelina_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Stoica_Adelina_Lab2.Models.Author> Author { get; set; }

        public DbSet<Stoica_Adelina_Lab2.Models.Category> Category { get; set; }
    }
}
