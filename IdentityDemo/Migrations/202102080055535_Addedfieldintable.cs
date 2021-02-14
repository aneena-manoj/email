namespace IdentityDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedfieldintable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Fathername", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Address");
            DropColumn("dbo.AspNetUsers", "Fathername");
        }
    }
}
