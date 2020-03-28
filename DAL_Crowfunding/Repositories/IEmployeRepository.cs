namespace DAL_Crowfunding.Repositories
{
    public interface IEmployeRepository<TKey, T> : IRepository<TKey, T> where T : class
    {
    }
}