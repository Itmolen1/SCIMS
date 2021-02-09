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
    public class DesignationInformationController : ControllerBase
    {
        private readonly IDesignationRepository _repository;

        public DesignationInformationController(IDesignationRepository designationRepository)
        {
            this._repository = designationRepository;
        }
        
        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> All()
        {
            try
            {
                var designations = await _repository.All();
                return Ok(designations);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add(DesignationInformation designationInformation)
        {
            try
            {
                var designation = await _repository.Insert(designationInformation);
                return Ok(designation);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        [Route("ById")]
        public async Task<IActionResult> GetById(DesignationInformation designationInformation)
        {
            try
            {
                var designation = await _repository.GetById(designationInformation.Id);
                return Ok(designation);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Update")]
        public async Task<IActionResult> Update(DesignationInformation designationInformation)
        {
            try
            {
                var designation = await _repository.Update(designationInformation);
                return Ok(designation);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                var designation = await _repository.Delete(Id);
                return Ok(designation);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
    }
}