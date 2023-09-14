namespace graph7
{
    public class Query
    {
        private static List<Book> books = new List<Book>{
            new Book {Title = "O Senhor dos Anéis", Author = new Author { Name = "J.R.R. Tolkien" }},
            new Book {Title = "Harry Potter e a Pedra Filosofal", Author = new Author { Name = "J.K. Rowling" }},
        };

        public Book GetBook(string title)
        {
            return books.FirstOrDefault(x => x.Title == title);
        }
        public List<Book> GetBooks()
        {
            return books;
        }
        public Author GetAuthor()
        {
            return new Author { Name = "J.R.R. Tolkien" };
        }
    }
}