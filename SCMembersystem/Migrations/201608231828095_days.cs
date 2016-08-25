namespace SCMembersystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class days : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Mtypes", "days", c => c.Int(nullable: false));
            AddColumn("dbo.Mtypes", "once", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mtypes", "once");
            DropColumn("dbo.Mtypes", "days");
            DropColumn("dbo.Members", "active");
        }
    }
}
