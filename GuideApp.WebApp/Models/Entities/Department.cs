namespace GuideApp.WebApp.Models.Entities;

public class Department
{
    public Guid Id { get; set; }
    public string? Name { get; set; }

    public Company Company { get; set; } = null;
    public Guid CompanyId { get; set; }
    
    public ICollection<Office>? Offices { get; set; } 
        = new List<Office>();

    // public Department(string name)
    // {
    //     Name = name;
    // }
}