namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class typedata_migration : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.TB_T_Organization", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TB_T_Organization", "Name");
        }
    }
}
