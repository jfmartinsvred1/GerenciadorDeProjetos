using Gerenciador.Dtos;

namespace Gerenciador.Data
{
    public interface IUserDao
    {
        Task RegisterUser(CreateUserDto dto);
    }
}
