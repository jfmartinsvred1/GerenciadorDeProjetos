using Gerenciador.Dtos;

namespace Gerenciador.Data
{
    public interface IActivityDao
    {
        ICollection<ReadActivityDto> GetActivitysWithUser(string userId);
        ICollection<ReadActivityDto> GetActivitysWithProject(string projectId);
        void CreateActivity(CreateActivityDto createActivityDto);
    }
}
