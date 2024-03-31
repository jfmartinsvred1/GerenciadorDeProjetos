using Gerenciador.Dtos;
using Gerenciador.Models;

namespace Gerenciador.Data
{
    public interface IUserDao
    {
        Task RegisterUser(CreateUserDto dto);
        Task<string> LoginUser(LoginUserDto dto);
        void VerifyEmail(VerifyEmail verify);

        ICollection<ReadUsersDto> GetUsersIds(string projectId);
    }
}
