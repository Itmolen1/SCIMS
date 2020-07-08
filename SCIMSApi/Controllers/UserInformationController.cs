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
    public class UserInformationController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserInformationController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        [HttpGet]
        [Route("All")]
        public async Task<ActionResult> All()
        {
            try
            {
               var users = await _userRepository.All();
                return Ok(users);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(UserInformation user)
        {
            try
            {

                List<UserInformation> userInformations = new List<UserInformation>();

                userInformations = await _userRepository.All();
                var userInfo = userInformations.Any(x => x.UserName == user.UserName && x.UserPassword == user.UserPassword);

                //if(userInfo == true)
                //{

                //}

                return Ok(userInfo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("ById")]
        public async Task<IActionResult> GetUser(UserInformation userInformation)
        {
            try
            {
                var result = await _userRepository.GetById(userInformation.Id);
                return Ok(result);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Insert(UserInformation userInformation)
        {
            try
            {
                var Data = await _userRepository.Insert(userInformation);
                return Ok(Data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Update")]
        public async Task<IActionResult> Update(UserInformation userInformation)
        {
            try
            {
                await _userRepository.Update(userInformation);
                return Ok(userInformation);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}