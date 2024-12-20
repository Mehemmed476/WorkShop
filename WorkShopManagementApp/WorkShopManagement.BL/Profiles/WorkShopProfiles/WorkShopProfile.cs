using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopManagement.BL.DTOs.ParticipantDTOs;
using WorkShopManagement.BL.DTOs.WorkShopDTOs;
using WorkShopManagement.Core.Entities;

namespace WorkShopManagement.BL.Profiles.WorkShopProfiles;

public class WorkShopProfile : Profile
{
    public WorkShopProfile()
    {
        CreateMap <WorkShopCreateDTO, WorkShop>();
        CreateMap<WorkShopCreateDTO, WorkShop>().ReverseMap();
        CreateMap<WorkShopUpdateDTO, WorkShop>();
        CreateMap<WorkShopUpdateDTO, WorkShop>().ReverseMap();
    }
}
