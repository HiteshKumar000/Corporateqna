using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Question
    {
        public int UserId;

        public int Id;

        public int NoOfAnswers;

        public string Question;

        public string Category;

        public DateTime Date;

        public bool SolvedStatus;

    }
}
