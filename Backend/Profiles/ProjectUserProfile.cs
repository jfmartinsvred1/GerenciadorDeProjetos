using AutoMapper;
using Gerenciador.Dtos;
using Gerenciador.Models;

namespace Gerenciador.Profiles
{
    public class ProjectUserProfile:Profile
    {
        public ProjectUserProfile()
        {
            CreateMap<CreateProjectUserDto, ProjectUser>();
        }
    }
}
