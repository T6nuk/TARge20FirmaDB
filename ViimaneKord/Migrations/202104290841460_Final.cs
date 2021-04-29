namespace ViimaneKord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Final : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sick_leave",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        LeaveStart = c.DateTime(nullable: false),
                        LeaveEnd = c.DateTime(nullable: false),
                        Employee_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.Vacation_leave",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        VacationStart = c.DateTime(nullable: false),
                        VacationEnd = c.DateTime(nullable: false),
                        Employee_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Employee_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vacation_leave", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Sick_leave", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.Vacation_leave", new[] { "Employee_Id" });
            DropIndex("dbo.Sick_leave", new[] { "Employee_Id" });
            DropTable("dbo.Vacation_leave");
            DropTable("dbo.Sick_leave");
        }
    }
}
