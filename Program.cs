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
            Program program = new Program();
            program.DisplayData(books);
        }        
        private void DisplayData(List<Book> books)
        {
            Console.WriteLine("| Pub Date    |                      Title | Authors                         |");
            Console.WriteLine("|============================================================================|");
            foreach(Book book in books)
            {
                Console.WriteLine(GetLine(book));
            }
            Console.ReadKey();
        }
        private String GetLine(Book book)
        {
            string date = string.Format("{0:dd MMM yyyy}", book.Date).PadRight(12);
            string title = TruncateString(book.Title, 27).PadLeft(27);
            string authors = TruncateString(String.Join("&", book.Authors), 31).PadRight(31);
            String line = $"| {date}|{title} | {authors}|";
            return line;
        }
        private String TruncateString(String input, int maxLength)
        {
            if(input.Length <= maxLength) {
                return input;
            }
            else
            {
                return input.Substring(0, maxLength - 3) + "...";
            }
        }
    }
}
