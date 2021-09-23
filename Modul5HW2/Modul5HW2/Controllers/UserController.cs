using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modul5HW2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modul5HW2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("register")]
        public string Register([FromForm]User user)
        {
            if (string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Password))
            {
                return "Одно из полей не было заполнено";
            }
            else
            {
                return $"{user.Name} зарегестрирован";
            }
        }
    }
}
