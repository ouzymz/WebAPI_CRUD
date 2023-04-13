using DATALayer.Abstract;
using DATALayer.Concrete;
using DATALayer.Repository;
using ENTITYLayer.Concrete;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALayer.EF
{
    public class EFStudentDal : GenericRepository<Student>, IStundentDal
    {
        public EFStudentDal(StundentContext context, ILoggerFactory logger) : base(context, logger)
        {
            
        }
    }
}
