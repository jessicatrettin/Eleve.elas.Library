namespace Eleve.elas.Library.Domain.Entities
{
    internal class BookEntity
    {
        public string Title { get; set; }
        protected string Author { get; set; }
        internal string ISBN { get; set; }
        private string? Summary { get; set; }
        private bool Available { get; set; }

        private static List<BookEntity> _books = new List<BookEntity>();

        public BookEntity() 
        {
        }

        public BookEntity(string title, string author, string isbn, string summary)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Summary = summary;
            Available = true;
        }

        public string Getsummary(string isbn)
        {
            var summary = _books.SingleOrDefault(book => book.ISBN == isbn).Summary;

            if (summary is null)
                return "Livro nao encontrado";

            return summary;
        }

        internal BookEntity? Get(string isbn)
        {
            var book = _books.SingleOrDefault(book => book.ISBN == isbn);

            if (book is null)
                return null;

            return book;
        }

        internal List<BookEntity> GetAll()
        {
            return _books;
        }

        internal void Create(BookEntity book)
        {
            _books.Add(book);
        }

        internal void Delete(BookEntity book)
        {
            _books.Remove(book);
        }

        internal void Borrow(string isbn)
        {
            _books.SingleOrDefault(book => book.ISBN == isbn).ChangeAvailable();
        }

        internal void ChangeAvailable()
        {
            Available = !Available;
        }
    }
}
