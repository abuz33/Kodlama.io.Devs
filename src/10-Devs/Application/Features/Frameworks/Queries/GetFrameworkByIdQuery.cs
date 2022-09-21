//-------------------------------------------------------------------------------------------------
//
// GetFrameworkByIdQuery.cs -- The GetFrameworkByIdQuery class.
//
//-------------------------------------------------------------------------------------------------

using Application.Features.Frameworks.Dtos.BaseDto;
using Application.Features.Frameworks.Rules;
using Application.Services.Repositories.Frameworks;
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
    /// The GetFrameworkByIdQuery class TODO: Describe class here
    /// </summary>
    public class GetFrameworkByIdQuery : IRequest<BaseFrameworkDto>
    {
        public string Id { get; set; }

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// GetFrameworkByIdQueryHandler class TODO: Describe class here
        /// </summary>
        public class GetFrameworkByIdQueryHandler : IRequestHandler<GetFrameworkByIdQuery, BaseFrameworkDto>
        {
            private readonly IFrameworkReadRepository _frameworkReadRepository;
            private readonly FrameworkBusinessRules _frameworkBusinessRules;
            private readonly IMapper _mapper;

            //-----------------------------------------------------------------------------------------
            /// <summary>
            /// constructor
            /// </summary>
            /// <param name="mapper">Mapper</param>
            public GetFrameworkByIdQueryHandler (IFrameworkReadRepository frameworkReadRepository, IMapper mapper, FrameworkBusinessRules frameworkBusinessRules)
            {
                _frameworkReadRepository = frameworkReadRepository;
                _frameworkBusinessRules = frameworkBusinessRules;
                _mapper = mapper;
            }

            public async Task<BaseFrameworkDto> Handle (GetFrameworkByIdQuery request, CancellationToken cancellationToken)
            {
                var framework = await _frameworkReadRepository.GetByIdAsync(request.Id);
                await _frameworkBusinessRules.CheckIfFrameworkDoesNotExists(framework);

                return _mapper.Map<BaseFrameworkDto>(framework);
            }
        }
    }
}
