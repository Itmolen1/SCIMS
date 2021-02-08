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
    public class EmployeeInformationController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeInformationController(IEmployeeRepository employeeRepository)
        {
            this._repository = employeeRepository;
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> All()
        {
            try
            {
                var employeeList = await _repository.All();
                return Ok(employeeList);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add(EmployeeInformation employeeInformation)
        {
            try
            {
                var employee = await _repository.Insert(employeeInformation);
                return Ok(employee);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        [Route("ById")]
        public async Task<IActionResult> GetById(EmployeeInformation employeeInformation)
        {
            try
            {
                var employee = await _repository.GetById(employeeInformation.Id);
                return Ok(employee);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Update")]
        public async Task<IActionResult> Update(EmployeeInformation employeeInformation)
        {
            try
            {
                var employee = await _repository.Update(employeeInformation);
                return Ok(employee);
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
                var employee = await _repository.Delete(Id);
                return Ok(employee);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}