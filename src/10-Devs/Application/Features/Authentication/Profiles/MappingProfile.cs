//-------------------------------------------------------------------------------------------------
//
// MappingProfile.cs -- The MappingProfile class.
//
//-------------------------------------------------------------------------------------------------


using Application.Features.Authentication.Commands.LoginCommand;
using Application.Features.Authentication.Commands.RegisterCommand;
using Application.Features.Authentication.Dtos;
using AutoMapper;
using Core.Security.Dtos;
using Core.Security.Entities;

namespace Application.Features.Authentication.Profiles
{
    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The mapping profile class contains the mapping between Dto and Model
    /// </summary>
    public class MappingProfile : Profile
    {
        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// The constructor
        /// </summary>
        public MappingProfile ()
        {
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<UserForRegisterDto, User>().ReverseMap();
            CreateMap<RegisterCommand, User>().ReverseMap();
            CreateMap<UserForLoginDto, User>().ReverseMap();
            CreateMap<LoginCommand, User>().ReverseMap();
            CreateMap<RefreshToken, RefreshTokenDto>().ReverseMap();
        }
    }
}
