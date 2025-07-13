using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assighnment_OOP3
{
    internal class Book
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
    }

    internal class EBook:Book
    {
        public int FileSize { get; set; }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"File Size: {FileSize} MB");
        }
    }

    internal class PrintedBook : Book
    {
        public int PageCount { get; set; }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Page Count: {PageCount}");
        }
    }
}
