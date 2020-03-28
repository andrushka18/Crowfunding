namespace DAL_Crowfunding.Repositories
{
    public interface IPalierRepository<TKey, T>:IRepository<TKey, T> where T : class
    {
    }
}