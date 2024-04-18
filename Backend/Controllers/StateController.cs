using Gerenciador.Data;
using Gerenciador.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciador.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StateController:ControllerBase
    {
        IStateDao _stateDao;

        public StateController(IStateDao stateDao)
        {
            _stateDao = stateDao;
        }
        [HttpPost]

        public IActionResult Post(CreateStateDto dto)
        {
            _stateDao.CreateState(dto);
            return Ok(dto);
        }
        [HttpGet]
        public ICollection<ReadStateDto> GetAll() 
        {
            return _stateDao.GetAll(); 
        }
    }
}
