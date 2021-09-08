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
            List<Benefit> benefits = _benefitService.GetAllBenefits();

            if (benefits.Count() == 0)
            {
                return StatusCode(StatusCodes.Status404NotFound, "There isnt any benefits");
            }
            return Ok(benefits);
        }

        [HttpGet("all/{id}")]
        public ActionResult<Benefit> GetBenefitsById([FromRoute] int id)
        {
            Benefit benefit = _benefitService.GetBenefitById(id);

            if(benefit == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, "A benefit with that ID does not exist");
            }
            return Ok(benefit);
        }

        [HttpPost("update")]
        public void UpdateBenefit([FromBody] Benefit entity)
        {
            _benefitService.UpdateBenefit(entity);
        }

        [HttpDelete("delete/{id}")]
        public ActionResult DeleteBenefitById([FromRoute] int id)
        {
            _benefitService.DeleteBenefitById(id);
            return StatusCode(StatusCodes.Status200OK, "Benefit Deleted Succesfully");
        }


        [HttpPost("add")]
        public ActionResult AddBenefit(Benefit entity)
        {
            _benefitService.AddNewBenefit(entity);
            return StatusCode(StatusCodes.Status201Created, entity);
        }
    }
}
