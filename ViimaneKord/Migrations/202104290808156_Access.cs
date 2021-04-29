namespace ViimaneKord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Access : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accesses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Employee_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.AccessNames",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstAccess = c.String(),
                        SecondAccess = c.String(),
                        ThirdAccess = c.String(),
                        Access_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accesses", t => t.Access_Id)
                .Index(t => t.Access_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accesses", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.AccessNames", "Access_Id", "dbo.Accesses");
            DropIndex("dbo.AccessNames", new[] { "Access_Id" });
            DropIndex("dbo.Accesses", new[] { "Employee_Id" });
            DropTable("dbo.AccessNames");
            DropTable("dbo.Accesses");
        }
    }
}
