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
    public class StudentInformationController : ControllerBase
    {
        private readonly IStudentRepository _repository;

        public StudentInformationController(IStudentRepository studentRepository)
        {
            this._repository = studentRepository;
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> All()
        {
            try
            {
                var students = await _repository.All();
                return Ok(students);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add(StudentInformation studentInformation)
        {
            try
            {
                var student = await _repository.Insert(studentInformation);
                return Ok(student);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        [Route("ById")]
        public async Task<IActionResult> ById(int Id)
        {
            try
            {
                var student = await _repository.GetById(Id);
                return Ok(student);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Update")]
        public async Task<IActionResult> Update(StudentInformation studentInformation)
        {
            try
            {
                var student = await _repository.Update(studentInformation);
                return Ok(student);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> Delete(StudentInformation studentInformation)
        {
            try
            {
                var student = await _repository.Delete(studentInformation.Id);
                return Ok(student);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}