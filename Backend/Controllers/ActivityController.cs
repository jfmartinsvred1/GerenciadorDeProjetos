using Gerenciador.Data;
using Gerenciador.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciador.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActivityController:ControllerBase
    {
        IActivityDao _activityDao;

        public ActivityController(IActivityDao activityDao)
        {
            _activityDao = activityDao;
        }

        [HttpGet]
        public ICollection<ReadActivityDto> GetAllWhithUser(string userId)
        {
            return _activityDao.GetActivitysWithUser(userId);
        }
        [HttpGet("/WithProject")]
        public ICollection<ReadActivityDto> GetAllWhithProject(string projectId)
        {
            return _activityDao.GetActivitysWithProject(projectId);
        }
        [HttpPost]
        public IActionResult CreateActivity(CreateActivityDto activity)
        {
            _activityDao.CreateActivity(activity);
            return Ok();
        }
    }
}
