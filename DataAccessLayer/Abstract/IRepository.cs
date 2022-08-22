using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        // Irepository ile kullanılan metotlar kalıtsal olarak alınarak diğer tüm repositorylerde kullanılabilir
        // Bu yöntemin ismi Generic'tir
        List<T> List();

        T Get(Expression<Func<T, bool>> filter); // Filtreleme Türü Entity(T). Tek bir değer getirir.
        void Insert(T p);
        void Update(T p);
        void Delete(T p);
        List<T> List(Expression<Func<T, bool>> filter); // Filtreleme Türü List
    }
}
