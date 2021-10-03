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
    public class BenefitController : ControllerBase
    {

        private IBenefitService _benefitService;

        public BenefitController(IBenefitService benefitService)
        {
            _benefitService = benefitService;
        }

        [HttpGet("all")]
        public ActionResult<List<BenefitDTO>> GetAllBenefits()
        {
            return _benefitService.GetAllBenefits();
        }

        [HttpGet("all/{id}")]
        public ActionResult<BenefitDTO> GetBenefitsById([FromRoute] int id)
        {
            return _benefitService.GetBenefitById(id);
        }

        [HttpPut("update")]
        public IActionResult UpdateBenefit([FromBody] BenefitDTO benefit)
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
        public IActionResult AddBenefit(BenefitDTO entity)
        {
            _benefitService.AddNewBenefit(entity);
            return StatusCode(StatusCodes.Status201Created, "Benefit Successfully Created!");
        }
    }
}
