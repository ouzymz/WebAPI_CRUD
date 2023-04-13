using DATALayer.Abstract;
using DATALayer.Concrete;
using ENTITYLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        
        public void Create(T item)
        {
            using var _dbcontext = new StundentContext();    
            
            _dbcontext.Add(item);

            _dbcontext.SaveChanges();
        }

        public void Delete(int Id)
        {
            using var _dbcontext = new StundentContext();

            _dbcontext.Remove(_dbcontext.Set<T>().Find(Id));

            _dbcontext.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var _dbcontext = new StundentContext();

            List<T> list = _dbcontext.Set<T>().ToList();

            return list;
        }

        public T GetProductById(int Id)
        {
            using var _dbcontext = new StundentContext();

            var getProduct = _dbcontext.Set<T>().Find(Id);

            return getProduct;
        }

        public void Update(T item)
        {
            using var _dbcontext = new StundentContext();

            _dbcontext.Set<T>().Update(item);

            _dbcontext.SaveChanges();

        }
    }
}
