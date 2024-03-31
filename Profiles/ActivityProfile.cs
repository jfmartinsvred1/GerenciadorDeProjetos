using AutoMapper;
using Gerenciador.Dtos;
using Gerenciador.Models;

namespace Gerenciador.Profiles
{
    public class ActivityProfile:Profile
    {
        public ActivityProfile()
        {
            CreateMap<CreateActivityDto, Activity>();
            CreateMap<Activity, ReadActivityDto>();
        }
    }
}
