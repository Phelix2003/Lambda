namespace Lambda.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOtherDates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DateOfRegistration", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "DateOfLastConnect", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "IsDeleted", c => c.DateTime());
            DropColumn("dbo.AspNetUsers", "RegistrationDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "RegistrationDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.AspNetUsers", "IsDeleted");
            DropColumn("dbo.AspNetUsers", "DateOfLastConnect");
            DropColumn("dbo.AspNetUsers", "DateOfRegistration");
        }
    }
}
