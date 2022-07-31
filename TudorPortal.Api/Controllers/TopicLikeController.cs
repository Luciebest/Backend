using Microsoft.AspNetCore.Mvc;
using Tudor_Vladimirescu_students__portal.Entities;
using TudorPortal.Business.Models;
using TudorPortal.Business.Services.IServices;

namespace TudorPortal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicLikeController : ControllerBase
    {
        private readonly ITopicLikeService _topicLikeService;

        public TopicLikeController(ITopicLikeService topicLikeService)
        {
            _topicLikeService = topicLikeService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_topicLikeService.GetTopicLikes());
        }

        [HttpGet("topic{id}")]
        public IActionResult GetNumberofLikes_ByTopicId(int id)
        {
            var topL = _topicLikeService.GetNumberofLikesByTopicId(id);
            if (topL != null)
            {
                return Ok(topL);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Add([FromBody] AddTopicLikeModel model)
        {
            return CreatedAtAction(null, _topicLikeService.AddTopicLike(model));
        }


        [HttpPut]
        public IActionResult Update([FromBody] TopicLike topL)
        {
            _topicLikeService.UpdateTopicLike(topL);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _topicLikeService.DeleteTopicLike(id);
            return NoContent();
        }
    }
}
