using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.WorkerBenefits.Domain.Models;
using WebApi.WorkerBenefits.Services.Interfaces;

namespace WebApi.WorkerBenefits.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologyTypeEnrolmentController : ControllerBase
    {
        private ITechnologyTypeEnrolmentService _technologyTypeEnrolmentService;

        public TechnologyTypeEnrolmentController(ITechnologyTypeEnrolmentService technologyTypeEnrolmentService)
        {
            _technologyTypeEnrolmentService = technologyTypeEnrolmentService;
        }

        [HttpGet("all")]
        public ActionResult<List<TechnologyTypeEnrolment>> GetAllTechnologyTypeEnrolments()
        {
            return _technologyTypeEnrolmentService.GetAllTechnologyTypeEnrolments();
        }

        [HttpGet("all/{id}")]
        public ActionResult<TechnologyTypeEnrolment> GetTechnologyTypeEnrolmentById([FromRoute] int id)
        {
            return _technologyTypeEnrolmentService.GetTechnologyTypeEnrolmentById(id);
        }

        [HttpPost("add")]
        public IActionResult AddNewTechnologyTypeEnrolment([FromBody] TechnologyTypeEnrolment newTechnologyTypeEnrolment)
        {
            _technologyTypeEnrolmentService.AddNewTechnologyTypeEnrolment(newTechnologyTypeEnrolment);
            return StatusCode(StatusCodes.Status201Created, "Technology Type Enrolment Successfully Created!");
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteTechnologyTypeEnrolment([FromRoute] int id)
        {
            _technologyTypeEnrolmentService.DeleteTechnologyTypeEnrolmentById(id);
            return StatusCode(StatusCodes.Status200OK, "Technology Type Enrolment Successfully Deleted!");
        }

        [HttpPut("update")]
        public IActionResult UpdateTechnologyTypeEnrolment([FromBody] TechnologyTypeEnrolment entity)
        {
            _technologyTypeEnrolmentService.UpdateTechnologyTypeEnrolment(entity);
            return StatusCode(StatusCodes.Status200OK, "Technology Type Enrolment Successfully Updated!");
        }
    }
}
