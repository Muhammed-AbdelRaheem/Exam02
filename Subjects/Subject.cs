using Exam02.Exams;
using Exam02.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Subjects
{
    internal class Subject
    {
        public Subject(int id, string? name)
        {
            this.id = id;
            this.name = name;
        }

        public int id { get; set; }
        public string? name { get; set; }
        public Question[] questions { get; set; }

        public void CreateExam(Exam exam)
        {
            exam.AssociatedSubject = this;
            Console.WriteLine($"Exam created for subject: {name}");
        }


    }
}
