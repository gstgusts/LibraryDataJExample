using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data
{
    public class BookLibrary
    {
        public BookLibrary()
        {
            Load();
        }

        public BookLibrary(string url)
        {
           Load(url);
        }

        private List<Book> _books = new List<Book>();

        public List<Book> Books { get { return _books; } } //added get access to book list for searching and removing

        public void Add(Book book)
        {
            _books.Add(book);
        }

        public void Remove(Book book)
        {
            _books.Remove(book);
        }

        public IEnumerable<Book> SearchByTitle(string query)
        {
            return _books.Where(b => b.Title.Contains(query, StringComparison.InvariantCultureIgnoreCase));
        }
        public IEnumerable<Book> SearchByGenre(string query)
        {
            return _books.Where(b => b.Genre.ToString().Contains(query, StringComparison.InvariantCultureIgnoreCase));
        }

        public IEnumerable<Book> SearchByDescription(string query)
        {
            return _books.Where(b => b.Description.Contains(query, StringComparison.InvariantCultureIgnoreCase));
        }

        private void Load()
        {
            _books = XmlBookHelper.Load();
        }

        private void Load(string url)
        {
            _books = XmlBookHelper.Load(url);
        }
    }
}
