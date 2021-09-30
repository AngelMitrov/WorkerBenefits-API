using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.WorkerBenefits.DataAccess;
using WebApi.WorkerBenefits.DataAccess.EntityRepositories;
using WebApi.WorkerBenefits.Domain.Enums;
using WebApi.WorkerBenefits.Domain.Models;
using WebApi.WorkerBenefits.Services;

namespace WebApi.WorkerBenefits.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BenefitController : ControllerBase
    {

        private IBenefitService _benefitService;

        public BenefitController(IBenefitService benefitService)
        {
            _benefitService = benefitService;
        }

        [HttpGet("all")]
        public ActionResult<List<Benefit>> GetAllBenefits()
        {
            return _benefitService.GetAllBenefits();
        }

        [HttpGet("all/{id}")]
        public ActionResult<Benefit> GetBenefitsById([FromRoute] int id)
        {
            return _benefitService.GetBenefitById(id);
        }

        [HttpPut("update")]
        public IActionResult UpdateBenefit([FromBody] Benefit benefit)
        {
            _benefitService.UpdateBenefit(benefit);
            return StatusCode(StatusCodes.Status200OK, "Benefit Successfully Updated!");
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteBenefitById([FromRoute] int id)
        {
            _benefitService.DeleteBenefitById(id);
            return StatusCode(StatusCodes.Status200OK, "Benefit Succesfully Deleted!");
        }


        [HttpPost("add")]
        public IActionResult AddBenefit(Benefit entity)
        {
            _benefitService.AddNewBenefit(entity);
            return StatusCode(StatusCodes.Status201Created, "Benefit Successfully Created!");
        }
    }
}
