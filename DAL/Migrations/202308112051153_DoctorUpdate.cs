namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DoctorUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doctors", "Password");
        }
    }
}
