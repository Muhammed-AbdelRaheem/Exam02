using Exam02.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Questions
{
    internal class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion()
        {
            AnswerList = new Answer[2];

            AnswerList[0] = new Answer(1,"True");
            AnswerList[1] = new Answer(1, "False");


        }

        public override string? HeaderOfTheQuestion { get => "True || False Question"; }



        public override void ShowQuestion()
        {
            // Header
            Console.WriteLine(HeaderOfTheQuestion);

            // Body
            Console.WriteLine("Please Enter Question Body");
            BodyOfTheQuestion = Console.ReadLine();

            //Mark

            int Marks;

            do
            {
                Console.WriteLine("enter marks of question");


            } while (!int.TryParse(Console.ReadLine(), out Marks ) || Marks<0);


            Mark = Marks;


            int rightAnswerID;

            do
            {
                Console.WriteLine("Please Enter The Right Answer id (1 For True | 2 For False) :");
            }
            while (!int.TryParse(Console.ReadLine(),out rightAnswerID) || rightAnswerID<1 || rightAnswerID>2 );

            RightAnswer.AnswerId = rightAnswerID;
            RightAnswer.AnswerText = AnswerList[rightAnswerID - 1].AnswerText;


            Console.Clear();

        }



    }
}
