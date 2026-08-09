using _3_July.Models;
using _3_July.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3_July.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatchController : ControllerBase
    {
        private readonly IBatchService _service;
        public BatchController(IBatchService service) { 
            _service = service; 
        }
        [HttpGet]
        public IActionResult GetCourses()
        {
            var batches = _service.GetBatch();
            return Ok(batches);

        }
        [HttpPut("{id}")]
        public ActionResult UpdateBatch(int id,Batch batch)
        {
            var result=_service.UpdateBatch(id,batch);
            if (result == null){
                return BadRequest("No such batch exists");
            }
            return Ok(result);  
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteBatch(int id)
        {
            bool t=_service.DeleteBatch(id);
            if (t)
            {
                return Ok("Found and delted");
            }
            return BadRequest("Not found");
        }  

    }
}
