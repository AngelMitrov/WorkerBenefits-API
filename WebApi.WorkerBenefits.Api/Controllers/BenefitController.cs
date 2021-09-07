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

namespace WebApi.WorkerBenefits.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BenefitController : ControllerBase
    {
        private IRepository<Benefit> _benefitRepository;

        public BenefitController(BenefitEntityRepository benefitRepository)
        {
            _benefitRepository = benefitRepository;
        }

        Benefit newBenefit = new Benefit()
        {
            Id = 1,
            BenefitType = BenefitType.Individual,
            BenefitTypeId = 2,
            Name = "Angel",
            CreatedOn = DateTime.UtcNow,
            UpdatedOn = DateTime.UtcNow
        };

        [HttpGet("all")]
        public ActionResult<List<Benefit>> GetAllBenefits()
        {
            _benefitRepository.Insert(newBenefit);
            List<Benefit> benefits = _benefitRepository.GetAll();

            if (benefits.Count() == 0)
            {
                return StatusCode(StatusCodes.Status404NotFound, "There isnt any benefits");
            }
            return Ok(benefits);
        }


        [HttpPost("add")]
        public ActionResult AddBenefit(Benefit entity)
        {
            _benefitRepository.Insert(entity);
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
