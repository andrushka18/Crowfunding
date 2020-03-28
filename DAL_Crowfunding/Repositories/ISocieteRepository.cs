namespace DAL_Crowfunding.Repositories
{
    public interface ISocieteRepository<TKey, T> : IRepository<TKey, T> where T : class
    {
    }
}