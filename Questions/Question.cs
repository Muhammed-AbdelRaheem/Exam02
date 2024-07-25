using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Questions
{
    internal abstract class Question
    {

        public string? HeaderOfTheQuestion { get; set; }
        public string? BodyOfTheQuestion { get;set; }
        public int Mark {  get; set; }


        public Question(string? headerOfTheQuestion, string? bodyOfTheQuestion, int mark)
        {
            HeaderOfTheQuestion = headerOfTheQuestion;
            BodyOfTheQuestion = bodyOfTheQuestion;
            Mark = mark;
        }




        public abstract void StartQuestion();


      


    }

}
