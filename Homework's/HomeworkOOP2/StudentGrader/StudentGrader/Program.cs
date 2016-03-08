using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            List<double> averages = new List<double>();

            int id;
            string idInput;
            // ask for how much student you like to enter in system
            Console.WriteLine("Please enter number of Students that you want to put into the system");
            int input = int.Parse(Console.ReadLine());
            // with for loop insert students 
            // for each student ak for ID FirstName LastName

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("Please enter Student #{0} info", i + 1);
                Student newStudent = new Student();
                //Control the ID with metghods isIDValid() and ScanIDCard()
                //and repeat message for input the id while user not write number of ID.
                do
                {
                    Console.WriteLine("Enter student ID:");
                    idInput = Console.ReadLine();

                } while (!(newStudent.ScanIdCard(idInput) && newStudent.IsIdValid(idInput)));
                //parse id input
                id = int.Parse(idInput);
                //Student Firstname
                Console.WriteLine("Enter Student First Name:");
                string firstname = Console.ReadLine();
                //Student Last Name
                Console.WriteLine("Enter Student Last Name:");
                string lastName = Console.ReadLine();


                //the another for loop for how much grades you want to enter for Student
                Console.WriteLine("How much grades you want to enter for Student");
                int numGrade = int.Parse(Console.ReadLine());
                for (int j = 0; j < numGrade; j++)
                {
                    Console.WriteLine("Enter Student Grade #{0}", j + 1);
                    int grades = int.Parse(Console.ReadLine());
                    newStudent.Grades.Add(grades);
                    //each grade put in to list of grades
                    //leter use for easy find the average and maximum grade for each student
                    Console.WriteLine("");
                }

                //every student can write grade for his teacher...
                //i make this logic to write every students only one favorite teacher and add grade 
               
                Console.WriteLine("Enter your teacher grade: ");
                Teacher newTeacher = new Teacher();
                string teachID;
                do
                {
                    Console.WriteLine("Enter teacher id: ");
                    teachID = Console.ReadLine();

                } while (!(newStudent.ScanIdCard(teachID) && newStudent.IsIdValid(teachID)));
                int teachId = int.Parse(teachID);
                Console.WriteLine("Enter teacher FirstName: ");
                string teachName = Console.ReadLine();
                Console.WriteLine("Enter teacher LastName: ");
                string teachLastName = Console.ReadLine();
                Console.WriteLine("Enter teacher Grade: ");
                int gradeTeach = int.Parse(Console.ReadLine());

                //create object teacher and add to list of teachers
                newTeacher.ID = teachId;
                newTeacher.FirstName = teachName;
                newTeacher.LastName = teachLastName;
                newTeacher.teacherGrade = gradeTeach;
                teachers.Add(newTeacher);

                //create object student and add to list of students
                newStudent.ID = id;
                newStudent.FirstName = firstname;
                newStudent.LastName = lastName;
                students.Add(newStudent);
                // in the list of averages add every student average 
                // leter use for find student with best average of grades
                averages.Add(newStudent.AverageGrade());
                Console.WriteLine("-------------------------------------------------------------------------------");
                Console.Clear();
            }


               Console.WriteLine("------------------------STUDENTS INFO AND GRADES-------------------------------------");

               double maxAverage = averages.Max();
               foreach (var student in students)//print each student details, max garade, and average.
                                                //if students avereage is best print message that is the best student with maximum points
                {
                student.GetDetails();
                Console.WriteLine("Student Best Grade: " + student.MaxGrade());
                Console.WriteLine("Student Average Grades: " + student.AverageGrade());
                if (maxAverage == student.AverageGrade())
                {
                    Console.WriteLine("THIS IS THE BEST STUDENT WITH MAX-AVERAGE GRADES OF: {0}", student.AverageGrade());
                }

                Console.WriteLine("");

            }
            Console.WriteLine("--------------------TEACHER GRADES----------------------");
            foreach (var teacher in teachers)
            {

                teacher.GetDetails();
                Console.WriteLine("Teacher grade: {0}", teacher.teacherGrade);
                
            }
            
            Console.ReadLine();
        }
    }
}
