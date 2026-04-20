using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1EFcore1.Modals
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int Year { get; set; }
        public Author AuthorID { get; set; }
        public Category CategoryId { get; set; }

    }
}
