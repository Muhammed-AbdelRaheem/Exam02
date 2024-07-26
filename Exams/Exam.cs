using Exam02.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Exams
{
    internal abstract class Exam
    {

        public DateTime TimeOfExam { get; set; }
        public int NumberOfQuestions {  get; set; }
        public Subject? AssociatedSubject { get; set; }

        public Exam(DateTime timeOfExam, int numberOfQuestions, Subject? associatedSubject)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
            AssociatedSubject = associatedSubject;
        }



        public abstract void ShowExam();

    }
}
