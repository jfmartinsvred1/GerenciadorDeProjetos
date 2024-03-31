using AutoMapper;
using Gerenciador.Data;
using Gerenciador.Dtos;
using Gerenciador.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciador.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController:ControllerBase
    {
        IProjectDao _projectDao;

        public ProjectController(IProjectDao projectDao)
        {
            _projectDao = projectDao;
        }

        [HttpPost]
        [Authorize(Policy = "EmailConfirm")]
        public IActionResult CreateProject(CreateProjectDto dto)
        {
            _projectDao.CreateProject(dto);
             return Ok("Criado Com Sucesso");
        }

    }
}
