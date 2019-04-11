namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetypedata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_M_User", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TB_M_User", "Gender");
        }
    }
}
