
using System.Threading.Channels;

namespace Homework_2___Week_3
{
    internal class Book
    {
        public string title;
        public int publicationYear;
        public string genre;

      
        public Book (string title, int publicationYear, string genre)
        {
            this.title = title;
            this.publicationYear = publicationYear;
            this.genre = genre;
        }

        public void displayBookInfo() => Console.WriteLine($"Title is:{this.title}\n the publicationYear is:{this.publicationYear}\n " +
                $"the genre is: {this.genre}");
    }
}