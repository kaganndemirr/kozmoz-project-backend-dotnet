using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class migration_post_vote_type_class : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostVoteType",
                table: "PostVotes");

            migrationBuilder.DropColumn(
                name: "CommentVoteType",
                table: "CommentVotes");

            migrationBuilder.AddColumn<short>(
                name: "PostVoteTypeId",
                table: "PostVotes",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "CommentVoteTypeId",
                table: "CommentVotes",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.CreateTable(
                name: "Vote",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vote", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostVotes_PostVoteTypeId",
                table: "PostVotes",
                column: "PostVoteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentVotes_CommentVoteTypeId",
                table: "CommentVotes",
                column: "CommentVoteTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentVotes_Vote_CommentVoteTypeId",
                table: "CommentVotes",
                column: "CommentVoteTypeId",
                principalTable: "Vote",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostVotes_Vote_PostVoteTypeId",
                table: "PostVotes",
                column: "PostVoteTypeId",
                principalTable: "Vote",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentVotes_Vote_CommentVoteTypeId",
                table: "CommentVotes");

            migrationBuilder.DropForeignKey(
                name: "FK_PostVotes_Vote_PostVoteTypeId",
                table: "PostVotes");

            migrationBuilder.DropTable(
                name: "Vote");

            migrationBuilder.DropIndex(
                name: "IX_PostVotes_PostVoteTypeId",
                table: "PostVotes");

            migrationBuilder.DropIndex(
                name: "IX_CommentVotes_CommentVoteTypeId",
                table: "CommentVotes");

            migrationBuilder.DropColumn(
                name: "PostVoteTypeId",
                table: "PostVotes");

            migrationBuilder.DropColumn(
                name: "CommentVoteTypeId",
                table: "CommentVotes");

            migrationBuilder.AddColumn<int>(
                name: "PostVoteType",
                table: "PostVotes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CommentVoteType",
                table: "CommentVotes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
