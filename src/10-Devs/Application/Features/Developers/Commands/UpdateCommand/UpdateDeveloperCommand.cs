//-------------------------------------------------------------------------------------------------
//
// UpdateDeveloperCommand.cs -- The UpdateDeveloperCommand class.
//
//-------------------------------------------------------------------------------------------------

using Application.Features.Developers.Dtos.BaseDto;
using Application.Features.Developers.Rules;
using Application.Services.Repositories.Developers;
using AutoMapper;
using Core.Security.Dtos;
using Core.Security.JWT;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Features.Developers.Commands.UpdateCommand;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The UpdateDeveloperCommand class TODO: Describe class here
/// </summary>
public class UpdateDeveloperCommand : IRequest<BaseDeveloperDto>
{
    public string Id { get; set; }
    public string UserId { get; set; }
    //-----------------------------------------------------------------------------------------
    /// <summary>
    /// UpdateDeveloperCommandHandler class TODO: Describe class here
    /// </summary>
    public class UpdateDeveloperCommandHandler : IRequestHandler<UpdateDeveloperCommand, BaseDeveloperDto>
    {
        private readonly IDeveloperWriteRepository _developerWriteRepository;
        private readonly DeveloperBusinessRules _developerBusinessRules;
        private readonly IMapper _mapper;


        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="mapper">Mapper</param>
        public UpdateDeveloperCommandHandler (IMapper mapper)
        {
            _mapper = mapper;
        }

        //-----------------------------------------------------------------------------------------
        /// <inheritdoc />
        public async Task<BaseDeveloperDto> Handle (UpdateDeveloperCommand request, CancellationToken cancellationToken)
        {
            var developerToUpdate = await _developerBusinessRules.CheckIfDeveloperDoesNotExistsAndGetDeveloper(request.Id);
            await _developerBusinessRules.CheckIfUserDoesNotExistsAndGetUser(request.UserId);

            _mapper.Map(request, developerToUpdate, typeof(UpdateDeveloperCommand), typeof(Developer));
            await _developerWriteRepository.Update(developerToUpdate);
            return _mapper.Map<BaseDeveloperDto>(developerToUpdate);
        }
    }
}
