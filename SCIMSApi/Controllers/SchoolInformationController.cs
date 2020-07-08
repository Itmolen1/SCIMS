using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SCIMSApi.Interfaces;
using SCIMSApi.Models;

namespace SCIMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolInformationController : ControllerBase
    {
        private readonly ISchoolRepository _repository;

        public SchoolInformationController(ISchoolRepository schoolRepository)
        {
            this._repository = schoolRepository;
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> All()
        {
            try
            {
                var schools = await _repository.All();
                return Ok(schools);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Insert(SchoolInformation schoolInformation)
        {
            try

            {
               var scholl = await _repository.Insert(schoolInformation);
               return Ok(scholl);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        [Route("ById")]
        public async Task<IActionResult> GetById(int Id)
        {
            try
            {
              var school = await _repository.GetById(Id);
              return Ok(school);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Update")]
        public async Task<IActionResult> Update(SchoolInformation schoolInformation)
        {
            var school = await _repository.Update(schoolInformation);
            return Ok(school);
        }
    }
}