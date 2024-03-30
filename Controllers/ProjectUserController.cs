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
        IMapper _mapper;
        GerenciadorContext _context;

        public ProjectUserController(IMapper mapper, GerenciadorContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        [HttpPost]
        public void AddUserProject(CreateProjectUserDto dto)
        {
            ProjectUser projectUser = _mapper.Map<ProjectUser>(dto);
            _context.ProjectsUsers.Add(projectUser);
            _context.SaveChanges();
        }
    }
}
