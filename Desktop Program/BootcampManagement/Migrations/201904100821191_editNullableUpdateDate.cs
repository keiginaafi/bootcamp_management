namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editNullableUpdateDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TB_M_District", "EditDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_Region", "EditDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_Province", "EditDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_Religion", "EditDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_User", "EditDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_Village", "EditDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TB_M_Village", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_User", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Religion", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Province", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Region", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_District", "EditDate", c => c.DateTime(nullable: false));
        }
    }
}
