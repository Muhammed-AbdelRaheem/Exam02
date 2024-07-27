using Exam02.Questions;
using Exam02.Subjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Exams
{
    public class FinalExam : Exam
    {
        public FinalExam(int timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
        {
        }





        public override void CreateQuestion()
        {

            ListOfQuestions = new Question[NumberOfQuestions];

            for (int i = 0; i < ListOfQuestions.Length; i++)
            {

                int Choice;
                do
                {
                    Console.WriteLine("Please Enter Type Of Question  (1 For MCQ | 2 For True | False ) :");

                } while (!int.TryParse(Console.ReadLine(), out Choice) || Choice < 1 || Choice > 2);

                Console.Clear();

                if (Choice == 1)
                {
                    ListOfQuestions[i] = new MCQQuestion();
                    ListOfQuestions[i].ShowQuestion();



                }

                if (Choice == 2)
                {
                    ListOfQuestions[i] = new TrueOrFalseQuestion();
                    ListOfQuestions[i].ShowQuestion();

                }


            }


        }




        public override void ShowExam()
        {

            int TotalMarks = 0, Mark = 0;

            foreach (var Qs in ListOfQuestions)
            {
                Console.WriteLine(Qs);


                for (int i = 0; i < Qs.AnswerList.Length; i++)
                {

                    Console.WriteLine(Qs.AnswerList[i]);
                }

                Console.WriteLine("-----------------------------");


                int UserAnswerID;


                if (Qs.HeaderOfTheQuestion == "MCQ Question")
                {

                    do
                    {
                        Console.WriteLine("enter number of your answer:");
                    }
                    while (!int.TryParse(Console.ReadLine(), out UserAnswerID) || UserAnswerID < 1 || UserAnswerID > 3);


                    Qs.UserAnswer.AnswerId = UserAnswerID;
                    Qs.UserAnswer.AnswerText = Qs.AnswerList[UserAnswerID - 1].AnswerText;

                    Console.WriteLine("------------------------------");

                }

                else if (Qs.HeaderOfTheQuestion == "True || False Question")
                {
                    do
                    {
                        Console.WriteLine("enter number of your answer:");

                    }
                    while (!int.TryParse(Console.ReadLine(), out UserAnswerID) || UserAnswerID < 1 || UserAnswerID > 2);
                    Qs.UserAnswer.AnswerId = UserAnswerID;
                    Qs.UserAnswer.AnswerText = Qs.AnswerList[UserAnswerID - 1].AnswerText;
                    Console.WriteLine("------------------------------");

                }


                Console.WriteLine("------------------------------");
                Console.Clear();
                TotalMarks += Qs.Mark;

            }


            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                if (ListOfQuestions[i].RightAnswer.AnswerId == ListOfQuestions[i].UserAnswer.AnswerId)
                {
                    Mark += ListOfQuestions[i].Mark;
                }

                Console.WriteLine($"Question({i + 1}): {ListOfQuestions[i].BodyOfTheQuestion}");
                Console.WriteLine($"Your Answer: {ListOfQuestions[i].UserAnswer.AnswerText}");
                Console.WriteLine($"Right Answer: {ListOfQuestions[i].RightAnswer.AnswerText}");
            }

            Console.WriteLine($"your grade is {Mark}/{TotalMarks}");



        }
    }
}
