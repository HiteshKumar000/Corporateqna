using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corporateqna.ClientApp.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class AnswerController : Controller
    {
    private readonly IAnswerService Answer;
    public AnswerController(IAnswerService answer)
    {
      this.Answer = answer;
    }
    [HttpGet]
    public IEnumerable<Answer> GetAnswers()
    {
      return Answer.GetAnswers();

    }
  }
}
