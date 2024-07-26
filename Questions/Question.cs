using Exam02.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Questions
{
    internal abstract class Question:ICloneable, IComparable<Question>
    {

        public string? HeaderOfTheQuestion { get; set; }
        public string? BodyOfTheQuestion { get;set; }
        public int Mark {  get; set; }
        public Answer[]? AnswerList { get; set; } = default;
        public Answer? RightAnswer { get; set; }



        protected Question(string? Header, string? Body, int mark, Answer[]? answerList, Answer? rightAnswer)
        {
            HeaderOfTheQuestion = Header;
            BodyOfTheQuestion = Body;
            Mark = mark;
            AnswerList = answerList;
            RightAnswer = rightAnswer;
        }


        public override string ToString()
        {
            return $"{HeaderOfTheQuestion} - {BodyOfTheQuestion}";
        }


        public abstract void ShowQuestion();

        public object Clone()
        {
            return Clone();
        }

        public int CompareTo(Question? other)
        {
            return string.Compare(HeaderOfTheQuestion, other?.HeaderOfTheQuestion);
        }
    }

}
