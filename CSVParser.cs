using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_character_encodings
{
    class CSVParser
    {
        public List<Book> GetBooks(string filePath)
        {
            List<Book> books = new List<Book>();
            System.IO.StreamReader reader = new System.IO.StreamReader(filePath);
            string[] line = reader.ReadLine().Split(',');
            while((line = reader.ReadLine().Split(',')) != null)
            {
                books.Add(new Book(line[0],line[1],line[2]));
            }
            return books;
        }
    }
}
