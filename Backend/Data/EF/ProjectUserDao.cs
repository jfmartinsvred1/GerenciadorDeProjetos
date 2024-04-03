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

        public List<string> GetAllIdsOfProject(string projectId)
        {
            var projectusers= _context.ProjectsUsers.Where(project=>project.ProjectId == projectId).ToList();

            var ids = new List<string>();

            foreach (var user in projectusers)
            {
                ids.Add(user.UserId);
            }

            return ids;
        }
    }
}
