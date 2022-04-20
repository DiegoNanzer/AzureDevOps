using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AzureDevOps.Infra.Migrations
{
    public partial class ChangeTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Smurves",
                table: "Smurves");

            migrationBuilder.RenameTable(
                name: "Smurves",
                newName: "Smurfs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Smurfs",
                table: "Smurfs",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Smurfs",
                table: "Smurfs");

            migrationBuilder.RenameTable(
                name: "Smurfs",
                newName: "Smurves");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Smurves",
                table: "Smurves",
                column: "Id");
        }
    }
}
