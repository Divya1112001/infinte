namespace Project3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        Mgrid = c.Int(nullable: false, identity: true),
                        Mgrname = c.String(nullable: false),
                        Mgremail = c.String(nullable: false),
                        Phno = c.Int(nullable: false),
                        Gender = c.String(),
                    })
                .PrimaryKey(t => t.Mgrid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Managers");
        }
    }
}
