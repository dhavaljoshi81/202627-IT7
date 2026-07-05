using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPIDemoCS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataManagerController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetData()
        {
            // Sample data to return
            var data = new
            {
                Id = 1,
                Name = "Sample Data",
                Description = "This is a sample data object."
            };

            return Ok(data);
        }
    }
}
