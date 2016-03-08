using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  sealed class Teacher : SEDCMember
    {
        public int teacherGrade { get; set; }

        public Teacher()
        {
            ID = ID;
            FirstName = FirstName;
            LastName = LastName;
        }

       
    }
}
