using Microsoft.AspNetCore.Mvc;
using Tudor_Vladimirescu_students__portal.Entities;
using TudorPortal.Business.Models;
using TudorPortal.Business.Services.IServices;

namespace TudorPortal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentservice;

        public CommentController(ICommentService commentservice)
        {
            _commentservice = commentservice;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_commentservice.GetComments());
        }

        [HttpGet("topics{id}")]
        public IActionResult GetById(int id)
        {
            var comm = _commentservice.GetCommentByTopictId(id);
            if (comm != null)
            {
                return Ok(comm);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Add([FromBody] AddCommentModel model)
        {
            return CreatedAtAction(null, _commentservice.AddComment(model));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Comment comm)
        {
            _commentservice.UpdateComment(comm);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _commentservice.DeleteComment(id);
            return NoContent();
        }
    }
}
