namespace SCMembersystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class members : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "cell", c => c.String(maxLength: 50));
            AlterColumn("dbo.Members", "email", c => c.String(maxLength: 50));
            AlterColumn("dbo.Members", "employedby", c => c.String(maxLength: 50));
            AlterColumn("dbo.Members", "occupation", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "occupation", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Members", "employedby", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Members", "email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Members", "cell", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
