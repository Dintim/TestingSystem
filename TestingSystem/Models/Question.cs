using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem.Models
{
    public class Question
    {
        public string Description { get; set; }
        public Tuple<string, bool> Answers { get; set; }
        public int Score { get; set; }
    }
}
