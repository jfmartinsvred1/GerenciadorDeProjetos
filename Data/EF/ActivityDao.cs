using AutoMapper;
using Gerenciador.Dtos;
using Gerenciador.Models;
using Microsoft.EntityFrameworkCore;

namespace Gerenciador.Data.EF
{
    public class ActivityDao : IActivityDao
    {
        IMapper _mapper;
        GerenciadorContext _context;

        public ActivityDao(IMapper mapper, GerenciadorContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public void CreateActivity(CreateActivityDto createActivityDto)
        {
            Activity activity = _mapper.Map<Activity>(createActivityDto);
            _context.Activities.Add(activity);
            _context.SaveChanges();
        }

        public ICollection<ReadActivityDto> GetActivitysWithProject(string projectId)
        {
            throw new NotImplementedException();
        }

        public ICollection<ReadActivityDto> GetActivitysWithUser(string userId)
        {
            var activyties = _context.Activities.Where(user => user.UserId == userId).Include(u=>u.User).Include(s=>s.State).Include(p=>p.Project);
            return _mapper.Map<List<ReadActivityDto>>(activyties);
        }
    }
}
