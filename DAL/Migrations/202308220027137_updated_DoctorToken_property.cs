namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updated_DoctorToken_property : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DoctorTokens", "RetrievalCount", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DoctorTokens", "RetrievalCount");
        }
    }
}
