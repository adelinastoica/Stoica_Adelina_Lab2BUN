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
    public class DeleteModel : PageModel
    {
        private readonly Stoica_Adelina_Lab2.Data.Stoica_Adelina_Lab2Context _context;

        public DeleteModel(Stoica_Adelina_Lab2.Data.Stoica_Adelina_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);

            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }
            var category = await _context.Category.FindAsync(id);

            if (category != null)
            {
                Category = category;
                _context.Category.Remove(Category);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
