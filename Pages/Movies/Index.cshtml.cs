using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Blockbuster.Data;
using Blockbuster.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlockbusterUpdate.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Blockbuster.Data.BlockbusterContext _context;

        public IndexModel(Blockbuster.Data.BlockbusterContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            // using System.Linq;
            var movies = from m in _context.Movie select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => 
                s.Title.Contains(SearchString));
            }

            Movie = await movies.ToListAsync(); 

            //Movie = await _context.Movie.ToListAsync();
        }
    }
}
