namespace DAL_Crowfunding.Repositories
{
    public interface IFinanceurRepository<TKey, T> : IRepository<TKey, T> where T : class
    {
    }
}