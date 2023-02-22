using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtRepositorySystem.Migrations
{
    /// <inheritdoc />
    public partial class initialMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeedbackForm",
                columns: table => new
                {
                    FeedbackFromId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackForm", x => x.FeedbackFromId);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    OptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.OptionId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userMode = table.Column<int>(type: "int", nullable: false),
                    ProfilePic = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "Art",
                columns: table => new
                {
                    ArtId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    FeedbackFormFeedbackFromId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    VisualArtShape = table.Column<int>(type: "int", nullable: true),
                    VisualArtType = table.Column<int>(type: "int", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Art", x => x.ArtId);
                    table.ForeignKey(
                        name: "FK_Art_FeedbackForm_FeedbackFormFeedbackFromId",
                        column: x => x.FeedbackFormFeedbackFromId,
                        principalTable: "FeedbackForm",
                        principalColumn: "FeedbackFromId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QnA",
                columns: table => new
                {
                    QnAId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeedbackFormFeedbackFromId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QnA", x => x.QnAId);
                    table.ForeignKey(
                        name: "FK_QnA_FeedbackForm_FeedbackFormFeedbackFromId",
                        column: x => x.FeedbackFormFeedbackFromId,
                        principalTable: "FeedbackForm",
                        principalColumn: "FeedbackFromId");
                });

            migrationBuilder.CreateTable(
                name: "Analytic",
                columns: table => new
                {
                    AnalyticId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Visibility = table.Column<bool>(type: "bit", nullable: false),
                    ArtId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analytic", x => x.AnalyticId);
                    table.ForeignKey(
                        name: "FK_Analytic_Art_ArtId",
                        column: x => x.ArtId,
                        principalTable: "Art",
                        principalColumn: "ArtId");
                });

            migrationBuilder.CreateTable(
                name: "ArtUser",
                columns: table => new
                {
                    ArtistsUserId = table.Column<int>(type: "int", nullable: false),
                    WorksArtId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtUser", x => new { x.ArtistsUserId, x.WorksArtId });
                    table.ForeignKey(
                        name: "FK_ArtUser_Art_WorksArtId",
                        column: x => x.WorksArtId,
                        principalTable: "Art",
                        principalColumn: "ArtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtUser_Users_ArtistsUserId",
                        column: x => x.ArtistsUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reactions",
                columns: table => new
                {
                    ReactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsumerUserId = table.Column<int>(type: "int", nullable: false),
                    ArtworkArtId = table.Column<int>(type: "int", nullable: false),
                    Response = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reactions", x => x.ReactionId);
                    table.ForeignKey(
                        name: "FK_Reactions_Art_ArtworkArtId",
                        column: x => x.ArtworkArtId,
                        principalTable: "Art",
                        principalColumn: "ArtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reactions_Users_ConsumerUserId",
                        column: x => x.ConsumerUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Analytic_ArtId",
                table: "Analytic",
                column: "ArtId");

            migrationBuilder.CreateIndex(
                name: "IX_Art_FeedbackFormFeedbackFromId",
                table: "Art",
                column: "FeedbackFormFeedbackFromId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtUser_WorksArtId",
                table: "ArtUser",
                column: "WorksArtId");

            migrationBuilder.CreateIndex(
                name: "IX_QnA_FeedbackFormFeedbackFromId",
                table: "QnA",
                column: "FeedbackFormFeedbackFromId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_ArtworkArtId",
                table: "Reactions",
                column: "ArtworkArtId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_ConsumerUserId",
                table: "Reactions",
                column: "ConsumerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserId1",
                table: "Users",
                column: "UserId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Analytic");

            migrationBuilder.DropTable(
                name: "ArtUser");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "QnA");

            migrationBuilder.DropTable(
                name: "Reactions");

            migrationBuilder.DropTable(
                name: "Art");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "FeedbackForm");
        }
    }
}
