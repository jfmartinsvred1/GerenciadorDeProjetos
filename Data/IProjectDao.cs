using Gerenciador.Dtos;

namespace Gerenciador.Data
{
    public interface IProjectDao
    {
        void CreateProject(CreateProjectDto dto);
    }
}
