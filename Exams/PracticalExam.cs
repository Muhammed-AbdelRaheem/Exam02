using Exam02.Questions;
using Exam02.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Exams
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
        {
        }

        public override void CreateQuestion()
        {
            ListOfQuestions = new MCQQuestion[NumberOfQuestions];
            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                ListOfQuestions[i] = new MCQQuestion();
                ListOfQuestions[i].ShowQuestion();

                Console.Clear();

            }
        }

        public override void ShowExam()
        {
            foreach (var Qs in ListOfQuestions)
            {
                Console.WriteLine(Qs);


                for (int i = 0; i < Qs.AnswerList.Length; i++)
                {
                    Console.WriteLine(Qs.AnswerList[i]);
                }
                Console.WriteLine("-----------------------------");

                int UserAnswerId;


                do
                {
                    Console.WriteLine("enter number of your answer:");

                }
                while (!int.TryParse(Console.ReadLine(), out UserAnswerId) || UserAnswerId < 1 || UserAnswerId > 3);


                Console.WriteLine("------------------------------");

            }



            Console.Clear();
            Console.WriteLine("Right answers:");
            for (int i = 0; i < ListOfQuestions.Length; i++)
            {

                Console.WriteLine($"Right Answer of question{i + 1}: {ListOfQuestions[i].RightAnswer.AnswerText}");
            }
        }
    }
}
