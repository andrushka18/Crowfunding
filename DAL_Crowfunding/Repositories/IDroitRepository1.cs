namespace DAL_Crowfunding.Repositories
{
    public interface IDroitRepository<TKey,T>:IRepository<TKey,T> where T:class
    {
        
        void SetAdmin(TKey id);
        void UnsetAdmin(TKey id);
    }
}