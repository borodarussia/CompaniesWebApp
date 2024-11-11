using AutoMapper;
using GuideApp.WebApp.Models.Dto.OfficeDtos;
using GuideApp.WebApp.Models.Entities;

namespace GuideApp.WebApp.Profiles;

public class OfficesProfile : Profile
{
    public OfficesProfile()
    {
        CreateMap<Office, OfficeDto>();
        CreateMap<OfficeCreateDto, Office>();
        CreateMap<OfficeUpdateDto, Office>().ReverseMap();
    }
}