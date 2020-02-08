using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace WebApiUsuarios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {
                "chocolate",
                "bombom",
                "bolo",
                "panetone"
            };
        }

        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id) =>
            "chocolate";
    }
}
