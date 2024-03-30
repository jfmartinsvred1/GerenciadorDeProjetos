using AutoMapper;
using Gerenciador.Dtos;
using Gerenciador.Models;

namespace Gerenciador.Data.EF
{
    public class ProjectUserDao : IProjectUserDao
    {
        IMapper _mapper;
        GerenciadorContext _context;

        public ProjectUserDao(IMapper mapper, GerenciadorContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public void AddUserProject(CreateProjectUserDto dto)
        {
            ProjectUser projectUserDao = _mapper.Map<ProjectUser>(dto);

            _context.ProjectsUsers.Add(projectUserDao);
            _context.SaveChanges();
        }
    }
}
