using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShowsSite.Data;

namespace ShowsSite.Pages.Shows
{
    public class DetailsModel : PageModel
    {
        private readonly ShowsDataContext _context;

        public DetailsModel(ShowsDataContext context)
        {
            _context = context;
        }

        public Show Show { get; set; }
        public string ErrorMessage { get; set; }
        public async Task OnGetAsync(int id)
        {
            Show = await _context.Shows.SingleOrDefaultAsync(s => s.Id == id);
            if(Show == null)
            {
                ErrorMessage = "That Show Doesn't Exist";
            }
        }

    }
}
