using GuideApp.WebApp.Models.Entities;

namespace GuideApp.WebApp.Services;

public interface IRepository
{
    Task<IEnumerable<Company>> GetCompaniesAsync();
    Task<IEnumerable<Department>> GetDepartmentsAsync(Guid companyId);
    Task<IEnumerable<Office>> GetOfficesAsync(Guid departmentId);
    
    Task<Company> GetCompanyAsync(Guid companyId);
    Task<Department> GetDepartmentAsync(Guid companyId, Guid departmentId);
    Task<Office> GetOfficeAsync(Guid departmentId, Guid officeId);
    
    void AddCompany(Company company);
    void AddDepartment(Guid companyId, Department department);
    void AddOffice(Guid departmentId, Office office);
    
    void UpdateCompany(Company company);
    void UpdateDepartment(Department department);
    void UpdateOffice(Office office);
    
    void DeleteCompany(Company company);
    void DeleteDepartment(Department department);
    void DeleteOffice(Office office);
    
    Task<bool> CompanyExistsAsync(Guid companyId);
    Task<bool> SaveAsync();
}