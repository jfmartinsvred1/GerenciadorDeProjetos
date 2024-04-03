using AutoMapper;
using Gerenciador.Data;
using Gerenciador.Dtos;
using Gerenciador.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciador.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController:ControllerBase
    {
        IUserDao _userDao;

        public UserController(IUserDao userDao)
        {
            _userDao = userDao;
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> RegisterUserAsync(CreateUserDto dto)
        {
            await _userDao.RegisterUser(dto);

            return Ok("Criado com sucesso");
        }
        [HttpPost("login")]
        public async Task<IActionResult> LoginUser(LoginUserDto dto)
        {
            var token = await _userDao.LoginUser(dto);
            return Ok(token);
        }
        [HttpPost("verifyEmail")]
        public IActionResult VerifyEmail(VerifyEmail email)
        {
            _userDao.VerifyEmail(email);
            return Ok("Verificado com sucesso");
        }
    }
}
