using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GuideApp.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("88f6b39b-0661-4ed7-8532-7b968958fa20"), "Apple" },
                    { new Guid("a833d2d5-0f38-4601-83ca-b86a7501f461"), "Microsoft" },
                    { new Guid("c2a41658-3fcc-4694-b0c2-3b156aff4c9c"), "Yandex" },
                    { new Guid("e6a2dec0-071c-4350-a150-ca80cd1d369e"), "Google" },
                    { new Guid("fe4636e2-ef3d-4368-9dbd-026d6298dfda"), "VK" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CompanyId", "Name" },
                values: new object[,]
                {
                    { new Guid("0f47e2d1-1b57-4cb4-ae88-0a1b3f24f876"), new Guid("88f6b39b-0661-4ed7-8532-7b968958fa20"), "Департамент инноваций" },
                    { new Guid("20b1edc4-34c4-4052-b4f3-143e558ed1c5"), new Guid("c2a41658-3fcc-4694-b0c2-3b156aff4c9c"), "Департамент онлайн-сервисов" },
                    { new Guid("31b8c9f2-9f52-4e32-b9ae-bcb02e8a91b2"), new Guid("a833d2d5-0f38-4601-83ca-b86a7501f461"), "Департамент искусственного интеллекта" },
                    { new Guid("7f4fbd5b-80c2-42fc-89a0-94a0b4e7c37a"), new Guid("e6a2dec0-071c-4350-a150-ca80cd1d369e"), "Департамент поисковых технологий" },
                    { new Guid("9a56e540-f8ea-47b1-8824-1d0f6e57429e"), new Guid("88f6b39b-0661-4ed7-8532-7b968958fa20"), "Департамент дизайна" },
                    { new Guid("a384db73-2fd4-4657-9b25-74a1fd0fe31d"), new Guid("fe4636e2-ef3d-4368-9dbd-026d6298dfda"), "Департамент контента и медиаплатформ" },
                    { new Guid("ad47bfb1-8baf-4e41-b9c4-407e6b34c159"), new Guid("a833d2d5-0f38-4601-83ca-b86a7501f461"), "Департамент поддержки пользователей" },
                    { new Guid("b6a8fa34-9821-4d38-bdea-c03f4e90f7ad"), new Guid("fe4636e2-ef3d-4368-9dbd-026d6298dfda"), "Департамент безопасности" },
                    { new Guid("b7a21d20-55cf-49f6-bf3e-02f5a7ef5653"), new Guid("a833d2d5-0f38-4601-83ca-b86a7501f461"), "Департамент программного обеспечения" },
                    { new Guid("b80c1ed8-c0b7-45a4-bb93-98b0a6b0e142"), new Guid("c2a41658-3fcc-4694-b0c2-3b156aff4c9c"), "Департамент поиска и аналитики" },
                    { new Guid("c1bfe5f3-0e35-4b7e-98a0-88b2e1b02c33"), new Guid("88f6b39b-0661-4ed7-8532-7b968958fa20"), "Департамент маркетинга" },
                    { new Guid("c68aeb41-d4ff-49b2-b68a-74ab123bfb3c"), new Guid("e6a2dec0-071c-4350-a150-ca80cd1d369e"), "Департамент рекламы и аналитики" },
                    { new Guid("d25109a6-8f34-4f18-b13e-5f9bdf732374"), new Guid("fe4636e2-ef3d-4368-9dbd-026d6298dfda"), "Департамент социальных сетей" },
                    { new Guid("d7c917c9-4762-4ad1-a6e1-3d6b604d733e"), new Guid("c2a41658-3fcc-4694-b0c2-3b156aff4c9c"), "Департамент медиасервисов" },
                    { new Guid("e9b8d1ab-c53c-49be-8e5c-b19f6d58a144"), new Guid("e6a2dec0-071c-4350-a150-ca80cd1d369e"), "Департамент облачных сервисов" }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { new Guid("09c78b26-5074-4935-b32f-f86f09e4c563"), new Guid("c68aeb41-d4ff-49b2-b68a-74ab123bfb3c"), "Отдел разработки рекламных инструментов" },
                    { new Guid("0aa1c4d4-3481-42be-9f24-f050ef7b751b"), new Guid("20b1edc4-34c4-4052-b4f3-143e558ed1c5"), "Отдел разработки картографических решений" },
                    { new Guid("0d8e2fb1-5804-4de6-860b-38e9e1b126fd"), new Guid("c1bfe5f3-0e35-4b7e-98a0-88b2e1b02c33"), "Отдел креативных кампаний" },
                    { new Guid("0e8f5799-58bc-4df5-9878-3b6e7f6c857f"), new Guid("ad47bfb1-8baf-4e41-b9c4-407e6b34c159"), "Отдел технической поддержки" },
                    { new Guid("1ab227bb-3d3c-4e54-8463-580bd6cb2d42"), new Guid("9a56e540-f8ea-47b1-8824-1d0f6e57429e"), "Отдел промышленного дизайна" },
                    { new Guid("1d0c7c33-7b7e-4525-9908-7e991fb26a6a"), new Guid("d25109a6-8f34-4f18-b13e-5f9bdf732374"), "Отдел веб-разработки" },
                    { new Guid("2b8de14e-75e9-4dc3-b4b3-30272ab7cd6f"), new Guid("0f47e2d1-1b57-4cb4-ae88-0a1b3f24f876"), "Отдел исследований и разработок продуктов" },
                    { new Guid("2f631f73-8903-47b2-85a1-5187b25a5299"), new Guid("c68aeb41-d4ff-49b2-b68a-74ab123bfb3c"), "Отдел анализа данных" },
                    { new Guid("319b7a4f-652d-4f32-b934-b5127fa563a5"), new Guid("b80c1ed8-c0b7-45a4-bb93-98b0a6b0e142"), "Отдел алгоритмов поиска" },
                    { new Guid("3bfa5c79-44da-4637-8db8-3127e8b72c24"), new Guid("b7a21d20-55cf-49f6-bf3e-02f5a7ef5653"), "Отдел разработки облачных решений" },
                    { new Guid("3c506b5f-3157-4aef-bf99-83b2dd4dfce4"), new Guid("d7c917c9-4762-4ad1-a6e1-3d6b604d733e"), "Отдел музыкальных сервисов" },
                    { new Guid("41b6a5a3-2797-4828-bf07-2d0c7a6e340b"), new Guid("b7a21d20-55cf-49f6-bf3e-02f5a7ef5653"), "Отдел разработки операционных систем" },
                    { new Guid("4d18e3ec-6bfa-485d-b8d5-9fba83dc7e75"), new Guid("c1bfe5f3-0e35-4b7e-98a0-88b2e1b02c33"), "Отдел цифрового маркетинга" },
                    { new Guid("572a3128-76c2-4b9a-93db-b6b31e22c7f5"), new Guid("b6a8fa34-9821-4d38-bdea-c03f4e90f7ad"), "Отдел мониторинга и реагирования на инциденты" },
                    { new Guid("5b39067a-235b-46e2-b68e-facb66b0f70b"), new Guid("e9b8d1ab-c53c-49be-8e5c-b19f6d58a144"), "Отдел инфраструктуры хранения данных" },
                    { new Guid("6b42db18-cb59-45c6-a144-e1a12d306cb1"), new Guid("31b8c9f2-9f52-4e32-b9ae-bcb02e8a91b2"), "Отдел машинного обучения" },
                    { new Guid("7ad631b8-9783-4c19-a7db-e5fd38476fd4"), new Guid("d25109a6-8f34-4f18-b13e-5f9bdf732374"), "Отдел разработки мобильных приложений" },
                    { new Guid("7cfa34f4-2c37-492f-bb91-e267d7e5589f"), new Guid("7f4fbd5b-80c2-42fc-89a0-94a0b4e7c37a"), "Отдел пользовательских интерфейсов поиска" },
                    { new Guid("7e4e6f3f-1d34-4814-9b45-d5a0c814e716"), new Guid("0f47e2d1-1b57-4cb4-ae88-0a1b3f24f876"), "Отдел анализа потребительских трендов" },
                    { new Guid("8d7c591d-80d1-4635-a807-120b2fe5ec49"), new Guid("20b1edc4-34c4-4052-b4f3-143e558ed1c5"), "Отдел развития сервисов доставки" },
                    { new Guid("91fc03a4-5667-49f4-aaa5-e4a39929f39f"), new Guid("e9b8d1ab-c53c-49be-8e5c-b19f6d58a144"), "Отдел управления вычислительными мощностями" },
                    { new Guid("9b420fea-c3e3-4d7a-9a9f-79abbeccf94f"), new Guid("b6a8fa34-9821-4d38-bdea-c03f4e90f7ad"), "Отдел защиты данных пользователей" },
                    { new Guid("bb137dd8-7b15-4a3b-a715-d8ed7ed2a2eb"), new Guid("ad47bfb1-8baf-4e41-b9c4-407e6b34c159"), "Отдел управления контентом знаний" },
                    { new Guid("d29d56c8-2834-44b7-b94a-9b73cf4b8b10"), new Guid("9a56e540-f8ea-47b1-8824-1d0f6e57429e"), "Отдел UX/UI дизайна" },
                    { new Guid("d51f6231-9583-4d2e-bf20-b65fca03713d"), new Guid("a384db73-2fd4-4657-9b25-74a1fd0fe31d"), "Отдел поддержки музыкальных проектов" },
                    { new Guid("d96d0d3d-feca-4d49-93d4-5a0c4f073570"), new Guid("31b8c9f2-9f52-4e32-b9ae-bcb02e8a91b2"), "Отдел обработки естественного языка" },
                    { new Guid("e2e51f75-c65c-4c0a-8b48-f6c1847c57b6"), new Guid("d7c917c9-4762-4ad1-a6e1-3d6b604d733e"), "Отдел видеосервисов" },
                    { new Guid("e8d3a1c2-c5c7-4d72-8af4-f6ad6c8a6fdd"), new Guid("b80c1ed8-c0b7-45a4-bb93-98b0a6b0e142"), "Отдел аналитики больших данных" },
                    { new Guid("f1b0192e-2c02-49c6-9552-8b0bfc8e41f0"), new Guid("7f4fbd5b-80c2-42fc-89a0-94a0b4e7c37a"), "Отдел алгоритмов ранжирования" },
                    { new Guid("ff1d9e75-3c67-4d21-b782-e9351ff5ab6c"), new Guid("a384db73-2fd4-4657-9b25-74a1fd0fe31d"), "Отдел создания и курирования видеоконтента" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("09c78b26-5074-4935-b32f-f86f09e4c563"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("0aa1c4d4-3481-42be-9f24-f050ef7b751b"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("0d8e2fb1-5804-4de6-860b-38e9e1b126fd"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("0e8f5799-58bc-4df5-9878-3b6e7f6c857f"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("1ab227bb-3d3c-4e54-8463-580bd6cb2d42"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("1d0c7c33-7b7e-4525-9908-7e991fb26a6a"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("2b8de14e-75e9-4dc3-b4b3-30272ab7cd6f"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("2f631f73-8903-47b2-85a1-5187b25a5299"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("319b7a4f-652d-4f32-b934-b5127fa563a5"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("3bfa5c79-44da-4637-8db8-3127e8b72c24"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("3c506b5f-3157-4aef-bf99-83b2dd4dfce4"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("41b6a5a3-2797-4828-bf07-2d0c7a6e340b"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("4d18e3ec-6bfa-485d-b8d5-9fba83dc7e75"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("572a3128-76c2-4b9a-93db-b6b31e22c7f5"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("5b39067a-235b-46e2-b68e-facb66b0f70b"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("6b42db18-cb59-45c6-a144-e1a12d306cb1"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("7ad631b8-9783-4c19-a7db-e5fd38476fd4"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("7cfa34f4-2c37-492f-bb91-e267d7e5589f"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("7e4e6f3f-1d34-4814-9b45-d5a0c814e716"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("8d7c591d-80d1-4635-a807-120b2fe5ec49"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("91fc03a4-5667-49f4-aaa5-e4a39929f39f"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("9b420fea-c3e3-4d7a-9a9f-79abbeccf94f"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("bb137dd8-7b15-4a3b-a715-d8ed7ed2a2eb"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("d29d56c8-2834-44b7-b94a-9b73cf4b8b10"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("d51f6231-9583-4d2e-bf20-b65fca03713d"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("d96d0d3d-feca-4d49-93d4-5a0c4f073570"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("e2e51f75-c65c-4c0a-8b48-f6c1847c57b6"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("e8d3a1c2-c5c7-4d72-8af4-f6ad6c8a6fdd"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("f1b0192e-2c02-49c6-9552-8b0bfc8e41f0"));

            migrationBuilder.DeleteData(
                table: "Offices",
                keyColumn: "Id",
                keyValue: new Guid("ff1d9e75-3c67-4d21-b782-e9351ff5ab6c"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0f47e2d1-1b57-4cb4-ae88-0a1b3f24f876"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("20b1edc4-34c4-4052-b4f3-143e558ed1c5"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("31b8c9f2-9f52-4e32-b9ae-bcb02e8a91b2"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7f4fbd5b-80c2-42fc-89a0-94a0b4e7c37a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9a56e540-f8ea-47b1-8824-1d0f6e57429e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a384db73-2fd4-4657-9b25-74a1fd0fe31d"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ad47bfb1-8baf-4e41-b9c4-407e6b34c159"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b6a8fa34-9821-4d38-bdea-c03f4e90f7ad"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b7a21d20-55cf-49f6-bf3e-02f5a7ef5653"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b80c1ed8-c0b7-45a4-bb93-98b0a6b0e142"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("c1bfe5f3-0e35-4b7e-98a0-88b2e1b02c33"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("c68aeb41-d4ff-49b2-b68a-74ab123bfb3c"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d25109a6-8f34-4f18-b13e-5f9bdf732374"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d7c917c9-4762-4ad1-a6e1-3d6b604d733e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e9b8d1ab-c53c-49be-8e5c-b19f6d58a144"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("88f6b39b-0661-4ed7-8532-7b968958fa20"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("a833d2d5-0f38-4601-83ca-b86a7501f461"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("c2a41658-3fcc-4694-b0c2-3b156aff4c9c"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("e6a2dec0-071c-4350-a150-ca80cd1d369e"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("fe4636e2-ef3d-4368-9dbd-026d6298dfda"));
        }
    }
}
