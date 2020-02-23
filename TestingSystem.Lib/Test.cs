﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.Lib
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public int QuestionsCnt { get; set; }
        public List<Question> Questions { get; set; }        
    }
}
