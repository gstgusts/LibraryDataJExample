﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var a = "";
        }

        public void OnPost()
        {
            var query = Request.Form["searchQuery"].ToString();

            var result = Program.Library.SearchByTitle(query);
        }
    }
}