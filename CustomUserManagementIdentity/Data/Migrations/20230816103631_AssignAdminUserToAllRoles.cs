using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomUserManagementIdentity.Data.Migrations
{
    public partial class AssignAdminUserToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[UserRoles] (UserId,RoleId) SELECT '3686dfee-89be-40cd-a361-796f3a9dcba4' , Id FROM [security].[Roles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[UserRoles] WHERE UserId='3686dfee-89be-40cd-a361-796f3a9dcba4'");
        }
    }
}
