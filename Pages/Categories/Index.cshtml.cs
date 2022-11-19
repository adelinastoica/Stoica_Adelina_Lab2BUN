using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Stoica_Adelina_Lab2.Data;
using Stoica_Adelina_Lab2.Models;

namespace Stoica_Adelina_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Stoica_Adelina_Lab2.Data.Stoica_Adelina_Lab2Context _context;

        public IndexModel(Stoica_Adelina_Lab2.Data.Stoica_Adelina_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}
