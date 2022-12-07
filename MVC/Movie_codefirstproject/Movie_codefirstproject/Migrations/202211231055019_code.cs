namespace Movie_codefirstproject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class code : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.displaymoviemodels",
                c => new
                    {
                        MovieName = c.String(nullable: false, maxLength: 128),
                        MovieYear = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MovieName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.displaymoviemodels");
        }
    }
}
