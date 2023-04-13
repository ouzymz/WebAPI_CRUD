using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLayer.Concrete
{
    public class Student : BaseEntity
    {
        public int Grade { get; set; }

        public string Gender { get; set; }
    }
}
