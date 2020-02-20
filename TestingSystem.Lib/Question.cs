﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.Lib
{
    public class Question
    {
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }
        public int Score { get; set; }
    }
}
