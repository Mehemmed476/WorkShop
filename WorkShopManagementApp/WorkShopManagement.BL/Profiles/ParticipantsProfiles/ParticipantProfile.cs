using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopManagement.BL.DTOs.ParticipantDTOs;
using WorkShopManagement.Core.Entities;

namespace WorkShopManagement.BL.Profiles.ParticipantsProfiles;

public class ParticipantProfile : Profile
{
    public ParticipantProfile()
    {
        
        CreateMap<ParticipantReadDTO, Participant>().ReverseMap();
        
        CreateMap<ParticipantCreateDTO, Participant>().ReverseMap();
        
        CreateMap<ParticipantUpdateDTO, Participant>().ReverseMap();
    }
}
