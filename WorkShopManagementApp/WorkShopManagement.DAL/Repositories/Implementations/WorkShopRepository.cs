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
    internal class WorkShopRepository : Repository<WorkShop>, IWorkShopRepository
    {
        public WorkShopRepository(AppDbContext context) : base(context)
        {
        }
    }
}
