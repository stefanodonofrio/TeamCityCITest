using Microsoft.AspNetCore.Mvc;
using TeamCityCITest.Api;

namespace TeamCityTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StefanoController : ControllerBase
    {
        public StefanoController(IValues values)
        {
            Values = values;
        }

        public IValues Values { get; }

        public JsonResult Get()
        {
            return new JsonResult(Values.Get());
        }
    }
}
