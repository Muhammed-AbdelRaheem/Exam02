using Exam02.Exams;
using Exam02.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Subjects
{
    public class Subject
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public Exam SbExam { get; set; }

        public Subject(int id, string? name)
        {
            Id = id;
            Name = name;
        }

        public Subject()
        {
        
        }


        public void CreateExam()
        {
            int ExamType, Time, NumberOfQuestions;

            do
            {
                Console.WriteLine("Please Enter The Type Of Exam (1 For Practical | 2 For Final):");
            }
            while (!int.TryParse(Console.ReadLine(), out ExamType) || ExamType < 1 || ExamType > 2);


            do
            {
                Console.WriteLine("Please Enter Time Of The Exam From (30 to 180 min):");
            }
            while (!int.TryParse(Console.ReadLine(), out Time) || Time < 30 || Time > 180);


            do
            {
                Console.WriteLine("Please Enter The Number of questions :");
            }
            while (!int.TryParse(Console.ReadLine(), out NumberOfQuestions) || NumberOfQuestions < 1);

            if (ExamType == 1)
            {
                SbExam = new PracticalExam(Time, NumberOfQuestions);
            }
            else
                SbExam = new FinalExam(Time, NumberOfQuestions);

            Console.Clear();

            SbExam.CreateQuestion();
        }

        
    }
}
