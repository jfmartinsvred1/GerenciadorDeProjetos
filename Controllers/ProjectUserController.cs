using AutoMapper;
using Gerenciador.Data;
using Gerenciador.Dtos;
using Gerenciador.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciador.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProjectUserController : ControllerBase
    {
        IProjectUserDao _projectUserDao;

        public ProjectUserController(IProjectUserDao projectUserDao)
        {
            _projectUserDao = projectUserDao;
        }

        [HttpPost]
        public IActionResult AddUserProject(CreateProjectUserDto dto)
        {
            _projectUserDao.AddUserProject(dto);
            return Ok("Criado Com Sucesso");
        }
    }
}
