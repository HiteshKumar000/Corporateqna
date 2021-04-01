using System;
using System.Collections.Generic;
using System.Text;

namespace Corporateqna.Models
{
    public class Question
    {
        public int UserId;

        public int Id;

        public int NoOfAnswers;

        public string question;

        public string Category;

        public string Date;

        public bool SolvedStatus;

    }
}
