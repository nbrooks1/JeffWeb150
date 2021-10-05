using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ShowsSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowsSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly TopShowsService _service;

        public IndexModel(ILogger<IndexModel> logger, TopShowsService service)
        {
            _logger = logger;
            _service = service;
        }
        public TopShowsResponse TopShows { get; set; }
        public async Task OnGetAsync()
        {
            TopShows = await _service.GetTopShowsAsync();
        }
    }
}
