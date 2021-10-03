using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.WorkerBenefits.DataTransferObjects;
using WebApi.WorkerBenefits.Services;

namespace WebApi.WorkerBenefits.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class JobPositionController : ControllerBase
    {
        private IJobPositionService _jobPositionService;

        public JobPositionController(IJobPositionService jobPositionService)
        {
            _jobPositionService = jobPositionService;
        }


        [HttpGet("all")]
        public ActionResult<List<JobPositionDTO>> GetAllJobPositions()
        {
            return _jobPositionService.GetAllJobPositions();
        }


        [HttpGet("all/{id}")]
        public ActionResult<JobPositionDTO> GetJobPositionById([FromRoute] int id)
        {
            return _jobPositionService.GetJobPositionById(id);

        }


        [HttpPost("add")]
        public IActionResult AddNewJobPosition([FromBody] JobPositionDTO newJobPosition)
        {
            _jobPositionService.AddNewJobPosition(newJobPosition);
            return StatusCode(StatusCodes.Status201Created, "Job Position Successfully Created!");
        }


        [HttpDelete("delete/{id}")]
        public IActionResult DeleteJobPosition([FromRoute] int id)
        {
            _jobPositionService.DeleteJobPositionById(id);
            return StatusCode(StatusCodes.Status200OK, "Job Position Successfully Deleted!");
        }


        [HttpPut("update")]
        public IActionResult UpdateJobPosition([FromBody] JobPositionDTO entity)
        {
            _jobPositionService.UpdateJobPosition(entity);
            return StatusCode(StatusCodes.Status200OK, "Job Position Successfully Updated!");
        }
    }
}
