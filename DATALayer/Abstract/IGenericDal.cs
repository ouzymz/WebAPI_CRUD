using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALayer.Abstract
{
    public interface IGenericDal<TClass>
    {
        void Create(TClass item);
        void Update(TClass item); 
        void Delete(int Id);
        List<TClass> GetAll();
        TClass GetProductById(int Id);
  
    }
}
