namespace IdentityDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablename : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AspNetUsers", newName: "Account");
            RenameTable(name: "dbo.AspNetUserClaims", newName: "userClaim");
            RenameColumn(table: "dbo.Account", name: "Id", newName: "AcoountId");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Account", name: "AcoountId", newName: "Id");
            RenameTable(name: "dbo.userClaim", newName: "AspNetUserClaims");
            RenameTable(name: "dbo.Account", newName: "AspNetUsers");
        }
    }
}
