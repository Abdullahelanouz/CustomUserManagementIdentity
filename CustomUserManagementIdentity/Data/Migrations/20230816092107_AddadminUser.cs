using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomUserManagementIdentity.Data.Migrations
{
    public partial class AddadminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'8e2a8634-8454-4221-8510-c7e14acd2392', N'abdullahelanouz', N'ABDULLAHELANOUZ', N'abdullahelanouz@gmail.com', N'ABDULLAHELANOUZ@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAELMAzR5Bx+ULPmIuLFiT/G+C/weeT/9KBjze9n6YKIJpl/BmdAVx0gnnlNXzKie2ow==', N'BH6WDOJ76DXCPF7LP4YPMJB3ROL7BVBD', N'b0452d8f-10cb-46db-8da9-3d2d213826db', N'01200240708', 0, 0, NULL, 1, 0, N'Abdullah', N'Elanouz', Null");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Users] WHERE Id = '3686dfee-89be-40cd-a361-796f3a9dcba4'");
        }
    }
}
