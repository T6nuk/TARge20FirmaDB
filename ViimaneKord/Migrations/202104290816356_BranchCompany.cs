namespace ViimaneKord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BranchCompany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        ContactPerson = c.String(),
                        Location = c.String(),
                        Companies_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Companies_Id)
                .Index(t => t.Companies_Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RegNum = c.Int(nullable: false),
                        Name = c.String(),
                        ContactPerson = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "Branch_Id", c => c.Guid());
            CreateIndex("dbo.Employees", "Branch_Id");
            AddForeignKey("dbo.Employees", "Branch_Id", "dbo.Branches", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Branch_Id", "dbo.Branches");
            DropForeignKey("dbo.Branches", "Companies_Id", "dbo.Companies");
            DropIndex("dbo.Branches", new[] { "Companies_Id" });
            DropIndex("dbo.Employees", new[] { "Branch_Id" });
            DropColumn("dbo.Employees", "Branch_Id");
            DropTable("dbo.Companies");
            DropTable("dbo.Branches");
        }
    }
}
