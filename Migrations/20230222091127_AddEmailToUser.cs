using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtRepositorySystem.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

           

            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "QnA",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Prompt",
                table: "QnA",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "QnA",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

           

            migrationBuilder.DropColumn(
                name: "Answer",
                table: "QnA");

            migrationBuilder.DropColumn(
                name: "Prompt",
                table: "QnA");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "QnA");

            
        }
    }
}
