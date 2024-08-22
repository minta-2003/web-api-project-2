using MyWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        private static DataModel data = new DataModel();

        [HttpGet]
        public ActionResult<DataModel> Get()
        {
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post([FromBody] DataModel newData)
        {
            data = newData;
            return Ok(data);
        }
    }
}
