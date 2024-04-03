using AutoMapper;
using Gerenciador.Dtos;
using Gerenciador.Models;

namespace Gerenciador.Profiles
{
    public class ProjectProfile:Profile
    {
        public ProjectProfile()
        {
            CreateMap<CreateProjectDto, Project>();
            CreateMap<Project, ReadProjectDto>();
        }
    }
}
