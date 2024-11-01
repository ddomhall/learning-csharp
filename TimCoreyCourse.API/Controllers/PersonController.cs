using Microsoft.AspNetCore.Mvc;

namespace TimCoreyCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public string Get(string name, int age)
        {
            return $"hi {name}, you are {age}";
        }

        [HttpPost]
        public string Post(string name, int age)
        {
            return $"hi {name}, you are {age}";
        }
    }
}
