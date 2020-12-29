namespace MikołajRarokZad4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(nullable: false, maxLength: 50),
                        RoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.GuestAccesses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GymAccess = c.Boolean(nullable: false),
                        SpaAccess = c.Boolean(nullable: false),
                        PoolAccess = c.Boolean(nullable: false),
                        GuestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Guests", t => t.GuestId, cascadeDelete: true)
                .Index(t => t.GuestId);
            
            CreateTable(
                "dbo.GuestBookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookedIn = c.DateTime(nullable: false),
                        BookedOut = c.DateTime(nullable: false),
                        GuestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Guests", t => t.GuestId, cascadeDelete: true)
                .Index(t => t.GuestId);
            
            CreateTable(
                "dbo.GuestCaterings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Breakfast = c.Boolean(nullable: false),
                        Lunch = c.Boolean(nullable: false),
                        Dinner = c.Boolean(nullable: false),
                        GuestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Guests", t => t.GuestId, cascadeDelete: true)
                .Index(t => t.GuestId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        RoomCapacity = c.Int(nullable: false),
                        Floor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GuestBlacklists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        AccountId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WorkerLoginDatas", t => t.AccountId, cascadeDelete: true)
                .Index(t => t.AccountId);
            
            CreateTable(
                "dbo.WorkerLoginDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        WorkPosition = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Workers", "AccountId", "dbo.WorkerLoginDatas");
            DropForeignKey("dbo.Guests", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.GuestCaterings", "GuestId", "dbo.Guests");
            DropForeignKey("dbo.GuestBookings", "GuestId", "dbo.Guests");
            DropForeignKey("dbo.GuestAccesses", "GuestId", "dbo.Guests");
            DropIndex("dbo.Workers", new[] { "AccountId" });
            DropIndex("dbo.GuestCaterings", new[] { "GuestId" });
            DropIndex("dbo.GuestBookings", new[] { "GuestId" });
            DropIndex("dbo.GuestAccesses", new[] { "GuestId" });
            DropIndex("dbo.Guests", new[] { "RoomId" });
            DropTable("dbo.WorkerLoginDatas");
            DropTable("dbo.Workers");
            DropTable("dbo.GuestBlacklists");
            DropTable("dbo.Rooms");
            DropTable("dbo.GuestCaterings");
            DropTable("dbo.GuestBookings");
            DropTable("dbo.GuestAccesses");
            DropTable("dbo.Guests");
        }
    }
}
