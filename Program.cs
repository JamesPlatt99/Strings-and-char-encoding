using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_character_encodings
{
    class Program
    {
        static void Main(string[] args)
        {
            CSVParser csvParser = new CSVParser();
            List<Book> books = csvParser.GetBooks("books.csv");

        }        
        private void DisplayData(List<Book> books)
        {
            Console.WriteLine("|Pub Date    |                       Title|Authors                         |");
            Console.WriteLine("|==========================================================================|");
            foreach(Book book in books)
            {

            }
        }
        private String GetLine(Book book)
        {
            string date = string.Format("{0:D}", book.Date);
            String line = $"|{book.Date}:D|{book.Title}|{String.Join("&", book.Authors)}|";
            return line;
        }
    }
}
