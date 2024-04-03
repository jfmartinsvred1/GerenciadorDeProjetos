using AutoMapper;
using Gerenciador.Dtos;
using Gerenciador.Models;

namespace Gerenciador.Data.EF
{
    public class StateDao : IStateDao
    {
        IMapper _mapper;
        GerenciadorContext _context;

        public StateDao(IMapper mapper, GerenciadorContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public void CreateState(CreateStateDto dto)
        {
            State state = _mapper.Map<State>(dto);
            _context.States.Add(state);
            _context.SaveChanges();
        }

        public ICollection<ReadStateDto> GetAll()
        {
            var states = _context.States.ToList();

            ICollection <ReadStateDto> readStates = _mapper.Map<List<ReadStateDto>>(states);

            return readStates;
        }
    }
}
