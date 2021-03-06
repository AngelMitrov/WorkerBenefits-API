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
    public class TechnologyTypeController : ControllerBase
    {
        private ITechnologyTypeService _technologyTypeService;

        public TechnologyTypeController(ITechnologyTypeService technologyTypeService)
        {
            _technologyTypeService = technologyTypeService;
        }

        [HttpGet("all")]
        public ActionResult<List<TechnologyTypeDTO>> GetAllTechnologyTypes()
        {
            return _technologyTypeService.GetAllTechnologyTypes();
        }

        [HttpGet("all/{id}")]
        public ActionResult<TechnologyTypeDTO> GetTechnologyTypeById([FromRoute] int id)
        {
            return _technologyTypeService.GetTechnologyTypeById(id);
        }

        [HttpPost("add")]
        public IActionResult AddNewTechnologyType([FromBody] TechnologyTypeDTO newTechnologyType)
        {
            _technologyTypeService.AddNewTechnologyType(newTechnologyType);
            return StatusCode(StatusCodes.Status201Created, "Technology Type Successfully Created!");
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteTechnologyType([FromRoute] int id)
        {
            _technologyTypeService.DeleteTechnologyTypeById(id);
            return StatusCode(StatusCodes.Status200OK, "Technology Type Successfully Deleted!");
        }

        [HttpPut("update")]
        public IActionResult UpdateTechnologyType([FromBody] TechnologyTypeDTO entity)
        {
            _technologyTypeService.UpdateTechnologyType(entity);
            return StatusCode(StatusCodes.Status200OK, "Technology Type Successfully Updated!");
        }
    }
}
