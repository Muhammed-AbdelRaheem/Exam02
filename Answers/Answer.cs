﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Answers
{
    internal class Answer
    {

        public int Id { get; set; }
        public string? Text { get; set; }



        public Answer(int id, string? text)
        {
            Id = id;
            Text = text;
        }



    }
}
