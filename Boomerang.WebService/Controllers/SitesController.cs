using Boomerang.Dtos.Resources;
using Boomerang.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SitesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SitesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] SiteResources siteResources)
        {
            try
            {
                var sites = _unitOfWork.Sites.GetSites(siteResources);

                return Ok(sites);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    try
        //    {
        //        var site = _unitOfWork.Sites.Find(id);

        //        if (site == null)
        //            return NotFound();

        //        return Ok(site);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, ex.Message);
        //    }
        //}
    }
}