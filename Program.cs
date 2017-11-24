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
            Console.WriteLine(" 28 Nov 2008 ".Length);
            CSVParser csvParser = new CSVParser();
            List<Book> books = csvParser.GetBooks("books.csv");
            DisplayData(books);
            Console.ReadKey();
        }        
        static void DisplayData(List<Book> books)
        {
            Table table = new Table();
            Console.WriteLine("| Pub Date    |                       Title | Authors                         |");
            Console.WriteLine("|=============================================================================|");
            foreach (Book book in books)
            {
                Console.WriteLine(table.GetLine(book));
            }
        }
        
    }
}
