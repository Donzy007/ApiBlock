namespace ApiBlock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3844fbe7-7b7a-49ce-a263-aa12a0f19066', N'guest@apiblock.com', 0, N'AI7P00rRdpFCr2mp7J1QxNVDDt2QXg45dJce5iM5qOFjlZc81C48nUAljWpwO2r9Sg==', N'092598b7-4ad1-422e-a709-0007d1cbd7c6', NULL, 0, 0, NULL, 1, 0, N'guest@apiblock.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a98fd4a3-ed92-4fcd-a4d4-0c3932be9381', N'admin@apiblock.com', 0, N'AFgtCqbWOBzTHUtVYfg0EdLVNi+apASWOXR9XVKt11ewQyV2y7KrK/2kY12MBcwBfg==', N'368052dd-46d6-4261-ac03-0cd4f9401d5d', NULL, 0, 0, NULL, 1, 0, N'admin@apiblock.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'83b2a682-cf29-40dd-9ed9-598abfd16a1d', N'CanManagerMovies')
            
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a98fd4a3-ed92-4fcd-a4d4-0c3932be9381', N'83b2a682-cf29-40dd-9ed9-598abfd16a1d')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
