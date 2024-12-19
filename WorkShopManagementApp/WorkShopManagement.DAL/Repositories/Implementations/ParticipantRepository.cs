using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopManagement.Core.Entities;
using WorkShopManagement.DAL.Contexts;
using WorkShopManagement.DAL.Repositories.Abstractions;

namespace WorkShopManagement.DAL.Repositories.Implementations
{
    public class ParticipantRepository : Repository<Participant>, IParticipantRepository
    {
        public ParticipantRepository(AppDbContext context) : base(context)
        {
        }
    }
}
