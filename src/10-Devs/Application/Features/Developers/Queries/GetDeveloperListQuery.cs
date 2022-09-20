//-------------------------------------------------------------------------------------------------
//
// GetDeveloperListQuery.cs -- The GetDeveloperListQuery class.
//
//-------------------------------------------------------------------------------------------------

using Application.Features.Developers.Dtos.BaseDto;
using Application.Features.Developers.Models;
using Application.Features.Developers.Rules;
using Application.Services.Repositories.Developers;
using AutoMapper;
using Core.Application.Requests;
using Core.Security.Dtos;
using Core.Security.JWT;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Features.Developers.Queries;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The GetDeveloperListQuery class
/// </summary>
public class GetDeveloperListQuery : IRequest<DeveloperListModel>
{
    public PageRequest PageRequest { get; set; }

    //-----------------------------------------------------------------------------------------
    /// <summary>
    /// GetDeveloperListQueryHandler class
    /// </summary>
    public class GetDeveloperListQueryHandler : IRequestHandler<GetDeveloperListQuery, DeveloperListModel>
    {
        private readonly IMapper _mapper;
        private readonly IDeveloperReadRepository _developerReadRepository;

        public GetDeveloperListQueryHandler (IDeveloperReadRepository developerReadRepository, IMapper mapper)
        {
            _mapper = mapper;
            _developerReadRepository = developerReadRepository;
        }

        public async Task<DeveloperListModel> Handle (GetDeveloperListQuery request, CancellationToken cancellationToken)
        {
            var developers = await _developerReadRepository.GetListAsync(include: m => m.Include(p => p.User),
                index: request.PageRequest.Page, size: request.PageRequest.PageSize);
            return _mapper.Map<DeveloperListModel>(developers);
        }
    }
}
