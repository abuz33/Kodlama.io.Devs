//-------------------------------------------------------------------------------------------------
//
// MappingProfiles1.cs -- The MappingProfiles1 class.
//
//-------------------------------------------------------------------------------------------------

using Application.Features.ProgrammingLanguages.Commands.CreateCommand;
using Application.Features.ProgrammingLanguages.Commands.DeleteCommand;
using Application.Features.ProgrammingLanguages.Commands.UpdateCommand;
using Application.Features.ProgrammingLanguages.Dtos;
using Application.Features.ProgrammingLanguages.Dtos.BaseDto;
using Application.Features.ProgrammingLanguages.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.ProgrammingLanguages.Profiles
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
            CreateMap<ProgrammingLanguage, BaseProgrammingLanguageDto>().ReverseMap();
            CreateMap<ProgrammingLanguage, CreateProgrammingLanguageCommand>().ReverseMap();
            CreateMap<ProgrammingLanguage, ProgrammingLanguageListDto>().ReverseMap();
            CreateMap<ProgrammingLanguage, UpdatedProgrammingLanguageDto>().ReverseMap();
            CreateMap<ProgrammingLanguage, UpdateProgrammingLanguageCommand>().ReverseMap();
            CreateMap<ProgrammingLanguage, DeletedProgrammingLanguageDto>().ReverseMap();
            CreateMap<ProgrammingLanguage, DeleteProgrammingLanguageCommand>().ReverseMap();
            CreateMap<IPaginate<ProgrammingLanguage>, ProgrammingLanguageListModel>().ReverseMap();
        }
    }
}
