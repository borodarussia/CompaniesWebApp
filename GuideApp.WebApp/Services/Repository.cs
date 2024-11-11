using GuideApp.WebApp.DbContexts;
using GuideApp.WebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace GuideApp.WebApp.Services;

public class Repository : IRepository
{
    private readonly CompanyInfoContext _context;

    public Repository(CompanyInfoContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
    
    public async Task<IEnumerable<Company>> GetCompaniesAsync()
    {
        return await _context.Companies
            .OrderBy(c => c.Name)
            .ToListAsync();
    }

    public async Task<IEnumerable<Department>> GetDepartmentsAsync(Guid companyId)
    {
        if(companyId == Guid.Empty)
            throw new ArgumentNullException(nameof(companyId));

        return await _context.Departments
            .Where(d => d.CompanyId == companyId)
            .OrderBy(d => d.Name)
            .ToListAsync();
    }

    public async Task<IEnumerable<Office>> GetOfficesAsync(Guid departmentId)
    {
        if(departmentId == Guid.Empty)
            throw new ArgumentNullException(nameof(departmentId));
        
        return await _context.Offices.Where(o => o.DepartmentId == departmentId)
            .OrderBy(o => o.Name)
            .ToListAsync();
    }

    public async Task<Company> GetCompanyAsync(Guid companyId)
    {
        if(companyId == Guid.Empty)
            throw new ArgumentNullException(nameof(companyId));
        
        return await _context.Companies
            .Where(c => c.Id == companyId)
            .FirstOrDefaultAsync();
    }

    public async Task<Department> GetDepartmentAsync(Guid companyId, Guid departmentId)
    {
        if(companyId == Guid.Empty)
            throw new ArgumentNullException(nameof(companyId));
        if(departmentId == Guid.Empty)
            throw new ArgumentNullException(nameof(departmentId));

        return await _context.Departments
            .Where(d => d.CompanyId == companyId && d.Id == departmentId)
            .FirstOrDefaultAsync();
    }

    public async Task<Office> GetOfficeAsync(Guid departmentId, Guid officeId)
    {
        if(departmentId == Guid.Empty)
            throw new ArgumentNullException(nameof(departmentId));
        if(officeId == Guid.Empty)
            throw new ArgumentNullException(nameof(officeId));

        return await _context.Offices
            .Where(o => o.DepartmentId == departmentId && o.Id == officeId)
            .FirstOrDefaultAsync();
    }

    public void AddCompany(Company company)
    {
        if(company == null)
            throw new ArgumentNullException(nameof(company));
        
        company.Id = Guid.NewGuid();

        foreach (var d in company.Departments)
        {
            d.Id = Guid.NewGuid();
            foreach (var o in d.Offices)
            {
                o.Id = Guid.NewGuid();
            }
        }
        
        _context.Companies.Add(company);
    }

    public void AddDepartment(Guid comapnyId, Department department)
    {
        if(comapnyId == Guid.Empty)
            throw new ArgumentNullException(nameof(comapnyId));
        
        if (department == null)
            throw new ArgumentNullException(nameof(department));
        
        department.Id = Guid.NewGuid();

        foreach (var o in department.Offices)
        {
            o.Id = Guid.NewGuid();
        }

        department.CompanyId = comapnyId;
        
        _context.Departments.Add(department);
    }

    public void AddOffice(Guid departmentId, Office office)
    {
        if (departmentId == Guid.Empty)
            throw new ArgumentNullException(nameof(departmentId));
        
        if(office == null)
            throw new ArgumentNullException(nameof(office));
        
        office.DepartmentId = departmentId;
        office.Id = Guid.NewGuid();
        
        _context.Offices.Add(office);
    }

    public void UpdateCompany(Company company)
    {
        if(company == null)
            throw new ArgumentNullException(nameof(company));
        
        _context.Companies.Update(company);
    }

    public void UpdateDepartment(Department department)
    {
        if(department == null)
            throw new ArgumentNullException(nameof(department));
            
        _context.Departments.Update(department);
    }

    public void UpdateOffice(Office office)
    {
        if (office == null)
            throw new ArgumentNullException(nameof(office));
        
        _context.Offices.Update(office);
    }

    public void DeleteCompany(Company company)
    {
        if(company == null)
            throw new ArgumentNullException(nameof(company));
        
        _context.Companies.Remove(company);
    }

    public void DeleteDepartment(Department department)
    {
        if(department == null)
            throw new ArgumentNullException(nameof(department));
        
        _context.Departments.Remove(department);
    }

    public void DeleteOffice(Office office)
    {
        if(office == null)
            throw new ArgumentNullException(nameof(office));
        
        _context.Offices.Remove(office);
    }

    public async Task<bool> CompanyExistsAsync(Guid companyId)
    {
        if(companyId == Guid.Empty)
            throw new ArgumentNullException(nameof(companyId));

        return await _context.Companies.AnyAsync(c => c.Id == companyId);
    }

    public async Task<bool> SaveAsync()
    {
        return (await _context.SaveChangesAsync() >= 0);
    }
}