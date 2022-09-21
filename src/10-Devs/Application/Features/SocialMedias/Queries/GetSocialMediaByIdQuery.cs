using Application.Features.SocialMedias.Dtos.BaseDto;
using Application.Features.SocialMedias.Rules;
using Application.Services.Repositories.SocialMedias;
using AutoMapper;
using MediatR;

namespace Application.Features.SocialMedias.Queries;

public class GetSocialMediaByIdQuery : IRequest<BaseSocialMediaDto>
{
    public string Id { get; set; }

    public class GetBySocialMediaIdQueryHandler : IRequestHandler<GetSocialMediaByIdQuery, BaseSocialMediaDto>
    {
        private readonly ISocialMediaReadRepository _socialMediaReadRepository;
        private readonly SocialMediaBusinessRules _socialMediaBusinessRules;
        private readonly IMapper _mapper;

        public GetBySocialMediaIdQueryHandler (ISocialMediaReadRepository socialMediaReadRepository, IMapper mapper, SocialMediaBusinessRules socialMediaBusinessRules)
        {
            _socialMediaReadRepository = socialMediaReadRepository;
            _socialMediaBusinessRules = socialMediaBusinessRules;
            _mapper = mapper;
        }

        public async Task<BaseSocialMediaDto> Handle (GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
        {
            var socialMedia = await _socialMediaReadRepository.GetByIdAsync(request.Id);
            await _socialMediaBusinessRules.CheckIfSocialMediaDoesNotExists(socialMedia);

            return _mapper.Map<BaseSocialMediaDto>(socialMedia);
        }
    }
}
