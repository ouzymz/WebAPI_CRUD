using BUSSINESLayer.Abstract;
using DATALayer.Abstract;
using ENTITYLayer.Concrete;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESLayer.Concrete
{
    public class StudentManager : IStudentService
    {
        IStundentDal _studentDal;
        private ILogger _logger;

        public StudentManager(IStundentDal studentDal, ILoggerFactory logger)
        {
            _studentDal = studentDal;
            _logger = logger.CreateLogger("AplicationLog"); 
        }

        public List<Student> TGetAll()
        {
            return _studentDal.GetAll();
        }

        public Student TGetProductById(int Id)
        {
            return _studentDal.GetProductById(Id);
        }

        public void TCreate(Student t)
        {
            _studentDal.Create(t);
        }

        public void TDelete(int id)
        {
            _studentDal.Delete(id);
        }

        public void TUpdate(Student t)
        {
            _studentDal.Update(t);
        }
    }
}
