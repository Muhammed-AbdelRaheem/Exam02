using Exam02.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Exams
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(DateTime timeOfExam, int numberOfQuestions, Subject? associatedSubject) : base(timeOfExam, numberOfQuestions, associatedSubject)
        {
        }

        public override void ShowExam()
        {

            Console.WriteLine($"Practical Exam for subject: {AssociatedSubject?.name}");
            Console.WriteLine($"Date and Time: {TimeOfExam}");
            Console.WriteLine($"Number of Questions: {NumberOfQuestions}");
            foreach (var question in AssociatedSubject!.questions)
            {
                question.ShowQuestion();
                Console.WriteLine($"Right Answer: {question?.RightAnswer?.AnswerText}");
            }


        }
    }
}
