using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESLayer.Abstract
{
    public interface IGenericService<TClass>
    {
        void TCreate(TClass t);
        void TUpdate(TClass t);
        void TDelete(int Id);

        List<TClass> TGetAll();
        TClass TGetProductById(int Id);
    }
}
