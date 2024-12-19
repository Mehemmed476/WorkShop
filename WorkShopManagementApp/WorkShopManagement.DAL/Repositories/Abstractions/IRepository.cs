using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopManagement.Core.Entities.Base;

namespace WorkShopManagement.DAL.Repositories.Abstractions;

public interface IRepository<TEntity> where TEntity : BaseEntity, new()
{
    //Read
    Task<ICollection<TEntity>> GetAllAsync();
    Task<TEntity> GetByIdAsync(int id);

    //Write
    Task<TEntity> AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    void Delete(TEntity entity);
    Task SaveChangesAsync();
}
