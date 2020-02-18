using System;

namespace Types
{
    class Program
    {
        private static object firstName;

        static void Main(string[] args)
        {
            string firstName = "Zach";
            int grade = 98;
            char letterGrade = 'A';
                double costOfTuition = 15000.00;

            Console.WriteLine($"{firstName} is the proffesor, {grade} is the grade earned. which is an{letterGrade} and it cost {costOfTuition} to attend his class");
            Console.ReadLine();
        }
    }
}
