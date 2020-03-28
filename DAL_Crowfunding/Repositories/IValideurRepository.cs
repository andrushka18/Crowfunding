namespace DAL_Crowfunding.Repositories
{
    public interface IValideurRepository<TKey, T> : IRepository<TKey, T> where T : class
    {
    }
}