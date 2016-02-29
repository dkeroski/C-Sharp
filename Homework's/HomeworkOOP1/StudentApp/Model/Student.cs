using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Index { get; set; }
        public int Age { get; set; }

        public string GetStudent()
        {
            return String.Format(" Name: {0}\n Lastname: {1}\n Index: {2}\n Age :{3}", FirstName, LastName, Index, Age);
        }

        public void  ResetValues()
        {
            this.FirstName = " ";
            this.LastName = " ";
            this.Index = 0;
            this.Age = 0;
        }
    }
}
