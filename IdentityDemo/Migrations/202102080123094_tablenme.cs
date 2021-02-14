namespace IdentityDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablenme : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.userClaim", newName: "AspNetUserClaims");
            RenameColumn(table: "dbo.Account", name: "PhoneNo", newName: "PhoneNumber");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Account", name: "PhoneNumber", newName: "PhoneNo");
            RenameTable(name: "dbo.AspNetUserClaims", newName: "userClaim");
        }
    }
}
