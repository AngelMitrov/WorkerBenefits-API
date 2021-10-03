using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.WorkerBenefits.DataTransferObjects;
using WebApi.WorkerBenefits.Services.Interfaces;

namespace WebApi.WorkerBenefits.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class IndividualEnrolmentController : ControllerBase
    {
        private IIndividualEnrolmentService _individualEnrolmentService;

        public IndividualEnrolmentController(IIndividualEnrolmentService individualEnrolmentService)
        {
            _individualEnrolmentService = individualEnrolmentService;
        }

        [HttpGet("all")]
        public ActionResult<List<IndividualEnrolmentDTO>> GetAllIndividualEnrolments()
        {
            return _individualEnrolmentService.GetAllIndividualEnrolments();
        }

        [HttpGet("all/{id}")]
        public ActionResult<IndividualEnrolmentDTO> GetIndividualEnrolmentsById([FromRoute] int id)
        {
            return _individualEnrolmentService.GetIndividualEnrolmentById(id);
        }

        [HttpPut("update")]
        public IActionResult UpdateIndividualEnrolment([FromBody] IndividualEnrolmentDTO individualEnrolment)
        {
            _individualEnrolmentService.UpdateIndividualEnrolment(individualEnrolment);
            return StatusCode(StatusCodes.Status200OK, "Individual Enrolment Successfully Updated!");
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteIndividualEnrolmentById([FromRoute] int id)
        {
            _individualEnrolmentService.DeleteIndividualEnrolmentById(id);
            return StatusCode(StatusCodes.Status200OK, "Individual Enrolment Succesfully Deleted!");
        }

        [HttpPost("add")]
        public IActionResult AddIndividualEnrolment(IndividualEnrolmentDTO entity)
        {
            _individualEnrolmentService.AddNewIndividualEnrolment(entity);
            return StatusCode(StatusCodes.Status201Created, "Individual Enrolment Successfully Created!");
        }
    }
}
