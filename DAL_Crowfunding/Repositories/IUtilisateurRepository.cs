namespace DAL_Crowfunding.Repositories
{
    public interface IUtilisateurRepository<TKey, T> : IRepository<TKey, T> where T : class
    {
        void ChangePassword(TKey id, string password);

        TKey Check(string username, string password);
    }
}