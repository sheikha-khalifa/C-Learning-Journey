using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    //Author Entity
    internal class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        // Navigation property (one-to-many with Book)
        public ICollection<Books> Books { get; set; }
    }
}
