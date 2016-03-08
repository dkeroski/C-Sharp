using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public sealed class Student : SEDCMember
    {
        //prop  grades array
        public List<int> Grades = new List<int>();
        public List<double> Averages = new List<double>();


        public Student()
        {
           ID = ID;
           FirstName = FirstName;
           LastName = LastName;
        }


        public int MaxGrade()
        {
            return Grades.Max();
        }

        public double AverageGrade()
        {
            Averages.Add(Grades.Average());
            return Grades.Average();
        }

       
    }

   
}
