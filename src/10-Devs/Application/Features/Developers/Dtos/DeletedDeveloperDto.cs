using Application.Features.Developers.Dtos.BaseDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Developers.Dtos;

public class DeletedDeveloperDto : BaseDeveloperDto
{
    public DateTime DeletedDate { get; set; }
    public bool isDeleted { get; set; }
}
