using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace Homework_2___Week_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Author and Book Management System!\n");
            Console.WriteLine("Author Information:\r\n");
            Console.WriteLine("Enter AuthorName:\n");
            string AuthorName = Console.ReadLine();

            Console.WriteLine("Enter birthYear:\n");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter nationality:\n");
            string nationality = Console.ReadLine();

            Author author =new Author(AuthorName, birthYear,nationality);
            Console.WriteLine(author.displayAuthorInfo());
            Console.WriteLine($"\n Adding Books for{author.authorName}:");
           
            int i = 0;
            Book[] book = new Book[3];
            Book books;
            do
            {
                Console.WriteLine("Enter Book Title:");
                string BookTitle = Console.ReadLine();
                Console.WriteLine("Enter Publication Year:");
                int publicationYear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Genre:");
                string genre = Console.ReadLine();

                 books = new Book(BookTitle, publicationYear, genre);

                //  Book[] book =new Book[book1, book2, book3];
                book[i] = books;
                i++;
            } while (i < 3);

            author.Addbook(book);
            Console.WriteLine($"displaying Books {author.authorName}:\n");
           author.display();
            Console.ReadKey();
        }
        
    }
    }
