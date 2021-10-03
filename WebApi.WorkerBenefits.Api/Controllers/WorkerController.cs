using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.WorkerBenefits.DataTransferObjects;
using WebApi.WorkerBenefits.Services.Interfaces;

namespace WebApi.WorkerBenefits.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private IWorkerService _workerService;

        public WorkerController(IWorkerService workerService)
        {
            _workerService = workerService;
        }

        [HttpGet("all")]
        public ActionResult<List<WorkerDTO>> GetAllWorkers()
        {
            return _workerService.GetAllWorkers();
        }

        [HttpGet("all/{id}")]
        public ActionResult<WorkerDTO> GetWorkerById([FromRoute] int id)
        {
            return _workerService.GetWorkerById(id);
        }

        [AllowAnonymous]
        [HttpPost("add")]
        public IActionResult AddNewWorker([FromBody] WorkerDTO newWorker)
        {
            _workerService.AddNewWorker(newWorker);
            return StatusCode(StatusCodes.Status201Created, "Worker Successfully Created!");
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteWorker([FromRoute] int id)
        {
            _workerService.DeleteWorkerById(id);
            return StatusCode(StatusCodes.Status200OK, "Worker Successfully Deleted!");
        }

        [HttpPut("update")]
        public IActionResult UpdateWorker([FromBody] WorkerDTO entity)
        {
            _workerService.UpdateWorker(entity);
            return StatusCode(StatusCodes.Status200OK, "Worker Successfully Updated!");
        }

        [HttpGet("workerbenefits/{id}")]
        public ActionResult<BenefitsForWorkerDTO> GetWorkerBenefitsById(int id)
        {
            return _workerService.GetAllBenefitsForWorkerById(id);
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public ActionResult<string> LoginWorker(LoginDTO loginDto)
        {
            string token = _workerService.GetLoginToken(loginDto);
            if (string.IsNullOrEmpty(token))
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
            return token;
        }
        
    }
}
