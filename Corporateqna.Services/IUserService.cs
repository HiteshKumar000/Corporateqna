using Corporateqna.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Corporateqna.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
    }
}
