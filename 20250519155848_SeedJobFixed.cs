using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elv_Workforce_Solution.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedJobFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Company", "Description", "EmployerEmail", "JobType", "Location", "PostedDate", "Salary", "Title" },
                values: new object[] { 1, "Tech Corp", "Develop and maintain web applications.", null, "Full-time", "Thapathali, Kathmandu", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 80000, "Software Engineer" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
