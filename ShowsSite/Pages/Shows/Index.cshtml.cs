using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShowsSite.Data;

namespace ShowsSite.Pages.Showes
{
    public class IndexModel : PageModel
    {
        private readonly ShowsDataContext _context;

        public IndexModel(ShowsDataContext context)
        {
            _context = context;
        }
        public List<Show> Shows { get; set; }
        public int NumberOfShows { get; set; }
        public async Task OnGetAsync()
        {
            Shows = await _context.Shows.ToListAsync();
            NumberOfShows = Shows.Count();
        }

        public async Task<ActionResult> OnPostWatched(int id)
        {
            var show = await _context.Shows.SingleOrDefaultAsync(s => s.Id == id && s.Watched == false);
            if(show != null)
            {
                show.Watched = true;
                await _context.SaveChangesAsync();
                // You could do some tempdata magic here....
              
            }
            return RedirectToPage("Index");
        }


        public string GetCssFor(Show show)
        {
            var watched = show.Watched;
            var cssClass = "alert ";
            cssClass += watched ? "alert-info" : "alert-success";
            return cssClass;
        }
    }
}
