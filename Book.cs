using System;

namespace _3
{
    class Author {
        public string AuthorName {get; set;}
        public void Show() {
            Console.WriteLine($"Author's name: {AuthorName}");
        }
    }
    class Title {
        public string BookTitle {get; set;}
        public void Show() {
            Console.WriteLine($"Book's title: {BookTitle}");
        }
    }
    class Content {
        public string BookContent {get; set;}
        public void Show() {
            Console.WriteLine($"Book's content: {BookContent}");
        }
    }
    class Book {
        public Author ThisAuthor {get; set;}
        public Title ThisTitle {get; set;}
        public Content ThisContent {get; set;}
        public void Show() {
            Console.ForegroundColor = ConsoleColor.Red;
            ThisAuthor.Show();
            Console.ForegroundColor = ConsoleColor.Green;
            ThisTitle.Show();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            ThisContent.Show();
        }
        public Book() {
            ThisAuthor = new Author();
            ThisTitle = new Title();
            ThisContent = new Content();
        }
        public Book(string AuthorName, string BookTitle, string BookContent) {
            ThisAuthor = new Author();
            ThisTitle = new Title();
            ThisContent = new Content();
            ThisAuthor.AuthorName = AuthorName;
            ThisContent.BookContent = BookContent;
            ThisTitle.BookTitle = BookTitle;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("Me", "About me", "A book about me");
            myBook.Show();
            Console.ReadKey();
        }
    }
}
