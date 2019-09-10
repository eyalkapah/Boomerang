using Boomerang.Dtos;
using Boomerang.Dtos.Resources;
using Boomerang.Models.Models;
using Boomerang.Services;
using Boomerang.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplexWordsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ComplexWordsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet(Name = "GetComplexWords")]
        public IActionResult GetComplexWords([FromQuery] ComplexWordResources resources)
        {
            try
            {
                var complexWords = _unitOfWork.ComplexWords.GetComplexWords(resources);

                return Ok(complexWords);
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

        [HttpPost]
        public IActionResult CreateComplexWord([FromBody] ComplexWordForCreationDto complexWordForCreationDto)
        {
            try
            {
                if (complexWordForCreationDto == null)
                    return BadRequest();

                if (!ModelState.IsValid)
                {
                    return new UnprocessableEntityObjectResult(ModelState);
                }

                var complexWord = _unitOfWork.ComplexWords.CreateWord(complexWordForCreationDto);

                if (!_unitOfWork.Save())
                    throw new Exception("Failed to save word.");

                var dto = _unitOfWork.Mapper.Map<ComplexWordDto>(complexWord);

                return CreatedAtRoute("GetComplexWords", new ComplexWordResources { Id = dto.Id }, dto);
            }
            catch (CreationException ex)
            {
                return new UnprocessableEntityObjectResult(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}