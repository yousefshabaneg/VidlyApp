namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9663ac4a-db80-4abc-901b-7868554d45e6', N'admin@vidly.com', 0, N'AGrldI4insBwIW7NBVdV8XpTX9a/jhgkazdNX7oq+An/L6wEtUeMYY9k6kCLUrRgXw==', N'4a870bac-f289-4984-ab0c-46a5a48efba4', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cab6ea65-5e11-489f-9bd5-c1b0c13244c5', N'guest@vidly.com', 0, N'AFQ+C84XVbjFeJtqufwksWGkkaknm02+/W8CWUNo2LqecJtlRqWzyR6egmhJyYhGqg==', N'2c3fc951-11e6-49b1-b3cb-81271eb3bde5', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5ea0a5a3-6a9c-4d3a-916c-8ec8935fce35', N'CanManageMovies')
    
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9663ac4a-db80-4abc-901b-7868554d45e6', N'5ea0a5a3-6a9c-4d3a-916c-8ec8935fce35')

");


        }

        public override void Down()
        {
        }
    }
}
