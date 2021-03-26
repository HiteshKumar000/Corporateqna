using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Corporateqna.ClientApp.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class UserController : Controller
    {
    private readonly IUserService User;
    public UserController(IUserService user)
    {
      this.User = user;
    }
    [HttpGet]
    public IEnumerable<User> GetUsers()
    {
      return User.GetUsers();

    }
  }
}
