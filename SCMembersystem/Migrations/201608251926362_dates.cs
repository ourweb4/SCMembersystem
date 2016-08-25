namespace SCMembersystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clubs", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.Committes", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.Invoices", "invdate", c => c.DateTime());
            AlterColumn("dbo.Invoices", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.Members", "UpdatedOn", c => c.DateTime());
            AlterColumn("dbo.Mtypes", "UpdatedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mtypes", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Members", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Invoices", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Invoices", "invdate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Committes", "UpdatedOn", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Clubs", "UpdatedOn", c => c.DateTime(nullable: false));
        }
    }
}
