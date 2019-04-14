using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            Console.Write("Ваши оценки(1-12): ");
            student.MyMarks();
            Console.WriteLine();


            Console.Write("Кол-во пропусков: ");
            student.CountOfPassLessons();
            Console.WriteLine();



            Console.Write("Кол-во опазданий: ");
            student.CountOfLateLessons();
            Console.Read();
        }
    }
}
