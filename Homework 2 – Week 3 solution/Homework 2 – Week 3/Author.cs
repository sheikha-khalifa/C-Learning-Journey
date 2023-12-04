
using System.Diagnostics;

namespace Homework_2___Week_3
{
    internal class Author
    {
        public string authorName;
        public int birthYear;
        public string nationality;

        public static Book[] books;

        public Author(string authorName, int birthYear, string nationality)
        {
            this.authorName = authorName;
            this.birthYear = birthYear;
            this.nationality = nationality;

        }
       public void Addbook(Book[] book)
        {
            books = book;
            Console.WriteLine(   books.Length);
        }

        public void display()
        {
            for (int i = 0; i < books.Length; i++)
            {
                books[i].displayBookInfo();
            }
        }
        public string displayAuthorInfo()=>$"AuthorName is:{this.authorName}\n the BirthYear is:{this.birthYear}\n " +
            $"the nationality is: {this.nationality}";
        
      

    }
}
