using AutoMapper;
using GuideApp.WebApp.Models.Dto.DepartmentDtos;
using GuideApp.WebApp.Models.Entities;

namespace GuideApp.WebApp.Profiles;

public class DepartmentsProfile : Profile
{
    public DepartmentsProfile()
    {
        CreateMap<Department, DepartmentDto>();   
        CreateMap<DepartmentCreateDto, Department>();
        CreateMap<DepartmentUpdateDto, Department>().ReverseMap();
    }
}