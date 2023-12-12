namespace NotesManagementApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notess",
                c => new
                    {
                        NotesId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.NotesId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Notess");
        }
    }
}
