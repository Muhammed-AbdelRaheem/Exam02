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
        public MCQQuestion(string? headerOfTheQuestion, string? bodyOfTheQuestion, int mark) : base(headerOfTheQuestion, bodyOfTheQuestion, mark)
        {

        }

        public override void StartQuestion()
        {

            Console.WriteLine($"{HeaderOfTheQuestion} \n {BodyOfTheQuestion} \n {Mark}");

       

        }
    }
}
