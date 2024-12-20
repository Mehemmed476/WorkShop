using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkShopManagement.BL.DTOs.ParticipantDTOs;
using WorkShopManagement.BL.Services.Abstractions;
using WorkShopManagement.DAL.Repositories.Abstractions;

namespace WorkShopManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantsController : ControllerBase
    {
        private readonly IParticipantService _service;

        public ParticipantsController(IParticipantService service)
        {
            _service = service;
        }

        [HttpGet("GetAllParticipants")]
        public async Task<ICollection<ParticipantReadDTO>> GetAll()
        {
            var participants = await _service.GetAllAsync();
            return participants;
        }


        [HttpGet("GetById/{id}")]
        public async Task<ParticipantReadDTO> GetById(int id)
        {
            var participant = await _service.GetByIdAsync(id);
            return participant;
        }


        [HttpPost("Create")]
        public async Task<ParticipantReadDTO> Create(ParticipantCreateDTO participantCreateDTO)
        {
            var participant = await _service.AddAsync(participantCreateDTO);
            return participant;
        }


        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(int id, ParticipantUpdateDTO participantUpdateDTO)
        {
            var result = await _service.UpdateAsync(id, participantUpdateDTO);

            return Ok(result);
        }


        [HttpPut("SoftDelete/{id}")]
        public async Task<IActionResult> SoftDelete(int id)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, await _service.SoftDeleteAsync(id));
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status400BadRequest, e.Message);
            }
        }


        [HttpPut("Restore/{id}")]
        public async Task<IActionResult> Restore(int id)
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, await _service.SoftDeleteAsync(id));
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status400BadRequest, e.Message);
            }
        }



    }
}
