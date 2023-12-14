using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    //Books Entity
    internal class Books
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; } // Foreign key property

        // Navigation property (many-to-one with Author)
        public Author Author { get; set; }
    }
}
