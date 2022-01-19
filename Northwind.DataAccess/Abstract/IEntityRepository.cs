using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity,new() 
    { // Sadece Product değil yeri geldiğinde Category entity de verileceği için
      // <T> ile generic olarak çalışırız. Methodları buraya işleriz.
        List<T> GetAll(Expression<Func<T,bool>> filter=null); // Filtre,parametre ekledik. Linq yardımıyla.
                                                              // null , filtre vermek zorunda olmadığımızı gösterir.
        T Get(Expression<Func<T, bool>>filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
