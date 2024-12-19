using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopManagement.Core.Entities;

namespace WorkShopManagement.DAL.Configurations
{
    public class WorkShopConfiguration : IEntityTypeConfiguration<WorkShop>
    {
        public void Configure(EntityTypeBuilder<WorkShop> builder)
        {
           
        }
    }
}
