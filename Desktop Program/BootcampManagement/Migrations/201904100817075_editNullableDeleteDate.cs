namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editNullableDeleteDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TB_M_District", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_Region", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_Province", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_Religion", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_User", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_Village", "DeleteDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TB_M_Village", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_User", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Religion", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Province", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Region", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_District", "DeleteDate", c => c.DateTime(nullable: false));
        }
    }
}
