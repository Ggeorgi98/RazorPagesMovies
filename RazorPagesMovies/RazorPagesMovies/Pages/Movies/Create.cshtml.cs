using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovies.Models;

namespace RazorPagesMovies.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMoviesContext dbContext;

        public CreateModel(RazorPagesMoviesContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            dbContext.Movie.Add(Movie);
            await dbContext.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}