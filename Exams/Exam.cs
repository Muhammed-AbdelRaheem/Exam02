using Exam02.Questions;
using Exam02.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Exams
{
    public abstract class Exam
    {



        public int TimeOfExam { get; set; }
        public int NumberOfQuestions {  get; set; }



        public Exam(int timeOfExam, int numberOfQuestions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
        }



        public Question[] ListOfQuestions { get; set; }

        public abstract void ShowExam();

        public abstract void CreateQuestion();


    }
}
