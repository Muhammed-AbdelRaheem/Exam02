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
        public TrueOrFalseQuestion(string? Header, string? Body, int mark, Answer[]? answerList, Answer? rightAnswer) : base(Header, Body, mark, answerList, rightAnswer)
        {
        }



        public override void ShowQuestion()
        {
            Console.WriteLine($"{HeaderOfTheQuestion} - {BodyOfTheQuestion}");

            foreach (var answer in AnswerList)
            {
                Console.WriteLine($"{answer.AnswerId}: {answer.AnswerText}");
            }

            Console.WriteLine($"Correct Answer: {RightAnswer?.AnswerText}");
        }



    }
}
