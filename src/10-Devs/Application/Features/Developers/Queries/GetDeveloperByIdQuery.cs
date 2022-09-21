//-------------------------------------------------------------------------------------------------
//
// GetDeveloperByIdQuery.cs -- The GetDeveloperByIdQuery class.
//
//-------------------------------------------------------------------------------------------------

using Application.Features.Developers.Dtos.BaseDto;
using Application.Features.Developers.Rules;
using AutoMapper;
using Core.Security.Dtos;
using Core.Security.JWT;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Features.Frameworks.Queries
{
    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The GetDeveloperByIdQuery class TODO: Describe class here
    /// </summary>
    public class GetDeveloperByIdQuery : IRequest<BaseDeveloperDto>
    {
        public string Id { get; set; }
        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// GetDeveloperByIdQueryHandler class TODO: Describe class here
        /// </summary>
        public class GetDeveloperByIdQueryHandler : IRequestHandler<GetDeveloperByIdQuery, BaseDeveloperDto>
        {
            private readonly DeveloperBusinessRules _developerBusinessRules;
            private readonly IMapper _mapper;

            //-----------------------------------------------------------------------------------------
            /// <summary>
            /// constructor
            /// </summary>
            /// <param name="mapper">Mapper</param>
            public GetDeveloperByIdQueryHandler (IMapper mapper, DeveloperBusinessRules developerBusinessRules)
            {
                _mapper = mapper;
                _developerBusinessRules = developerBusinessRules;
            }

            //-----------------------------------------------------------------------------------------
            /// <inheritdoc />
            public async Task<BaseDeveloperDto> Handle (GetDeveloperByIdQuery request, CancellationToken cancellationToken)
            {
                var developer = await _developerBusinessRules.CheckIfDeveloperDoesNotExistsAndGetDeveloper(request.Id);

                return _mapper.Map<BaseDeveloperDto>(developer);
            }
        }
    }
}
