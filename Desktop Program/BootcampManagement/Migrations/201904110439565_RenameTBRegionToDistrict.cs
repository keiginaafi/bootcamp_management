namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTBRegionToDistrict : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TB_M_Region", newName: "TB_M_District");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TB_M_District", newName: "TB_M_Region");
        }
    }
}
