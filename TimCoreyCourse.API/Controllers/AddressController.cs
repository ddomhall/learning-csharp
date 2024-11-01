using Microsoft.AspNetCore.Mvc;

namespace TimCoreyCourse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        [HttpPost]
        public string Post(int houseNumber, string postCode)
        {
            return $"you live at number {houseNumber}, {postCode}";
        }
    }
}
