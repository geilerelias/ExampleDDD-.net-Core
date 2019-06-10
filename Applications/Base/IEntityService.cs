using System.Collections.Generic;
using Domain.Base;

namespace Applications.Base
{
    public interface IEntityService<T> : IService
        where T : BaseEntity
    {
        T Find(object id);
        void Create(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        void Update(T entity);
    }
}
