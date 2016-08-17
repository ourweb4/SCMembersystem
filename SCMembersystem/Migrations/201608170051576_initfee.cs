namespace SCMembersystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initfee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mtypes", "initfee", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mtypes", "initfee");
        }
    }
}
