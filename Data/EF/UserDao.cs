using AutoMapper;
using Gerenciador.Dtos;
using Microsoft.AspNetCore.Identity;

namespace Gerenciador.Data.EF
{
    public class UserDao : IUserDao
    {
        IMapper _mapper;
        UserManager<IdentityUser> _userManager;

        public UserDao(IMapper mapper, UserManager<IdentityUser> manager)
        {
            _mapper = mapper;
            _userManager = manager;
        }

        public async Task RegisterUser(CreateUserDto dto)
        {
            IdentityUser user = _mapper.Map<IdentityUser>(dto);
            IdentityResult result = await _userManager.CreateAsync(user);
            if(!result.Succeeded)
            {
                throw new ApplicationException("Algo Deu Errado!");
            }
        }
    }
}
