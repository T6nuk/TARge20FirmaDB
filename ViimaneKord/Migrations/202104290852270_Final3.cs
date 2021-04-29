namespace ViimaneKord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Final3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HealthCheckLists",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CheckDate = c.DateTime(nullable: false),
                        Employee_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PositionName = c.String(),
                        StartTime = c.DateTime(nullable: false),
                        Employee_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Employee_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Positions", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.HealthCheckLists", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.Positions", new[] { "Employee_Id" });
            DropIndex("dbo.HealthCheckLists", new[] { "Employee_Id" });
            DropTable("dbo.Positions");
            DropTable("dbo.HealthCheckLists");
        }
    }
}
