using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Student : IStudent
    {
        Random rand = new Random();
        public int[] Mark = new int[5];


        public void CountOfLateLessons()
        {
            int lateLesson  = rand.Next(1 , 5);
            Console.Write(lateLesson);
        }

        public void CountOfPassLessons()
        {
            int passLesson = rand.Next(1, 5);
            Console.Write(passLesson);
        }

        public void MyMarks()
        {

            for (int i = 0; i < Mark.Length; i++)
            {
                Mark[i] = rand.Next(1, 12);
            }
            for (int i = 0; i < Mark.Length; i++)
            {
                Console.Write(Mark[i] + " ");
            }
        }
    }
}
