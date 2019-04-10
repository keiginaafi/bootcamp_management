namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_new_model_role : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Role",
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TB_M_Role");
        }
    }
}
