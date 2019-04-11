namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameAndFKTBRegion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_M_Region", "Name", c => c.String());
            AddColumn("dbo.TB_M_Region", "TB_M_Provinces_id", c => c.Int());
            CreateIndex("dbo.TB_M_Region", "TB_M_Provinces_id");
            AddForeignKey("dbo.TB_M_Region", "TB_M_Provinces_id", "dbo.TB_M_Province", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_M_Region", "TB_M_Provinces_id", "dbo.TB_M_Province");
            DropIndex("dbo.TB_M_Region", new[] { "TB_M_Provinces_id" });
            DropColumn("dbo.TB_M_Region", "TB_M_Provinces_id");
            DropColumn("dbo.TB_M_Region", "Name");
        }
    }
}
