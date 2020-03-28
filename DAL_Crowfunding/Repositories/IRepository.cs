using NPOI.SS.Formula.Functions;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Crowfunding.Repositories
{
    public interface IRepository<TKey, T> where T : class
    {
        IEnumerable<T> Get();
        T Get(TKey id);
        void Add(T entity);
        void Update(TKey id, T entity);
        void Delete(TKey id);
    }
}
