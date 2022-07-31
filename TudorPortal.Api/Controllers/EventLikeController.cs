using Microsoft.AspNetCore.Mvc;
using Tudor_Vladimirescu_students__portal.Entities;
using TudorPortal.Business.Models;
using TudorPortal.Business.Services.IServices;

namespace TudorPortal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventLikeController : ControllerBase
    {
        private readonly IEventLikeService _eventLikeService; 

        public EventLikeController(IEventLikeService eventLikeService)
        {
            _eventLikeService = eventLikeService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_eventLikeService.GetEventLikes());
        }

        [HttpPost]
        public IActionResult Add([FromBody] AddEventLikeModel model)
        {
            return CreatedAtAction(null, _eventLikeService.AddEventLike(model));
        }

        [HttpGet("event/{id}")]
        public IActionResult GetNumberofLikes_ByEventId(int id)
        {
            var evel = _eventLikeService.GetNumberofLikesByEventId(id);
            if (evel != null)
            {
                return Ok(evel);
            }
            return NotFound();
        }

        [HttpPut]
        public IActionResult Update([FromBody] EventLike evel)
        {
            _eventLikeService.UpdateEventLike(evel);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _eventLikeService.DeleteEventLike(id);
            return NoContent();
        }
    }
}
