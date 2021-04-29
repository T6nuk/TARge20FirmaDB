namespace ViimaneKord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lendings", "Companies_Id", c => c.Guid());
            CreateIndex("dbo.Lendings", "Companies_Id");
            AddForeignKey("dbo.Lendings", "Companies_Id", "dbo.Companies", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lendings", "Companies_Id", "dbo.Companies");
            DropIndex("dbo.Lendings", new[] { "Companies_Id" });
            DropColumn("dbo.Lendings", "Companies_Id");
        }
    }
}
