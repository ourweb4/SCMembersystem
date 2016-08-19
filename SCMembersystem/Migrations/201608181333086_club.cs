namespace SCMembersystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class club : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clubs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        clubname = c.String(nullable: false, maxLength: 50),
                        address = c.String(nullable: false, maxLength: 50),
                        city = c.String(nullable: false, maxLength: 50),
                        state = c.String(nullable: false, maxLength: 50),
                        zip = c.String(nullable: false, maxLength: 50),
                        phone = c.String(nullable: false, maxLength: 50),
                        website = c.String(maxLength: 50),
                        email = c.String(maxLength: 50),
                        trackhours = c.Boolean(nullable: false),
                        hours_percent = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Invoices", "hours", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Invoices", "hours");
            DropTable("dbo.Clubs");
        }
    }
}
