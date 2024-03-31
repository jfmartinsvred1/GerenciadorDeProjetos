using AutoMapper;
using Gerenciador.Dtos;
using Gerenciador.Models;

namespace Gerenciador.Profiles
{
    public class StateProfile:Profile
    {
        public StateProfile()
        {
            CreateMap<State, ReadStateDto>();
            CreateMap<CreateStateDto, State>();
        }
    }
}
