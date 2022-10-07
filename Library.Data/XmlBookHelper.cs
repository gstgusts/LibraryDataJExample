using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Library.Data
{
    internal class XmlBookHelper
    {

        internal static List<Book> Load(string url = @"books.xml")
        {
            var bookElements = XElement.Load(url).Elements("book");

            return bookElements.Select(x => new Book
            {
                Title = x.Element("title").Value,
                Description = x.Element("description").Value,
                Genre = Enum.Parse<GenreEnum>(x.Element("genre").Value, true),
                Authors = GetAuthors(x.Descendants("author")),
                Keywords = x.Descendants("keyword").Select(k => k.Value).ToArray()
            }).ToList();
        }


        internal static Author[] GetAuthors(IEnumerable<XElement> authors)
        {
            return authors.Select(a => new Author(a.Value, "")).ToArray();
        }
    }
}
