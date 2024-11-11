using GuideApp.WebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace GuideApp.WebApp.DbContexts;

public class CompanyInfoContext : DbContext
{
    public CompanyInfoContext(DbContextOptions<CompanyInfoContext> options)
        : base(options)
    { }

    public DbSet<Company> Companies { get; set; } = null;
    public DbSet<Department> Departments { get; set; } = null;
    public DbSet<Office> Offices { get; set; } = null;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Company>().HasData(
            new Company
            {
                Id = Guid.Parse("88f6b39b-0661-4ed7-8532-7b968958fa20"),
                Name = "Apple"
            },
            new Company
            {
                Id = Guid.Parse("a833d2d5-0f38-4601-83ca-b86a7501f461"),
                Name = "Microsoft"
            },
            new Company
            {
                Id = Guid.Parse("e6a2dec0-071c-4350-a150-ca80cd1d369e"),
                Name = "Google"
            },
            new Company
            {
                Id = Guid.Parse("c2a41658-3fcc-4694-b0c2-3b156aff4c9c"),
                Name = "Yandex"
            },
            new Company
            {
                Id = Guid.Parse("fe4636e2-ef3d-4368-9dbd-026d6298dfda"),
                Name = "VK"
            }
        );

        modelBuilder.Entity<Department>().HasData(
            // Apple
            new Department
            {
                Id = Guid.Parse("0f47e2d1-1b57-4cb4-ae88-0a1b3f24f876"),
                Name = "Департамент инноваций",
                CompanyId = Guid.Parse("88f6b39b-0661-4ed7-8532-7b968958fa20")
            },
            new Department
            {
                Id = Guid.Parse("9a56e540-f8ea-47b1-8824-1d0f6e57429e"),
                Name = "Департамент дизайна",
                CompanyId = Guid.Parse("88f6b39b-0661-4ed7-8532-7b968958fa20")
            },
            new Department
            {
                Id = Guid.Parse("c1bfe5f3-0e35-4b7e-98a0-88b2e1b02c33"),
                Name = "Департамент маркетинга",
                CompanyId = Guid.Parse("88f6b39b-0661-4ed7-8532-7b968958fa20")
            },
            
            // Microsoft
            new Department
            {
                Id = Guid.Parse("b7a21d20-55cf-49f6-bf3e-02f5a7ef5653"),
                Name = "Департамент программного обеспечения",
                CompanyId = Guid.Parse("a833d2d5-0f38-4601-83ca-b86a7501f461")
            },
            new Department
            {
                Id = Guid.Parse("31b8c9f2-9f52-4e32-b9ae-bcb02e8a91b2"),
                Name = "Департамент искусственного интеллекта",
                CompanyId = Guid.Parse("a833d2d5-0f38-4601-83ca-b86a7501f461")
            },
            new Department
            {
                Id = Guid.Parse("ad47bfb1-8baf-4e41-b9c4-407e6b34c159"),
                Name = "Департамент поддержки пользователей",
                CompanyId = Guid.Parse("a833d2d5-0f38-4601-83ca-b86a7501f461")
            },
            
            // Google
            new Department
            {
                Id = Guid.Parse("7f4fbd5b-80c2-42fc-89a0-94a0b4e7c37a"),
                Name = "Департамент поисковых технологий",
                CompanyId = Guid.Parse("e6a2dec0-071c-4350-a150-ca80cd1d369e")   
            },
            new Department
            {
                Id = Guid.Parse("e9b8d1ab-c53c-49be-8e5c-b19f6d58a144"),
                Name = "Департамент облачных сервисов",
                CompanyId = Guid.Parse("e6a2dec0-071c-4350-a150-ca80cd1d369e")
            },
            new Department
            {
                Id = Guid.Parse("c68aeb41-d4ff-49b2-b68a-74ab123bfb3c"),
                Name = "Департамент рекламы и аналитики",
                CompanyId = Guid.Parse("e6a2dec0-071c-4350-a150-ca80cd1d369e")
            },
            
            // Yandex
            new Department
            {
                Id = Guid.Parse("20b1edc4-34c4-4052-b4f3-143e558ed1c5"),
                Name = "Департамент онлайн-сервисов",
                CompanyId = Guid.Parse("c2a41658-3fcc-4694-b0c2-3b156aff4c9c")   
            },
            new Department
            {
                Id = Guid.Parse("b80c1ed8-c0b7-45a4-bb93-98b0a6b0e142"),
                Name = "Департамент поиска и аналитики",
                CompanyId = Guid.Parse("c2a41658-3fcc-4694-b0c2-3b156aff4c9c")
            },
            new Department
            {
                Id = Guid.Parse("d7c917c9-4762-4ad1-a6e1-3d6b604d733e"),
                Name = "Департамент медиасервисов",
                CompanyId = Guid.Parse("c2a41658-3fcc-4694-b0c2-3b156aff4c9c")
            },
            
            // VK
            new Department
            {
                Id = Guid.Parse("d25109a6-8f34-4f18-b13e-5f9bdf732374"),
                Name = "Департамент социальных сетей",
                CompanyId = Guid.Parse("fe4636e2-ef3d-4368-9dbd-026d6298dfda")
            },
            new Department
            {
                Id = Guid.Parse("a384db73-2fd4-4657-9b25-74a1fd0fe31d"),
                Name = "Департамент контента и медиаплатформ",
                CompanyId = Guid.Parse("fe4636e2-ef3d-4368-9dbd-026d6298dfda")
            },
            new Department
            {
                Id = Guid.Parse("b6a8fa34-9821-4d38-bdea-c03f4e90f7ad"),
                Name = "Департамент безопасности",
                CompanyId = Guid.Parse("fe4636e2-ef3d-4368-9dbd-026d6298dfda")
            }
        );

        modelBuilder.Entity<Office>().HasData(
            //Apple
            new Office
            {
                Id = Guid.Parse("2b8de14e-75e9-4dc3-b4b3-30272ab7cd6f"),
                Name = "Отдел исследований и разработок продуктов",
                DepartmentId = Guid.Parse("0f47e2d1-1b57-4cb4-ae88-0a1b3f24f876")
            },
            new Office
            {
                Id = Guid.Parse("7e4e6f3f-1d34-4814-9b45-d5a0c814e716"),
                Name = "Отдел анализа потребительских трендов",
                DepartmentId = Guid.Parse("0f47e2d1-1b57-4cb4-ae88-0a1b3f24f876")
            },
            new Office
            {
                Id = Guid.Parse("d29d56c8-2834-44b7-b94a-9b73cf4b8b10"),
                Name = "Отдел UX/UI дизайна",
                DepartmentId = Guid.Parse("9a56e540-f8ea-47b1-8824-1d0f6e57429e")
            },
            new Office
            {
                Id = Guid.Parse("1ab227bb-3d3c-4e54-8463-580bd6cb2d42"),
                Name = "Отдел промышленного дизайна",
                DepartmentId = Guid.Parse("9a56e540-f8ea-47b1-8824-1d0f6e57429e")
            },
            new Office
            {
                Id = Guid.Parse("4d18e3ec-6bfa-485d-b8d5-9fba83dc7e75"),
                Name = "Отдел цифрового маркетинга",
                DepartmentId = Guid.Parse("c1bfe5f3-0e35-4b7e-98a0-88b2e1b02c33")
            },
            new Office
            {
                Id = Guid.Parse("0d8e2fb1-5804-4de6-860b-38e9e1b126fd"),
                Name = "Отдел креативных кампаний",
                DepartmentId = Guid.Parse("c1bfe5f3-0e35-4b7e-98a0-88b2e1b02c33")
            },
            
            //Microsoft
            new Office
            {
                Id = Guid.Parse("41b6a5a3-2797-4828-bf07-2d0c7a6e340b"),
                Name = "Отдел разработки операционных систем",
                DepartmentId = Guid.Parse("b7a21d20-55cf-49f6-bf3e-02f5a7ef5653")
            },
            new Office
            {
                Id = Guid.Parse("3bfa5c79-44da-4637-8db8-3127e8b72c24"),
                Name = "Отдел разработки облачных решений",
                DepartmentId = Guid.Parse("b7a21d20-55cf-49f6-bf3e-02f5a7ef5653")
            },
            new Office
            {
                Id = Guid.Parse("d96d0d3d-feca-4d49-93d4-5a0c4f073570"),
                Name = "Отдел обработки естественного языка",
                DepartmentId = Guid.Parse("31b8c9f2-9f52-4e32-b9ae-bcb02e8a91b2")
            },
            new Office
            {
                Id = Guid.Parse("6b42db18-cb59-45c6-a144-e1a12d306cb1"),
                Name = "Отдел машинного обучения",
                DepartmentId = Guid.Parse("31b8c9f2-9f52-4e32-b9ae-bcb02e8a91b2")
            },
            new Office
            {
                Id = Guid.Parse("0e8f5799-58bc-4df5-9878-3b6e7f6c857f"),
                Name = "Отдел технической поддержки",
                DepartmentId = Guid.Parse("ad47bfb1-8baf-4e41-b9c4-407e6b34c159")
            },
            new Office
            {
                Id = Guid.Parse("bb137dd8-7b15-4a3b-a715-d8ed7ed2a2eb"),
                Name = "Отдел управления контентом знаний",
                DepartmentId = Guid.Parse("ad47bfb1-8baf-4e41-b9c4-407e6b34c159")
            },
            
            //Google
            new Office
            {
                Id = Guid.Parse("f1b0192e-2c02-49c6-9552-8b0bfc8e41f0"),
                Name = "Отдел алгоритмов ранжирования",
                DepartmentId = Guid.Parse("7f4fbd5b-80c2-42fc-89a0-94a0b4e7c37a")
            },
            new Office
            {
                Id = Guid.Parse("7cfa34f4-2c37-492f-bb91-e267d7e5589f"),
                Name = "Отдел пользовательских интерфейсов поиска",
                DepartmentId = Guid.Parse("7f4fbd5b-80c2-42fc-89a0-94a0b4e7c37a")
            },
            new Office
            {
                Id = Guid.Parse("5b39067a-235b-46e2-b68e-facb66b0f70b"),
                Name = "Отдел инфраструктуры хранения данных",
                DepartmentId = Guid.Parse("e9b8d1ab-c53c-49be-8e5c-b19f6d58a144")
            },
            new Office
            {
                Id = Guid.Parse("91fc03a4-5667-49f4-aaa5-e4a39929f39f"),
                Name = "Отдел управления вычислительными мощностями",
                DepartmentId = Guid.Parse("e9b8d1ab-c53c-49be-8e5c-b19f6d58a144")
            },
            new Office
            {
                Id = Guid.Parse("09c78b26-5074-4935-b32f-f86f09e4c563"),
                Name = "Отдел разработки рекламных инструментов",
                DepartmentId = Guid.Parse("c68aeb41-d4ff-49b2-b68a-74ab123bfb3c")
            },
            new Office
            {
                Id = Guid.Parse("2f631f73-8903-47b2-85a1-5187b25a5299"),
                Name = "Отдел анализа данных",
                DepartmentId = Guid.Parse("c68aeb41-d4ff-49b2-b68a-74ab123bfb3c")
            },
            
            //Yandex
            new Office
            {
                Id = Guid.Parse("8d7c591d-80d1-4635-a807-120b2fe5ec49"),
                Name = "Отдел развития сервисов доставки",
                DepartmentId = Guid.Parse("20b1edc4-34c4-4052-b4f3-143e558ed1c5")
            },
            new Office
            {
                Id = Guid.Parse("0aa1c4d4-3481-42be-9f24-f050ef7b751b"),
                Name = "Отдел разработки картографических решений",
                DepartmentId = Guid.Parse("20b1edc4-34c4-4052-b4f3-143e558ed1c5")
            },
            new Office
            {
                Id = Guid.Parse("319b7a4f-652d-4f32-b934-b5127fa563a5"),
                Name = "Отдел алгоритмов поиска",
                DepartmentId = Guid.Parse("b80c1ed8-c0b7-45a4-bb93-98b0a6b0e142")
            },
            new Office
            {
                Id = Guid.Parse("e8d3a1c2-c5c7-4d72-8af4-f6ad6c8a6fdd"),
                Name = "Отдел аналитики больших данных",
                DepartmentId = Guid.Parse("b80c1ed8-c0b7-45a4-bb93-98b0a6b0e142")
            },
            new Office
            {
                Id = Guid.Parse("3c506b5f-3157-4aef-bf99-83b2dd4dfce4"),
                Name = "Отдел музыкальных сервисов",
                DepartmentId = Guid.Parse("d7c917c9-4762-4ad1-a6e1-3d6b604d733e")
            },
            new Office
            {
                Id = Guid.Parse("e2e51f75-c65c-4c0a-8b48-f6c1847c57b6"),
                Name = "Отдел видеосервисов",
                DepartmentId = Guid.Parse("d7c917c9-4762-4ad1-a6e1-3d6b604d733e")
            },
            
            //VK
            new Office
            {
                Id = Guid.Parse("7ad631b8-9783-4c19-a7db-e5fd38476fd4"),
                Name = "Отдел разработки мобильных приложений",
                DepartmentId = Guid.Parse("d25109a6-8f34-4f18-b13e-5f9bdf732374")
            },
            new Office
            {
                Id = Guid.Parse("1d0c7c33-7b7e-4525-9908-7e991fb26a6a"),
                Name = "Отдел веб-разработки",
                DepartmentId = Guid.Parse("d25109a6-8f34-4f18-b13e-5f9bdf732374")
            },
            new Office
            {
                Id = Guid.Parse("ff1d9e75-3c67-4d21-b782-e9351ff5ab6c"),
                Name = "Отдел создания и курирования видеоконтента",
                DepartmentId = Guid.Parse("a384db73-2fd4-4657-9b25-74a1fd0fe31d")
            },
            new Office
            {
                Id = Guid.Parse("d51f6231-9583-4d2e-bf20-b65fca03713d"),
                Name = "Отдел поддержки музыкальных проектов",
                DepartmentId = Guid.Parse("a384db73-2fd4-4657-9b25-74a1fd0fe31d")
            },
            new Office
            {
                Id = Guid.Parse("9b420fea-c3e3-4d7a-9a9f-79abbeccf94f"),
                Name = "Отдел защиты данных пользователей",
                DepartmentId = Guid.Parse("b6a8fa34-9821-4d38-bdea-c03f4e90f7ad")
            },
            new Office
            {
                Id = Guid.Parse("572a3128-76c2-4b9a-93db-b6b31e22c7f5"),
                Name = "Отдел мониторинга и реагирования на инциденты",
                DepartmentId = Guid.Parse("b6a8fa34-9821-4d38-bdea-c03f4e90f7ad")
            }
        );
        
        base.OnModelCreating(modelBuilder);
    }
}