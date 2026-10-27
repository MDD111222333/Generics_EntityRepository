using System.Collections.Generic;
using System.Linq;

namespace Generics_EntityRepository
{
    public class Repository<T> where T : Entity
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T? GetById(int id)
        {
            return items.FirstOrDefault(x => x.Id == id);
        }
    }
}