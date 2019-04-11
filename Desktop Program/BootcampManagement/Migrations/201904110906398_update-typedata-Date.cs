namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetypedataDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TB_M_User", "Date_of_birth", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TB_M_User", "Date_of_birth", c => c.DateTime(nullable: false));
        }
    }
}
