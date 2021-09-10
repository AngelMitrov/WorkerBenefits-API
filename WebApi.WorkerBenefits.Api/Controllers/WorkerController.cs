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
    public class WorkerController : ControllerBase
    {
        private IWorkerService _workerService;

        public WorkerController(IWorkerService workerService)
        {
            _workerService = workerService;
        }

        [HttpGet("all")]
        public ActionResult<List<Worker>> GetAllWorkers()
        {
            return _workerService.GetAllWorkers();
        }

        [HttpGet("all/{id}")]
        public ActionResult<Worker> GetWorkerById([FromRoute] int id)
        {
            return _workerService.GetWorkerById(id);
        }

        [HttpPost("add")]
        public IActionResult AddNewWorker([FromBody] Worker newWorker)
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
        public IActionResult UpdateWorker([FromBody] Worker entity)
        {
            _workerService.UpdateWorker(entity);
            return StatusCode(StatusCodes.Status200OK, "Worker Successfully Updated!");
        }
    }
}
