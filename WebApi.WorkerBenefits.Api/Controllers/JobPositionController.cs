using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.WorkerBenefits.DataAccess;
using WebApi.WorkerBenefits.Domain.Models;

namespace WebApi.WorkerBenefits.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPositionController : ControllerBase
    {
        private IRepository<JobPosition> _jobPositionRepository;

        public JobPositionController(IRepository<JobPosition> jobPositionRepository)
        {
            _jobPositionRepository = jobPositionRepository;
        }

        [HttpGet("all")]
        public ActionResult GetAllJobPositions()
        {
            List<JobPosition> jobPositions = _jobPositionRepository.GetAll();

            if (jobPositions.Count() == 0)
            {
                return StatusCode(StatusCodes.Status404NotFound, "There isnt any job positions");
            }
            return Ok(jobPositions);
        }
    }
}
