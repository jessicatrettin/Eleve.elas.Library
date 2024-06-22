namespace Eleve.elas.Library.Domain.Entities
{
    internal class ManagerEntity
    {
        private long Id { get; set; }

        protected string GetUserInfo()
        {
            return $"ID do usuário administrador: {Id}";
        }
    }
}
