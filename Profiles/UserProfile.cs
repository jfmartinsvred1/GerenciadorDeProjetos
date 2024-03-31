using AutoMapper;
using Gerenciador.Dtos;
using Gerenciador.Models;

namespace Gerenciador.Profiles
{
    public class USerProfile:Profile
    {
        public USerProfile()
        {
            CreateMap<CreateUserDto, User>();
            CreateMap<User,ReadUsersDto>();
        }
    }
}
