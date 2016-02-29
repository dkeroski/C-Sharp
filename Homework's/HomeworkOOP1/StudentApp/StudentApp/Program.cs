using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student dejan = new Student();
            dejan.FirstName = "Dejan";
            dejan.LastName = "Keroski";
            dejan.Index = 1145;
            dejan.Age = 27;

            Console.WriteLine(dejan.GetStudent());
            dejan.ResetValues();
            Console.ReadLine();
        }
    }
}
