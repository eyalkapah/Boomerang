using Boomerang.Dtos;
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
    public class WordsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public WordsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetWords()
        {
            try
            {
                var words = _unitOfWork.Words.GetWords();

                return Ok(words);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}", Name = "GetWord")]
        public IActionResult GetWord(int id)
        {
            try
            {
                var word = _unitOfWork.Words.GetWord(id);

                return Ok(word);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public IActionResult CreateWord([FromBody] WordForCreationDto wordForCreationDto)
        {
            try
            {
                if (wordForCreationDto == null)
                    return BadRequest();

                if (!ModelState.IsValid)
                {
                    return new UnprocessableEntityObjectResult(ModelState);
                }

                var word = _unitOfWork.Words.CreateWord(wordForCreationDto);

                if (!_unitOfWork.Save())
                    throw new Exception("Failed to save word.");

                var dto = _unitOfWork.Mapper.Map<WordDto>(word);

                return CreatedAtRoute("GetWord", new { id = dto.Id }, dto);
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
        public IActionResult DeleteWord(int id)
        {
            try
            {
                var word = _unitOfWork.Words.Find(id);

                if (word == null)
                    return NotFound();

                _unitOfWork.Words.Delete(word);

                if (!_unitOfWork.Save())
                    throw new Exception("Failed to delete word.");

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateWord(int id, [FromBody] WordForUpdateDto wordForUpdateDto)
        {
            try
            {
                if (wordForUpdateDto == null)
                    return BadRequest();

                if (!ModelState.IsValid)
                {
                    return new UnprocessableEntityObjectResult(ModelState);
                }

                var word = _unitOfWork.Words.UpdateWord(id, wordForUpdateDto);

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