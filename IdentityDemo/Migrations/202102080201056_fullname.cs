namespace IdentityDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fullname : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Account", newName: "AspNetUsers");
            DropColumn("dbo.AspNetUsers", "Fathername");
            DropColumn("dbo.AspNetUsers", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Address", c => c.String());
            AddColumn("dbo.AspNetUsers", "Fathername", c => c.String());
            RenameTable(name: "dbo.AspNetUsers", newName: "Account");
        }
    }
}
