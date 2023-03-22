using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APlus.Migrations
{
    /// <inheritdoc />
    public partial class FixUserAndSubscriptionRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_SubscriptionUsers_UserId",
                table: "Subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Subscriptions");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_SubscriptionUserId",
                table: "Subscriptions",
                column: "SubscriptionUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_SubscriptionUsers_SubscriptionUserId",
                table: "Subscriptions",
                column: "SubscriptionUserId",
                principalTable: "SubscriptionUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_SubscriptionUsers_SubscriptionUserId",
                table: "Subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptions_SubscriptionUserId",
                table: "Subscriptions");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Subscriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_SubscriptionUsers_UserId",
                table: "Subscriptions",
                column: "UserId",
                principalTable: "SubscriptionUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
