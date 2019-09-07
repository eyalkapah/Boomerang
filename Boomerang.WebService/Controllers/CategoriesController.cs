using Boomerang.Dtos.Resources;
using Boomerang.Services;
using Boomerang.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Boomerang.WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetCategories([FromQuery] CategoryResources resources)
        {
            try
            {
                var categories = _unitOfWork.Categories.GetCategories(resources);

                return Ok(categories);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}