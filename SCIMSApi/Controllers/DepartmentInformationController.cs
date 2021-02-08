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
    public class DepartmentInformationController : ControllerBase
    {
        private readonly IDepartmentRepository _repository;

        public DepartmentInformationController(IDepartmentRepository departmentInformation)
        {
            this._repository = departmentInformation;
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> All()
        {
            try
            {
                var departments = await _repository.All();
                return Ok(departments);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add(DepartmentInformation departmentInformation)
        {
            try
            {
                var department = await _repository.Insert(departmentInformation);
                return Ok(department);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        [HttpGet]
        [Route("ById")]
        public async Task<IActionResult> GetById(DepartmentInformation departmentInformation)
        {
            try
            {
                var department = await _repository.GetById(departmentInformation.Id);
                return Ok(department);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Update")]
        public async Task<IActionResult> Update(DepartmentInformation departmentInformation)
        {
            try
            {
                var department = await _repository.Update(departmentInformation);
                return Ok(department);
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
                var department = await _repository.Delete(Id);
                return Ok(department);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}