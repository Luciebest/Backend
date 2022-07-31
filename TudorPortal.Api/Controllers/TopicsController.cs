using Microsoft.AspNetCore.Mvc;
using Tudor_Vladimirescu_students__portal.Entities;
using TudorPortal.Business.Models;
using TudorPortal.Business.Services.IServices;

namespace TudorPortal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        private readonly ITopicsService _topicsService;

        public TopicsController(ITopicsService topicsService)
        {
            _topicsService = topicsService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_topicsService.GetTopics());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var top = _topicsService.GetTopics(id);
            if (top != null)
            {
                return Ok(top);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Add([FromBody] AddTopicsModel model)
        {
            return CreatedAtAction(null, _topicsService.AddTopic(model));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Topics top)
        {
            _topicsService.UpdateTopics(top);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _topicsService.DeleteTopics(id);
            return NoContent();
        }
    }
}
