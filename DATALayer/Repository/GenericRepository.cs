using DATALayer.Abstract;
using DATALayer.Concrete;
using DATALayer.EF;
using ENTITYLayer.Concrete;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {

        public StundentContext _context;
        private readonly ILogger _logger;
        public GenericRepository(StundentContext context, ILoggerFactory logger)
        {
            _context= context;
            _logger = logger.CreateLogger("AplicationLog");
        }
        public void Create(T item)
        {
            
            _context.Add(item);

            _context.SaveChanges();
        }

        public void Delete(int Id)
        {

            _context.Remove(_context.Set<T>().Find(Id));

            _context.SaveChanges();
        }

        public List<T> GetAll()
        {

            List<T> list = _context.Set<T>().ToList();

            return list;
        }

        public T GetProductById(int Id)
        {
           

            var getProduct = _context.Set<T>().Find(Id);

            return getProduct;
        }

        public void Update(T item)
        {
            using var _dbcontext = new StundentContext();

            _context.Set<T>().Update(item);

            _dbcontext.SaveChanges();

        }
    }
}
