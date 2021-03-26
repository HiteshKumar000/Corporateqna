using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corporateqna.ClientApp.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class QuestionController : Controller
    {
    private readonly IQuestionService Question;
    public QuestionController(IQuestionService question)
    {
      this.Question = question;
    }
    [HttpGet]
    public IEnumerable<Question> GetQuestions()
    {
      return Question.GetQuestions();

    }
  }
}
