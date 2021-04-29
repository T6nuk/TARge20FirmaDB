namespace ViimaneKord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Lending : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lendings",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        LendingStart = c.DateTime(nullable: false),
                        LendingEnd = c.DateTime(nullable: false),
                        Employee_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.Lending_Items",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        amount = c.Int(nullable: false),
                        Lending_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lendings", t => t.Lending_Id)
                .Index(t => t.Lending_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lending_Items", "Lending_Id", "dbo.Lendings");
            DropForeignKey("dbo.Lendings", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.Lending_Items", new[] { "Lending_Id" });
            DropIndex("dbo.Lendings", new[] { "Employee_Id" });
            DropTable("dbo.Lending_Items");
            DropTable("dbo.Lendings");
        }
    }
}
