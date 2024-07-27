using Exam02.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Questions
{
    public abstract class Question
    {
    

        public abstract string? HeaderOfTheQuestion { get; }
        public string? BodyOfTheQuestion { get;set; }
        public int Mark {  get; set; }
        public Answer[] AnswerList { get; set; } 
        public Answer RightAnswer { get; set; }

        public Answer UserAnswer { get; set; }

        public Question()
        {
            RightAnswer = new Answer();
            UserAnswer = new Answer();
        }



     


        public abstract void ShowQuestion();


        public override string ToString()
        {
            return $"{HeaderOfTheQuestion} \t Marks: {Mark} \n ------------ \n {BodyOfTheQuestion} \n";
        }
    }

}
