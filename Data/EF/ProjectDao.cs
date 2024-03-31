using AutoMapper;
using Gerenciador.Dtos;
using Gerenciador.Models;

namespace Gerenciador.Data.EF
{
    public class ProjectDao : IProjectDao
    {
        IMapper _mapper;
        GerenciadorContext _context;

        public ProjectDao(IMapper mapper, GerenciadorContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public void CreateProject(CreateProjectDto dto)
        {
            Project project = _mapper.Map<Project>(dto);

            _context.Projects.Add(project);
            _context.SaveChanges();
        }

        public ICollection<ReadProjectDto> GetAll(string managerId)
        {
            ICollection<ReadProjectDto> projects = _mapper.Map<ICollection<ReadProjectDto>>(_context.Projects.Where(id=>id.ManagerId==managerId).ToList()); ;
            return projects;
        }
    }
}
