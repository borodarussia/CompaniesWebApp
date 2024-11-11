using AutoMapper;
using GuideApp.WebApp.Models.Dto.CompanyDtos;
using GuideApp.WebApp.Models.Entities;
using GuideApp.WebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace GuideApp.WebApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentController : ControllerBase
{
    private readonly IRepository _repository;
    private readonly ILogger<DepartmentController> _logger;
    private readonly IMapper _mapper;

    public DepartmentController(IRepository repository,
        ILogger<DepartmentController> logger,
        IMapper mapper)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _mapper = mapper;
    }

    [HttpGet]
    [HttpHead]
    public async Task<IActionResult> GetCompanies()
    {
        var companiesEnt = await _repository
            .GetCompaniesAsync();
        
        return Ok(_mapper.Map<IEnumerable<CompanyDto>>(companiesEnt));
    }
    
    [HttpGet("{companyId}", Name = "GetCompany")]
    public async Task<ActionResult<CompanyDto>> GetCompany(Guid companyId)
    {
        var companyFromRepo = await _repository
            .GetCompanyAsync(companyId);

        if (companyFromRepo == null)
        {
            return NotFound();
        }
        
        return Ok(_mapper.Map<CompanyDto>(companyFromRepo));
    }

    [HttpPost]
    public async Task<ActionResult<CompanyDto>> CreateCompany(
        CompanyCreateDto company)
    {
        var companyEnt = _mapper.Map<Company>(company);
        
        _repository.AddCompany(companyEnt);
        
        await _repository.SaveAsync();
        
        return CreatedAtRoute("GetCompany",
            new { companyId = companyEnt.Id }, 
            companyEnt);
    }

    [HttpPut("{companyId}")]
    public async Task<IActionResult> UpdateCompany(
        Guid companyId,
        CompanyUpdateDto company)
    {
        var companyEnt = await _repository.GetCompanyAsync(companyId);

        if (companyEnt == null)
        {
            return NotFound();
        }
        
        _mapper.Map(company, companyEnt);

        return NoContent();
    }

    [HttpPatch("{companyId}")]
    public async Task<IActionResult> PartiallyUpdateCompany(Guid companyId)
    {
        if(!await _repository.CompanyExistsAsync(companyId))
            return NotFound();
        
        var companyEnt = await _repository.GetCompanyAsync(companyId);
        
        var companyForPatch = _mapper.Map<CompanyUpdateDto>(
            companyEnt);

        throw new NotImplementedException();
    }

    [HttpDelete("{companyId}")]
    public async Task<IActionResult> DeleteCompany(Guid companyId)
    {
        if (!await _repository.CompanyExistsAsync(companyId))
        {
            return NotFound();
        }

        var companyEnt = await _repository.GetCompanyAsync(companyId);
        
        _repository.DeleteCompany(companyEnt);
        await _repository.SaveAsync();
        
        return NoContent();
    }
}