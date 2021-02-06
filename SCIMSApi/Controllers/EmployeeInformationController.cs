using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SCIMSApi.Interfaces;

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
    }
}