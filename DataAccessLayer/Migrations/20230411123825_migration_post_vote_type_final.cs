using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class migration_post_vote_type_final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentVotes_Vote_CommentVoteTypeId",
                table: "CommentVotes");

            migrationBuilder.DropForeignKey(
                name: "FK_PostVotes_Vote_PostVoteTypeId",
                table: "PostVotes");

            migrationBuilder.RenameColumn(
                name: "PostVoteTypeId",
                table: "PostVotes",
                newName: "VoteId");

            migrationBuilder.RenameIndex(
                name: "IX_PostVotes_PostVoteTypeId",
                table: "PostVotes",
                newName: "IX_PostVotes_VoteId");

            migrationBuilder.RenameColumn(
                name: "CommentVoteTypeId",
                table: "CommentVotes",
                newName: "VoteId");

            migrationBuilder.RenameIndex(
                name: "IX_CommentVotes_CommentVoteTypeId",
                table: "CommentVotes",
                newName: "IX_CommentVotes_VoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentVotes_Vote_VoteId",
                table: "CommentVotes",
                column: "VoteId",
                principalTable: "Vote",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostVotes_Vote_VoteId",
                table: "PostVotes",
                column: "VoteId",
                principalTable: "Vote",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentVotes_Vote_VoteId",
                table: "CommentVotes");

            migrationBuilder.DropForeignKey(
                name: "FK_PostVotes_Vote_VoteId",
                table: "PostVotes");

            migrationBuilder.RenameColumn(
                name: "VoteId",
                table: "PostVotes",
                newName: "PostVoteTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_PostVotes_VoteId",
                table: "PostVotes",
                newName: "IX_PostVotes_PostVoteTypeId");

            migrationBuilder.RenameColumn(
                name: "VoteId",
                table: "CommentVotes",
                newName: "CommentVoteTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_CommentVotes_VoteId",
                table: "CommentVotes",
                newName: "IX_CommentVotes_CommentVoteTypeId");

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
    }
}
