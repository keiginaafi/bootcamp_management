namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class almost_all_migration_and_fixed_region_districtv2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TB_M_District", newName: "TB_M_Sub_District");
            DropForeignKey("dbo.TB_M_Region", "TB_M_Provinces_id", "dbo.TB_M_Province");
            DropIndex("dbo.TB_M_Region", new[] { "TB_M_Provinces_id" });
            DropColumn("dbo.TB_M_Region", "Name");
            DropColumn("dbo.TB_M_Region", "TB_M_Provinces_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TB_M_Region", "TB_M_Provinces_id", c => c.Int());
            AddColumn("dbo.TB_M_Region", "Name", c => c.String());
            CreateIndex("dbo.TB_M_Region", "TB_M_Provinces_id");
            AddForeignKey("dbo.TB_M_Region", "TB_M_Provinces_id", "dbo.TB_M_Province", "id");
            RenameTable(name: "dbo.TB_M_Sub_District", newName: "TB_M_District");
        }
    }
}
