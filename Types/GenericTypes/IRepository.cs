using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    public interface IRepository<TEntity,TId> where TEntity : class, IEntity<TId>,  new()
                                      where TId: struct, IComparable<TId>
    {

        TEntity Get(TId id);
        IList<TEntity> GetAll();
        void Create(TEntity entity);
        void Update(TEntity entity);
    }

    public interface IEntity<T> where T: struct, IComparable<T>
    {
        //marker interface
        T Id { get; set; }
        
    }
    public class Product : IEntity<int>
    {
        public int Id { get; set; }
    }

    public class Category : IEntity<long>
    {
        public long Id { get; set; }
    }

    public class Customer : IEntity<Guid>
    {
        public Guid Id { get ; set ; }
    }

    public class CustomerRepository : IRepository<Customer, Guid>
    {
        public void Create(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }

    public class CategoryRepository: IRepository<Category,long>
}
