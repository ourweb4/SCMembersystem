namespace SCMembersystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Committes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        memberId = c.Int(nullable: false),
                        invdate = c.DateTime(nullable: false),
                        amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        paidamount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        description = c.String(maxLength: 100),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.memberId, cascadeDelete: true)
                .Index(t => t.memberId);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        mtype = c.Int(nullable: false),
                        firstname = c.String(nullable: false, maxLength: 50),
                        lastname = c.String(nullable: false, maxLength: 50),
                        address = c.String(nullable: false, maxLength: 50),
                        city = c.String(nullable: false, maxLength: 50),
                        state = c.String(nullable: false, maxLength: 50),
                        zip = c.String(nullable: false, maxLength: 50),
                        phone = c.String(nullable: false, maxLength: 50),
                        cell = c.String(nullable: false, maxLength: 50),
                        email = c.String(nullable: false, maxLength: 50),
                        employedby = c.String(nullable: false, maxLength: 50),
                        occupation = c.String(nullable: false, maxLength: 50),
                        dob = c.DateTime(nullable: false),
                        join = c.DateTime(nullable: false),
                        fid = c.Boolean(nullable: false),
                        ltc = c.Boolean(nullable: false),
                        fishing = c.Boolean(nullable: false),
                        hunting = c.Boolean(nullable: false),
                        goal = c.Boolean(nullable: false),
                        nra = c.Boolean(nullable: false),
                        committees = c.String(),
                        hours = c.Int(nullable: false),
                        amtdue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        nextbill = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        mtypeh_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Mtypes", t => t.mtypeh_Id)
                .Index(t => t.mtypeh_Id);
            
            CreateTable(
                "dbo.Mtypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 25),
                        cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        hours = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoices", "memberId", "dbo.Members");
            DropForeignKey("dbo.Members", "mtypeh_Id", "dbo.Mtypes");
            DropIndex("dbo.Members", new[] { "mtypeh_Id" });
            DropIndex("dbo.Invoices", new[] { "memberId" });
            DropTable("dbo.Mtypes");
            DropTable("dbo.Members");
            DropTable("dbo.Invoices");
            DropTable("dbo.Committes");
        }
    }
}
