using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeDDD.API.ApplicationServices;

namespace PracticeDDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public PersonController(LiveServices liveServices)
        {
            this.liveServices = liveServices;
        }
        [HttpPost]
        public async Task<IActionResult>AddPerson(
            CreatePersonCommand createPersonCommand)
        {
            await liveServices.HandleCommand(createPersonCommand);
            return Ok(createPersonCommand);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult>GetPerson(Guid id)
        {
            var response = await liveServices.GetPerson(id);
            return Ok(response);
        }
    }
}
