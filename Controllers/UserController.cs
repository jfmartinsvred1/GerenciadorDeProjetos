using AutoMapper;
using Gerenciador.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciador.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController:ControllerBase
    {
        private IMapper _mapper;
        private UserManager<IdentityUser> _userManager;

        public UserController(IMapper mapper, UserManager<IdentityUser> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser(CreateUserDto dto)
        {
            IdentityUser user = _mapper.Map<IdentityUser>(dto);
            
            IdentityResult result = await _userManager.CreateAsync(user,dto.Password);

            if (!result.Succeeded)
            {
                return Ok("Criado com sucesso");
            }
            throw new ApplicationException("Algum Erro");
        }
    }
}
