namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b931d15c-a3ee-4ad7-a586-c5aa37fbb679', N'admin@vidly.com', 0, N'AG95T7Hyu5hjsH776lhFF1Hk/5vu84reyfk26Q0cGsVJCW5YxNRuivdycgu44AUVTg==', N'dc2937e8-590b-4bbb-8664-77c21393e4e6', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd13e7d77-070b-490b-bd6c-876857f35570', N'guest@vidly.com', 0, N'ALiM0tI0EwQ2pjdD0P8ZPQLJA0aECftLsD/e0qBBtKD8A1DG81Pn1fkvPP7pv7CnQw==', N'7ea0bbd2-d587-4ff0-a62e-12b79e5e303b', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f7c911f9-fa85-4620-bd8d-f229f246113a', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b931d15c-a3ee-4ad7-a586-c5aa37fbb679', N'f7c911f9-fa85-4620-bd8d-f229f246113a')

");
        }
        
        public override void Down()
        {
        }
    }
}
