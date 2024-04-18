using Gerenciador.Dtos;

namespace Gerenciador.Data
{
    public interface IProjectUserDao
    {
        void AddUserProject(CreateProjectUserDto dto);

        List<string> GetAllIdsOfProject(string projectId);

    }
}
