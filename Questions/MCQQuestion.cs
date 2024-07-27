using Exam02.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Questions
{
    internal class MCQQuestion : Question
    {
        public override string? HeaderOfTheQuestion => "MCQ Question";
    
        public MCQQuestion()
        {
            AnswerList = new Answer[3];
        }




        public override void ShowQuestion()
        {

            // Header
            Console.WriteLine(HeaderOfTheQuestion);

            // Body
            Console.WriteLine("Please Enter Question Body");
            BodyOfTheQuestion = Console.ReadLine();


            // Marks

            int marks;

            do
            {
                Console.WriteLine("enter marks of question");

            } while (!int.TryParse(Console.ReadLine(),out marks)|| marks<1);

            Mark = marks;


            Console.WriteLine(" Choices Of Question :");

            for (int i = 0; i < 3; i++)
            {
                AnswerList[i] = new Answer
                {
                    AnswerId = i + 1
                };

                Console.WriteLine($"Please Enter Answer Number ({i + 1}) :");
                AnswerList[i].AnswerText = Console.ReadLine();
            }

            int rightAnswerId;
            do
            {
                Console.WriteLine("enter id of the right answer:");

            } while (!int.TryParse(Console.ReadLine(), out rightAnswerId) || rightAnswerId < 1 || rightAnswerId > 3);

            RightAnswer.AnswerId = rightAnswerId;
            RightAnswer.AnswerText = AnswerList[rightAnswerId - 1].AnswerText;

        }
    }
}
