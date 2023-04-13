using DATALayer.Abstract;
using DATALayer.Repository;
using ENTITYLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATALayer.EF
{
    public class EFStudentDal :GenericRepository<Student>, IStundentDal
    {
    }
}
