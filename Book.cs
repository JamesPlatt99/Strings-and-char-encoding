using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_character_encodings
{
    public class Book
    {
        public DateTime Date { get; set; }
        public String Title { get; set; }
        public String[] Authors { get; set; }

        public Book(String date, String title, String authors)
        {
            this.Date = DateTime.Parse(date);
            this.Title = title;
            this.Authors = authors.Split('&');
        }
    }
}
