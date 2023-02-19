namespace ArtRepositorySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Analytics",
                c => new
                    {
                        AnalyticId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Visibility = c.Boolean(nullable: false),
                        Art_ArtId = c.Int(),
                    })
                .PrimaryKey(t => t.AnalyticId)
                .ForeignKey("dbo.Arts", t => t.Art_ArtId)
                .Index(t => t.Art_ArtId);
            
            CreateTable(
                "dbo.FeedbackForms",
                c => new
                    {
                        FeedbackFromId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.FeedbackFromId);
            
            CreateTable(
                "dbo.QnAs",
                c => new
                    {
                        QnAId = c.Int(nullable: false, identity: true),
                        FeedbackForm_FeedbackFromId = c.Int(),
                    })
                .PrimaryKey(t => t.QnAId)
                .ForeignKey("dbo.FeedbackForms", t => t.FeedbackForm_FeedbackFromId)
                .Index(t => t.FeedbackForm_FeedbackFromId);
            
            CreateTable(
                "dbo.Options",
                c => new
                    {
                        OptionId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.OptionId);
            
            CreateTable(
                "dbo.Reactions",
                c => new
                    {
                        ReactionId = c.Int(nullable: false, identity: true),
                        Response = c.String(),
                        Artwork_ArtId = c.Int(),
                        Consumer_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.ReactionId)
                .ForeignKey("dbo.Arts", t => t.Artwork_ArtId)
                .ForeignKey("dbo.Users", t => t.Consumer_UserId)
                .Index(t => t.Artwork_ArtId)
                .Index(t => t.Consumer_UserId);
            
            CreateTable(
                "dbo.Arts",
                c => new
                    {
                        ArtId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        PostedOn = c.DateTime(nullable: false),
                        Type = c.Int(nullable: false),
                        LiteraryArtId = c.Int(),
                        PerformedArtId = c.Int(),
                        Image = c.Binary(),
                        VisualArtShape = c.Int(),
                        VisualArtType = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        FeedbackForm_FeedbackFromId = c.Int(),
                    })
                .PrimaryKey(t => t.ArtId)
                .ForeignKey("dbo.FeedbackForms", t => t.FeedbackForm_FeedbackFromId)
                .Index(t => t.FeedbackForm_FeedbackFromId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        userMode = c.Int(nullable: false),
                        ProfilePic = c.Binary(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Bio = c.String(),
                        User_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Users", t => t.User_UserId)
                .Index(t => t.User_UserId);
            
            CreateTable(
                "dbo.UserArts",
                c => new
                    {
                        User_UserId = c.Int(nullable: false),
                        Art_ArtId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_UserId, t.Art_ArtId })
                .ForeignKey("dbo.Users", t => t.User_UserId, cascadeDelete: true)
                .ForeignKey("dbo.Arts", t => t.Art_ArtId, cascadeDelete: true)
                .Index(t => t.User_UserId)
                .Index(t => t.Art_ArtId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reactions", "Consumer_UserId", "dbo.Users");
            DropForeignKey("dbo.Reactions", "Artwork_ArtId", "dbo.Arts");
            DropForeignKey("dbo.Arts", "FeedbackForm_FeedbackFromId", "dbo.FeedbackForms");
            DropForeignKey("dbo.UserArts", "Art_ArtId", "dbo.Arts");
            DropForeignKey("dbo.UserArts", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "User_UserId", "dbo.Users");
            DropForeignKey("dbo.Analytics", "Art_ArtId", "dbo.Arts");
            DropForeignKey("dbo.QnAs", "FeedbackForm_FeedbackFromId", "dbo.FeedbackForms");
            DropIndex("dbo.UserArts", new[] { "Art_ArtId" });
            DropIndex("dbo.UserArts", new[] { "User_UserId" });
            DropIndex("dbo.Users", new[] { "User_UserId" });
            DropIndex("dbo.Arts", new[] { "FeedbackForm_FeedbackFromId" });
            DropIndex("dbo.Reactions", new[] { "Consumer_UserId" });
            DropIndex("dbo.Reactions", new[] { "Artwork_ArtId" });
            DropIndex("dbo.QnAs", new[] { "FeedbackForm_FeedbackFromId" });
            DropIndex("dbo.Analytics", new[] { "Art_ArtId" });
            DropTable("dbo.UserArts");
            DropTable("dbo.Users");
            DropTable("dbo.Arts");
            DropTable("dbo.Reactions");
            DropTable("dbo.Options");
            DropTable("dbo.QnAs");
            DropTable("dbo.FeedbackForms");
            DropTable("dbo.Analytics");
        }
    }
}
