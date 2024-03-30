using AutoMapper;
using Gerenciador.Dtos;
using Gerenciador.Models;
using Microsoft.AspNetCore.Identity;

namespace Gerenciador.Data.EF
{
    public class UserDao : IUserDao
    {
        IMapper _mapper;
        UserManager<User> _userManager;

        public UserDao(IMapper mapper, UserManager<User> manager)
        {
            _mapper = mapper;
            _userManager = manager;
        }

        public Task<string> LoginUser(LoginUserDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task RegisterUser(CreateUserDto dto)
        {
            User user = _mapper.Map<User>(dto);
            IdentityResult result = await _userManager.CreateAsync(user);
            if(!result.Succeeded)
            {
                throw new ApplicationException("Algo Deu Errado!");
            }
        }
    }
}
