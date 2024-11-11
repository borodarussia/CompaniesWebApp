namespace GuideApp.WebApp.Models.Entities;

public class Office
{
    public Guid Id { get; set; }
    public string? Name { get; set; }

    public Department Department { get; set; } = null;
    public Guid DepartmentId { get; set; }

    // public Office(string name)
    // {
    //     Name = name;
    // }
}