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
    public class CoursesInformationController : ControllerBase
    {
        private readonly ICoursesRepository _repository;

        public CoursesInformationController(ICoursesRepository coursesRepository)
        {
            this._repository = coursesRepository;
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> All()
        {
            try
            {
              var courses = await _repository.All();
                return Ok(courses);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add(CoursesInformation coursesInformation)
        {
            try
            {
                var course = await _repository.Insert(coursesInformation);
                return Ok(course);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        [Route("ById")]
        public async Task<IActionResult> ById(CoursesInformation coursesInformation)
        {
            try
            {
                var course = await _repository.GetById(coursesInformation.Id);
                return Ok(course);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Update")]
        public async Task<IActionResult> Update(CoursesInformation coursesInformation)
        {
            try
            {
                var course = await _repository.Update(coursesInformation);
                return Ok(course);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> Delete(CoursesInformation coursesInformation)
        {
            try
            {
                var course = await _repository.Delete(coursesInformation.Id);
                return Ok(course);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}