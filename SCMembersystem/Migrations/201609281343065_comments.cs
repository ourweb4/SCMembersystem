namespace SCMembersystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class comments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        memberid = c.Int(nullable: false),
                        cdate = c.DateTime(nullable: false),
                        comment = c.String(maxLength: 255),
                        UpdatedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Members", "keycard", c => c.String());
            AddColumn("dbo.Members", "keymain", c => c.String());
            AddColumn("dbo.Members", "mainactive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Members", "keyrange", c => c.String());
            AddColumn("dbo.Members", "rangeactive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Members", "fob", c => c.String());
            AddColumn("dbo.Members", "fobmain", c => c.String());
            AddColumn("dbo.Members", "fobmainactive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Members", "fobrange", c => c.String());
            AddColumn("dbo.Members", "fobrangractive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "fobrangractive");
            DropColumn("dbo.Members", "fobrange");
            DropColumn("dbo.Members", "fobmainactive");
            DropColumn("dbo.Members", "fobmain");
            DropColumn("dbo.Members", "fob");
            DropColumn("dbo.Members", "rangeactive");
            DropColumn("dbo.Members", "keyrange");
            DropColumn("dbo.Members", "mainactive");
            DropColumn("dbo.Members", "keymain");
            DropColumn("dbo.Members", "keycard");
            DropTable("dbo.Comments");
        }
    }
}
