namespace UpnoidV4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd5fed9d8-e73a-49c4-a766-f04a749993c5', N'guest@upnoid.com', 0, N'AAM+IRNPN+dGsJhwuxEIeDwEcdbsWycU0e5newEYfPm11KpnppgsPOjuju49O0z27A==', N'02a6a9ec-296c-49da-bede-4b6e96e22e5e', NULL, 0, 0, NULL, 1, 0, N'guest@upnoid.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ee187d34-08c6-4fb6-bc1d-7be6f6a2b558', N'admin@upnoid.com', 0, N'AA30GuG1nJUJGutkJ/u7x4yT3+1OLEvV4jwKAc1rkUhz3fYT05iFcm34rE1C757K4g==', N'3056b6d7-5e54-4565-ad4c-775a76153f78', NULL, 0, 0, NULL, 1, 0, N'admin@upnoid.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e7106d7f-f51a-459f-975e-9f22ab3f8139', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ee187d34-08c6-4fb6-bc1d-7be6f6a2b558', N'e7106d7f-f51a-459f-975e-9f22ab3f8139')

");
        }
        
        public override void Down()
        {
        }
    }
}
