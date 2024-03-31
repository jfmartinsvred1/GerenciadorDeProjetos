using AutoMapper;
using Gerenciador.Models;

namespace Gerenciador.Profiles
{
    public class ActivityProfile:Profile
    {
        public ActivityProfile()
        {
            CreateMap<Activity, ActivityProfile>();
        }
    }
}
