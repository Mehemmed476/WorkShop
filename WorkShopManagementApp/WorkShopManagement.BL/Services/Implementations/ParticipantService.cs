using AutoMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopManagement.BL.DTOs.ParticipantDTOs;
using WorkShopManagement.BL.Services.Abstractions;
using WorkShopManagement.Core.Entities;
using WorkShopManagement.DAL.Repositories.Abstractions;

namespace WorkShopManagement.BL.Services.Implementations;

public class ParticipantService : IParticipantService
{
    private readonly IParticipantRepository _participantRepository;
    private readonly IMapper _mapper;
    public ParticipantService(IParticipantRepository participantRepository, IMapper mapper)
    {
        _participantRepository = participantRepository;
        _mapper = mapper;
    }

    public async Task<ParticipantReadDTO> AddAsync(ParticipantCreateDTO participantCreateDTO)
    {
        var participant = _mapper.Map<Participant>(participantCreateDTO);

        participant.CreatedAt = DateTime.UtcNow.AddHours(4);

        await _participantRepository.AddAsync(participant);
        await _participantRepository.SaveChangesAsync();

        var result = _mapper.Map<ParticipantReadDTO>(participant);
        return result;
    }

    public async Task<bool> Delete(int id)
    {
        bool result = false;
        var participantReadDTO = await GetByIdAsync(id);
        var participant = _mapper.Map<Participant>(participantReadDTO);

        _participantRepository.Delete(participant);
        await _participantRepository.SaveChangesAsync();

        result = true;

        return result;
    }

    public async Task<ICollection<ParticipantReadDTO>> GetAllAsync()
    {
        ICollection<Participant> participants = await _participantRepository.GetAllAsync();

        ICollection<ParticipantReadDTO> sendParticipants = _mapper.Map<ICollection<ParticipantReadDTO>>(participants);

        return sendParticipants;
    }

    public async Task<ParticipantReadDTO> GetByIdAsync(int id)
    {
        if (!await _participantRepository.IsExist(id))
        {
            throw new Exception("Entity Not Found!!!");
        }

        var participant = await _participantRepository.GetByIdAsync(id);

        var participantReadDTO = _mapper.Map<ParticipantReadDTO>(participant);
        
        return participantReadDTO;
    }

    public async Task<bool> RestoreAsync(int id)
    {
        bool result = false;

        var participantReadDTO = await GetByIdAsync(id);
        var participant = _mapper.Map<Participant>(participantReadDTO);
        participant.DeletedAt = null;
        _participantRepository.Restore(participant);
        await _participantRepository.SaveChangesAsync();

        result = true;

        return result;
    }

    public async Task<bool> SoftDeleteAsync(int id)
    {
        bool result = false;

        var participantReadDTO = await GetByIdAsync(id);
        var participant = _mapper.Map<Participant>(participantReadDTO);
        participant.DeletedAt = DateTime.UtcNow.AddHours(4);
        _participantRepository.SoftDelete(participant);
        await _participantRepository.SaveChangesAsync();

        result = true;

        return result;
    }

    public async Task<bool> UpdateAsync(int id, ParticipantUpdateDTO participantUpdateDTO)
    {
        bool result = false;

        var bookEntity = await GetByIdAsync(id);
        var updatedBook = _mapper.Map<Participant>(participantUpdateDTO);

        updatedBook.ModifiedAt = DateTime.UtcNow.AddHours(4);
        updatedBook.Id = id;

        await _participantRepository.UpdateAsync(updatedBook);
        await _participantRepository.SaveChangesAsync();

        result = true;

        return result;

    }
}
