namespace vtysOdev5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bolums",
                c => new
                    {
                        BolumID = c.Int(nullable: false, identity: true),
                        BolumAd = c.String(),
                        FakulteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BolumID)
                .ForeignKey("dbo.Fakultes", t => t.FakulteID, cascadeDelete: true)
                .Index(t => t.FakulteID);
            
            CreateTable(
                "dbo.Fakultes",
                c => new
                    {
                        FakulteID = c.Int(nullable: false, identity: true),
                        FakulteAd = c.String(),
                    })
                .PrimaryKey(t => t.FakulteID);
            
            CreateTable(
                "dbo.Ogrencis",
                c => new
                    {
                        OgrenciID = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        BolumID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OgrenciID)
                .ForeignKey("dbo.Bolums", t => t.BolumID, cascadeDelete: true)
                .Index(t => t.BolumID);
            
            CreateTable(
                "dbo.OgrenciDers",
                c => new
                    {
                        OgrenciDersID = c.Int(nullable: false, identity: true),
                        OgrenciID = c.Int(nullable: false),
                        DersID = c.Int(nullable: false),
                        Yil = c.String(),
                        Yariyil = c.String(),
                        Vize = c.Int(),
                        Final = c.Int(),
                    })
                .PrimaryKey(t => t.OgrenciDersID)
                .ForeignKey("dbo.Ders", t => t.DersID, cascadeDelete: true)
                .ForeignKey("dbo.Ogrencis", t => t.OgrenciID, cascadeDelete: true)
                .Index(t => t.OgrenciID)
                .Index(t => t.DersID);
            
            CreateTable(
                "dbo.Ders",
                c => new
                    {
                        DersID = c.Int(nullable: false, identity: true),
                        DersAd = c.String(),
                    })
                .PrimaryKey(t => t.DersID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OgrenciDers", "OgrenciID", "dbo.Ogrencis");
            DropForeignKey("dbo.OgrenciDers", "DersID", "dbo.Ders");
            DropForeignKey("dbo.Ogrencis", "BolumID", "dbo.Bolums");
            DropForeignKey("dbo.Bolums", "FakulteID", "dbo.Fakultes");
            DropIndex("dbo.OgrenciDers", new[] { "DersID" });
            DropIndex("dbo.OgrenciDers", new[] { "OgrenciID" });
            DropIndex("dbo.Ogrencis", new[] { "BolumID" });
            DropIndex("dbo.Bolums", new[] { "FakulteID" });
            DropTable("dbo.Ders");
            DropTable("dbo.OgrenciDers");
            DropTable("dbo.Ogrencis");
            DropTable("dbo.Fakultes");
            DropTable("dbo.Bolums");
        }
    }
}
