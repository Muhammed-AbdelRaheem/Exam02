using Exam02.Answers;
using Exam02.Exams;
using Exam02.Questions;
using Exam02.Subjects;
using System.Diagnostics;

namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            subject.CreateExam();

            char c;
            do
            {
                Console.WriteLine("Do You Want to start the Exam (Y | N):");


            } while (!char.TryParse(Console.ReadLine(), out c));

            if (c == 'Y' || c == 'y')
            {
                Console.Clear();
                Stopwatch sw = new Stopwatch();
                sw.Start();

                subject.SbExam.ShowExam();
                Console.WriteLine($"Time Taken:{sw.Elapsed}");
                Console.WriteLine("########Thank You!#########");
            }
            else { return; }

         











        }
    }
}
