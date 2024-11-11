using AutoMapper;
using GuideApp.WebApp.Models.Dto.CompanyDtos;
using GuideApp.WebApp.Models.Entities;

namespace GuideApp.WebApp.Profiles;

public class CompaniesProfile : Profile
{
    public CompaniesProfile()
    {
        CreateMap<Company, CompanyDto>();
        CreateMap<CompanyCreateDto, Company>();
        CreateMap<CompanyUpdateDto, Company>().ReverseMap();
    }
}