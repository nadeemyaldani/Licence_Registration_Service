using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APlus.Migrations
{
    /// <inheritdoc />
    public partial class FixUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_SubscriptionUsers_SubscriptionUserId",
                table: "Subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptions_SubscriptionUserId",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "SubscriptionUserId",
                table: "Subscriptions");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionUsers_SubscriptionId",
                table: "SubscriptionUsers",
                column: "SubscriptionId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscriptionUsers_Subscriptions_SubscriptionId",
                table: "SubscriptionUsers",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubscriptionUsers_Subscriptions_SubscriptionId",
                table: "SubscriptionUsers");

            migrationBuilder.DropIndex(
                name: "IX_SubscriptionUsers_SubscriptionId",
                table: "SubscriptionUsers");

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionUserId",
                table: "Subscriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
