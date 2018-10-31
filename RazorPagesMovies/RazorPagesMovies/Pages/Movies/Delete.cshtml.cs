using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovies.Models;

namespace RazorPagesMovies.Pages.Movies
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesMoviesContext dbContext;

        public DeleteModel(RazorPagesMoviesContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await dbContext.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await dbContext.Movie.FindAsync(id);

            if (Movie != null)
            {
                dbContext.Movie.Remove(Movie);
                await dbContext.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
