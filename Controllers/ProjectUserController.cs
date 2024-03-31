using AutoMapper;
using Gerenciador.Data;
using Gerenciador.Dtos;
using Gerenciador.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Gerenciador.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProjectUserController : ControllerBase
    {
        IProjectUserDao _projectUserDao;
        IUserDao _userDao;

        public ProjectUserController(IProjectUserDao projectUserDao, IUserDao userDao)
        {
            _projectUserDao = projectUserDao;
            _userDao = userDao;
        }

        [HttpPost]
        public IActionResult AddUserProject(CreateProjectUserDto dto)
        {
            _projectUserDao.AddUserProject(dto);
            return Ok("Criado Com Sucesso");
        }
        [HttpGet]
        public ICollection<ReadUsersDto> GetWorkers(string projectId)
        {
            return _userDao.GetUsersIds(projectId);
        }
    }

    
}
