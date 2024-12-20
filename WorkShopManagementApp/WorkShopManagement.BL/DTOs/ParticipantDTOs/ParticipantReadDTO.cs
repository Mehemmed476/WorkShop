using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopManagement.BL.DTOs.ParticipantDTOs;

public record ParticipantReadDTO
{
    public bool IsDeleted { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public int WorkShopId { get; set; }
}
