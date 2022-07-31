using Microsoft.AspNetCore.Mvc;
using Tudor_Vladimirescu_students__portal.Entities;
using TudorPortal.Business.Models;
using TudorPortal.Business.Services.IServices;

namespace TudorPortal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_eventService.GetEvents());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var eve = _eventService.GetEvent(id);
            if (eve != null)
            {
                return Ok(eve);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Add([FromBody]AddEventModel model)
        {
            return CreatedAtAction(null, _eventService.AddEvent(model));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Event eve)
        {
            _eventService.UpdateEvent(eve);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _eventService.DeleteEvent(id);
            return NoContent();
        }
    }
}
