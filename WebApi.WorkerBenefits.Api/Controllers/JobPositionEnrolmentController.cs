using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.WorkerBenefits.DataTransferObjects;
using WebApi.WorkerBenefits.Domain.Models;
using WebApi.WorkerBenefits.Services.Interfaces;

namespace WebApi.WorkerBenefits.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class JobPositionEnrolmentController : ControllerBase
    {
        private IJobPositionEnrolmentService _jobPositionEnrolmentService;

        public JobPositionEnrolmentController(IJobPositionEnrolmentService jobPositionEnrolmentService)
        {
            _jobPositionEnrolmentService = jobPositionEnrolmentService;
        }

        [HttpGet("all")]
        public ActionResult<List<JobPositionEnrolmentDTO>> GetAllJobPositionEnrolments()
        {
            return _jobPositionEnrolmentService.GetAllJobPositionEnrolments();
        }

        [HttpGet("all/{id}")]
        public ActionResult<JobPositionEnrolmentDTO> GetJobPositionEnrolmentById([FromRoute] int id)
        {
            return _jobPositionEnrolmentService.GetJobPositionEnrolmentById(id);
        }

        [HttpPost("add")]
        public IActionResult AddNewJobPositionEnrolment([FromBody] JobPositionEnrolmentDTO newJobPositionEnrolment)
        {
            _jobPositionEnrolmentService.AddNewJobPositionEnrolment(newJobPositionEnrolment);
            return StatusCode(StatusCodes.Status201Created, "Job Position Enrolment Successfully Created!");
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteJobPositionEnrolment([FromRoute] int id)
        {
            _jobPositionEnrolmentService.DeleteJobPositionEnrolmentById(id);
            return StatusCode(StatusCodes.Status200OK, "Job Position Enrolment Successfully Deleted!");
        }


        [HttpPut("update")]
        public IActionResult UpdateJobPositionEnrolment([FromBody] JobPositionEnrolmentDTO entity)
        {
            _jobPositionEnrolmentService.UpdateJobPositionEnrolment(entity);
            return StatusCode(StatusCodes.Status200OK, "Job Position Enrolemnt Successfully Updated!");
        }
    }
}
