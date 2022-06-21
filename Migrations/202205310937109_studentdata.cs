namespace Student_Regestration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentdata : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.students",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 40, unicode: false),
                        Dept = c.String(maxLength: 40, unicode: false),
                        city = c.String(maxLength: 40, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.students");
        }
    }
}
