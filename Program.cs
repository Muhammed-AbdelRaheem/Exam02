using Exam02.Answers;
using Exam02.Exams;
using Exam02.Questions;
using Exam02.Subjects;

namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mathSubject = new Subject(1, "Mathematics");

            // Create questions

            int[]arr01 = {1,2,4 };
            var q1 = new TrueOrFalseQuestion("Q1", "Is 2+2 equal to 4?", 1);
            q1.AnswerList.Add(new Answer(1, "True"));
            q1.AnswerList.Add(new Answer(2, "False"));
            q1.CorrectAnswer = q1.AnswerList[0];

            var q2 = new MCQQuestion("Q2", "What is the capital of France?", 2);
            q2.AnswerList.Add(new Answer(1, "Paris"));
            q2.AnswerList.Add(new Answer(2, "London"));
            q2.AnswerList.Add(new Answer(3, "Berlin"));
            q2.RightAnswer = q2.AnswerList[0];

            mathSubject.questions.Add(q1);
            mathSubject.questions.Add(q2);

            // Create and show final exam for the subject
            var finalExam = new FinalExam(DateTime.Now, 2, mathSubject);
            mathSubject.CreateExam(finalExam);
            finalExam.ShowExam();

            // Create and show practical exam for the subject
            var practicalExam = new PracticalExam(DateTime.Now, 2, mathSubject);
            mathSubject.CreateExam(practicalExam);
            practicalExam.ShowExam();
        }
    }
}
