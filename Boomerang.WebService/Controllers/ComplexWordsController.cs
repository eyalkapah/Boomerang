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

        [HttpDelete("{id}")]
        public IActionResult DeleteComplexWord(int id)
        {
            try
            {
                var complexWord = _unitOfWork.ComplexWords.Find(id);

                if (complexWord == null)
                    return NotFound();

                _unitOfWork.ComplexWords.Delete(complexWord);

                if (!_unitOfWork.Save())
                    throw new Exception("Failed to delete complex word.");

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
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

        [HttpPut("{id}")]
        public IActionResult UpdateComplexWord(int id, [FromBody] ComplexWordForUpdateDto complexWordForUpdateDto)
        {
            try
            {
                if (complexWordForUpdateDto == null)
                    return BadRequest();

                if (!ModelState.IsValid)
                {
                    return new UnprocessableEntityObjectResult(ModelState);
                }

                var word = _unitOfWork.Words.UpdateWord(id, complexWordForUpdateDto);

                if (!_unitOfWork.Save())
                    throw new Exception("Failed to save word.");

                return NoContent();
            }
            catch (DuplicateNameException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}