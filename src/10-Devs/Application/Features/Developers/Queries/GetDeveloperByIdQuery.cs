//-------------------------------------------------------------------------------------------------
//
// GetDeveloperByIdQuery.cs -- The GetDeveloperByIdQuery class.
//
//-------------------------------------------------------------------------------------------------

using AutoMapper;
using Core.Security.Dtos;
using Core.Security.JWT;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Features.Developers.Queries
{
    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The GetDeveloperByIdQuery class TODO: Describe class here
    /// </summary>
    public class GetDeveloperByIdQuery : IRequest<T>
    {
        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// GetDeveloperByIdQueryHandler class TODO: Describe class here
        /// </summary>
        public class GetDeveloperByIdQueryHandler : IRequestHandler<GetDeveloperByIdQuery, T>
        {
            private readonly IMapper _mapper;

            //-----------------------------------------------------------------------------------------
            /// <summary>
            /// constructor
            /// </summary>
            /// <param name="mapper">Mapper</param>
            public GetDeveloperByIdQueryHandler (IMapper mapper)
            {
                _mapper = mapper;
            }

            //-----------------------------------------------------------------------------------------
            /// <inheritdoc />
            public Task<T> Handle (GetDeveloperByIdQuery request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}