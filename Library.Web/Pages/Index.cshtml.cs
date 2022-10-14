using Library.Data;
using Library.Web.Helpers;
using Library.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<Book> Books { get; set; } = Enumerable.Empty<Book>();

        public string SearchType { get; set; } = "T";

        public string SelectedGenre { get; set; } = string.Empty;

        public string SearchQuery { get; set; } = string.Empty;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var a = "";
        }

        public void OnPost(SearchModel model)
        {
            var query = Request.Form["searchQuery"].ToString();
            var searchType = Request.Form["searchType"].ToString();
            var serchTypeSelected = Request.Form["searchTypeSelected"].ToString();
            var searchGenre = Request.Form["searchGenre"].ToString();

            //query.GetRandomText(5);

            SearchType = searchType;
            SelectedGenre = searchGenre;
            SearchQuery = query;

            if(!string.IsNullOrEmpty(serchTypeSelected))
            {
                return;
            }

            if(searchType == "T")
            {
                Books = Program.Library.SearchByTitle(query);
            } else if (searchType == "D")
            {
                Books = Program.Library.SearchByDescription(query);
            } else if(searchType == "G")
            {
                var genre = (GenreEnum)Enum.Parse(typeof(GenreEnum), searchGenre);
                Books = Program.Library.SearchByGenre(genre);
            } 
            else
            {
                throw new ArgumentException("No such search type", "searchType");
            }

        }
    }
}