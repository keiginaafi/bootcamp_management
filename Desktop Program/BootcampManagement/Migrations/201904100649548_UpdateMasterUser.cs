namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMasterUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_District",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Regions_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Region", t => t.TB_M_Regions_id)
                .Index(t => t.TB_M_Regions_id);
            
            CreateTable(
                "dbo.TB_M_Region",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Provinces_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Province", t => t.TB_M_Provinces_id)
                .Index(t => t.TB_M_Provinces_id);
            
            CreateTable(
                "dbo.TB_M_Province",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TB_M_Religion",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TB_M_User",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        First_name = c.String(),
                        Last_name = c.String(),
                        Date_of_birth = c.DateTime(nullable: false),
                        IsMarried = c.Boolean(nullable: false),
                        Email = c.String(),
                        Contact = c.String(),
                        Street_address = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Religions_id = c.Int(),
                        TB_M_Villages_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Religion", t => t.TB_M_Religions_id)
                .ForeignKey("dbo.TB_M_Village", t => t.TB_M_Villages_id)
                .Index(t => t.TB_M_Religions_id)
                .Index(t => t.TB_M_Villages_id);
            
            CreateTable(
                "dbo.TB_M_Village",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Districts_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_District", t => t.TB_M_Districts_id)
                .Index(t => t.TB_M_Districts_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_M_User", "TB_M_Villages_id", "dbo.TB_M_Village");
            DropForeignKey("dbo.TB_M_Village", "TB_M_Districts_id", "dbo.TB_M_District");
            DropForeignKey("dbo.TB_M_User", "TB_M_Religions_id", "dbo.TB_M_Religion");
            DropForeignKey("dbo.TB_M_District", "TB_M_Regions_id", "dbo.TB_M_Region");
            DropForeignKey("dbo.TB_M_Region", "TB_M_Provinces_id", "dbo.TB_M_Province");
            DropIndex("dbo.TB_M_Village", new[] { "TB_M_Districts_id" });
            DropIndex("dbo.TB_M_User", new[] { "TB_M_Villages_id" });
            DropIndex("dbo.TB_M_User", new[] { "TB_M_Religions_id" });
            DropIndex("dbo.TB_M_Region", new[] { "TB_M_Provinces_id" });
            DropIndex("dbo.TB_M_District", new[] { "TB_M_Regions_id" });
            DropTable("dbo.TB_M_Village");
            DropTable("dbo.TB_M_User");
            DropTable("dbo.TB_M_Religion");
            DropTable("dbo.TB_M_Province");
            DropTable("dbo.TB_M_Region");
            DropTable("dbo.TB_M_District");
        }
    }
}
