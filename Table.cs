using System;
using System.Collections.Generic;

namespace Strings_and_character_encodings
{
    public class Table
    {       
        public String GetLine(Book book)
        {
            string date = string.Format("{0:dd MMM yyyy}", book.Date).PadRight(11);
            string title = TruncateString(book.Title, 27).PadLeft(27);
            string authors = TruncateString(String.Join("&", book.Authors), 31).PadRight(31);
            String line = $"| {date} | {title} | {authors} |";
            return line;
        }
        private String TruncateString(String input, int maxLength)
        {
            if (input.Length <= maxLength)
            {
                return input;
            }
            else
            {
                return input.Substring(0, maxLength - 3) + "...";
            }
        }
    }
}
