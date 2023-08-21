namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init_DoctorToken : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DoctorTokens",
                c => new
                    {
                        DoctorTokenId = c.Int(nullable: false, identity: true),
                        DoctorId = c.Int(nullable: false),
                        TokenKey = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        ExpiredAt = c.DateTime(),
                        LastUsedAt = c.DateTime(),
                        IpAddress = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Purpose = c.String(),
                    })
                .PrimaryKey(t => t.DoctorTokenId)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .Index(t => t.DoctorId);
            
            AddColumn("dbo.Doctors", "FailedLoginAttempts", c => c.Int());
            AddColumn("dbo.Doctors", "LockoutEnd", c => c.DateTime());
            AlterColumn("dbo.Doctors", "DateOfBirth", c => c.DateTime());
            AlterColumn("dbo.Doctors", "Sex", c => c.Int());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DoctorTokens", "DoctorId", "dbo.Doctors");
            DropIndex("dbo.DoctorTokens", new[] { "DoctorId" });
            AlterColumn("dbo.Doctors", "Sex", c => c.Int(nullable: false));
            AlterColumn("dbo.Doctors", "DateOfBirth", c => c.DateTime(nullable: false));
            DropColumn("dbo.Doctors", "LockoutEnd");
            DropColumn("dbo.Doctors", "FailedLoginAttempts");
            DropTable("dbo.DoctorTokens");
        }
    }
}
