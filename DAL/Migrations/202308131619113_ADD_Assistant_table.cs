namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADD_Assistant_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assistants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Nid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Assistants");
        }
    }
}
