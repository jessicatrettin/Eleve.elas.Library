namespace Eleve.elas.Library.Domain.Entities
{
    internal class LibraryEmployeeEntity
    {
        protected internal long Id { get; set; }

        private static List<LibraryEmployeeEntity> _libraryEmployees = new List<LibraryEmployeeEntity>();
        public static int globalId;

        public LibraryEmployeeEntity(long id)
        {
            Id = id;
        }

        protected void CreateBook(string title, string author, string isbn, string summary)
        {
            var book = new BookEntity(title, author, isbn, summary);
            new BookEntity().Create(book);
        }

        private protected void DeleteBook(BookEntity book)
        {
            new BookEntity().Delete(book);
        }

        public void CreateLibraryEmployee()
        {
            var id = Interlocked.Increment(ref globalId);

            _libraryEmployees.Add(new LibraryEmployeeEntity(id));
        }
    }
}
