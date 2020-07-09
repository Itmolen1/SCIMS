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
    public class CourseClassInformationController : ControllerBase
    {
        private readonly ICourseClassRepository _repository;

        public CourseClassInformationController(ICourseClassRepository courseClassRepository)
        {
            this._repository = courseClassRepository;
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> All()
        {
            try
            {
                var classCourses = await _repository.All();
                return Ok(classCourses);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add(CourseClassRoom courseClassRoom)
        {
            try
            {
                var classCourse = await _repository.Insert(courseClassRoom);
                return Ok(classCourse);
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
                var classCourse = await _repository.GetById(Id);
                return Ok(classCourse);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        [HttpPost]
        [Route("Update")]
        public async Task<IActionResult> Update(CourseClassRoom courseClassRoom)
        {
            try
            {
                var courseClass = await _repository.Update(courseClassRoom);
                return Ok(courseClass);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Delete")]
        public async Task<IActionResult> Delete(CourseClassRoom courseClassRoom)
        {
            try
            {
                var courseClass = await _repository.Delete(courseClassRoom.Id);
                return Ok(courseClass);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}




