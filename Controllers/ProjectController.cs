using AutoMapper;
using Gerenciador.Data;
using Gerenciador.Dtos;
using Gerenciador.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciador.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController:ControllerBase
    {
        GerenciadorContext _context;
        IMapper _mapper;

        public ProjectController(GerenciadorContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public void CreateProject(CreateProjectDto dto)
        {
            Project project= _mapper.Map<Project>(dto);
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

    }
}
