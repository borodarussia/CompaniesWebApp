namespace GuideApp.WebApp.Models.Entities;

public class Company
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public ICollection<Department>? Departments { get; set; } 
        = new List<Department>();

    // public Company(string name)
    // {
    //     Name = name;
    // }
}