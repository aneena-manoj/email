namespace IdentityDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablename1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Account", name: "AcoountId", newName: "Id");
            RenameColumn(table: "dbo.Account", name: "PhoneNumber", newName: "PhoneNo");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Account", name: "PhoneNo", newName: "PhoneNumber");
            RenameColumn(table: "dbo.Account", name: "Id", newName: "AcoountId");
        }
    }
}
