namespace MoviesWatched.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        YearReleased = c.Int(nullable: false),
                        Length = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserMovies",
                c => new
                    {
                        User_ID = c.Int(nullable: false),
                        Movie_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_ID, t.Movie_ID })
                .ForeignKey("dbo.Users", t => t.User_ID, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_ID, cascadeDelete: true)
                .Index(t => t.User_ID)
                .Index(t => t.Movie_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserMovies", "Movie_ID", "dbo.Movies");
            DropForeignKey("dbo.UserMovies", "User_ID", "dbo.Users");
            DropIndex("dbo.UserMovies", new[] { "Movie_ID" });
            DropIndex("dbo.UserMovies", new[] { "User_ID" });
            DropTable("dbo.UserMovies");
            DropTable("dbo.Users");
            DropTable("dbo.Movies");
        }
    }
}
