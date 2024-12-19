using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopManagement.BL.DTOs.ParticipantDTOs;
using WorkShopManagement.Core.Entities;

namespace WorkShopManagement.BL.Services.Abstractions
{
    public interface IParticipantService
    {
        Task<ICollection<ParticipantReadDTO>> GetAllAsync();
        Task<ParticipantReadDTO> GetByIdAsync(int id);
        Task<ParticipantReadDTO> AddAsync(ParticipantCreateDTO participantCreateDTO);
        Task UpdateAsync(Participant participant);
        void Delete(Participant participant);
    }
}
