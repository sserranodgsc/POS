namespace POS.Infraestructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        // Declaración de interfaces a nivel de repositorio
        ICategoryRepository Category {  get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
