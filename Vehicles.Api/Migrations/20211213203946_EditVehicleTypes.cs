using Microsoft.EntityFrameworkCore.Migrations;

namespace Vehicles.Api.Migrations
{
    public partial class EditVehicleTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VehiclesTypes",
                table: "VehiclesTypes");

            migrationBuilder.RenameTable(
                name: "VehiclesTypes",
                newName: "VehicleTypes");

            migrationBuilder.RenameIndex(
                name: "IX_VehiclesTypes_Description",
                table: "VehicleTypes",
                newName: "IX_VehicleTypes_Description");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleTypes",
                table: "VehicleTypes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleTypes",
                table: "VehicleTypes");

            migrationBuilder.RenameTable(
                name: "VehicleTypes",
                newName: "VehiclesTypes");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleTypes_Description",
                table: "VehiclesTypes",
                newName: "IX_VehiclesTypes_Description");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehiclesTypes",
                table: "VehiclesTypes",
                column: "Id");
        }
    }
}
