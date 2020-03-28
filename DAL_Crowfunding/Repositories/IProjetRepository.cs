namespace DAL_Crowfunding.Repositories
{
    public interface IProjetRepository<TKey, T> : IRepository<TKey, T> where T : class
    {
    }
}