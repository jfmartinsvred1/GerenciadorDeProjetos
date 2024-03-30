using AutoMapper;
using Gerenciador.Dtos;
using Microsoft.AspNetCore.Identity;

namespace Gerenciador.Profiles
{
    public class USerProfile:Profile
    {
        public USerProfile()
        {
            CreateMap<CreateUserDto, IdentityUser>();
        }
    }
}
