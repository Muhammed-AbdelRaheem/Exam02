using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Questions
{
    internal class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string? headerOfTheQuestion, string? bodyOfTheQuestion, int mark) : base(headerOfTheQuestion, bodyOfTheQuestion, mark)
        {
        }

        public override void StartQuestion()
        {
            Console.WriteLine($"{HeaderOfTheQuestion} \n {BodyOfTheQuestion} \n {Mark}");
        }
    }
}
