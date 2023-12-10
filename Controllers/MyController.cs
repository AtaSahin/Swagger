using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Swagger.Web.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class MyController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<string> GetItems()
        {
            return new List<string> { "Item 1", "Item 2", "Item 3" };
        }
    }
}
