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
    public class ClassRoomController : ControllerBase
    {
        private readonly IClassRoomRepository _repository;

        public ClassRoomController(IClassRoomRepository classRoomRepository)
        {
            this._repository = classRoomRepository;
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> All()
        {
            try
            {
                var classRooms = await _repository.All();
                return Ok(classRooms);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add(ClassRoomInformation classRoomInformation)
        {
            try
            {
                var classRoom = await _repository.Insert(classRoomInformation);
                return Ok(classRoom);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        [Route("ById")]
        public async Task<IActionResult> GetById(ClassRoomInformation classRoomInformation)
        {
            try
            {
                var classRoom = await _repository.GetById(classRoomInformation.Id);
                return Ok(classRoom);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Update")]
        public async Task<IActionResult> Update(ClassRoomInformation classRoomInformation)
        {
            try
            {
                var classRoom = await _repository.Update(classRoomInformation);
                return Ok(classRoom);
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
                var classRoom = await _repository.Delete(Id);
                return Ok(classRoom);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}