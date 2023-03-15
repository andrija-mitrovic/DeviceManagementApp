using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    public partial class ChangeIndexFilterOnDeviceTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DeviceTypes_ParentId_Name",
                table: "DeviceTypes");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceTypes_Name",
                table: "DeviceTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceTypes_ParentId",
                table: "DeviceTypes",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DeviceTypes_Name",
                table: "DeviceTypes");

            migrationBuilder.DropIndex(
                name: "IX_DeviceTypes_ParentId",
                table: "DeviceTypes");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceTypes_ParentId_Name",
                table: "DeviceTypes",
                columns: new[] { "ParentId", "Name" },
                unique: true,
                filter: "ParentId IS NOT NULL");
        }
    }
}
