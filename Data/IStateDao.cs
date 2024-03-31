using Gerenciador.Dtos;

namespace Gerenciador.Data
{
    public interface IStateDao
    {
        void CreateState(CreateStateDto dto);
        ICollection<ReadStateDto> GetAll();
    }
}
