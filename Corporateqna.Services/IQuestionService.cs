using Corporateqna.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Corporateqna.Services
{
    public interface IQuestionService
    {
        void AddQuestion();

        IEnumerable<Question> GetQuestions();
    }
}
