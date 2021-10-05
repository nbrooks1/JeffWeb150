using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShowsSite.Data;
using ShowsSite.Models;

namespace ShowsSite.Pages.Shows
{
    public class NewModel : PageModel
    {
        private readonly ShowsDataContext _context;

        public NewModel(ShowsDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PostShowCreate Show { get; set; }
        public void OnGet()
        {
        }

        public async Task<ActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            } else
            {
                var showToAdd = new Show
                {
                    Title = Show.Title,
                    Network = Show.Network,
                    Watched = false
                };
                _context.Shows.Add(showToAdd);
                await _context.SaveChangesAsync();
                TempData["flash"] = $"Added {showToAdd.Title}";
                return RedirectToPage("New");
            }

        }
    }
}
