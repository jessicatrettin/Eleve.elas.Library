namespace Eleve.elas.Library.Domain.Entities
{
    internal class LibraryUserEntity
    {
        private long Id { get; set; }
        public string Name { get; set; }

        internal void BorrowBook(string isbn)
        {
            new BookEntity().Borrow(isbn);
        }

        protected string GetUserInfo()
        {
            return $"Usuário: {Name} | ID: {Id}";
        }
    }
}
