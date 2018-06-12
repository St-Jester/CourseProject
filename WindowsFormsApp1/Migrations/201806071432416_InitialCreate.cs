namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        ItemType = c.Int(nullable: false),
                        ItemBonus = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JournalRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Quests", t => t.QuestId)
                .Index(t => t.QuestId);
            
            CreateTable(
                "dbo.Quests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestDescription = c.String(),
                        QuestName = c.String(),
                        QuestXp = c.Double(nullable: false),
                        QuestReward = c.Double(nullable: false),
                        StaminaRequirement = c.Double(nullable: false),
                        Completed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerName = c.String(),
                        SavesPath = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JournalRecords", "QuestId", "dbo.Quests");
            DropIndex("dbo.JournalRecords", new[] { "QuestId" });
            DropTable("dbo.Players");
            DropTable("dbo.Quests");
            DropTable("dbo.JournalRecords");
            DropTable("dbo.Items");
        }
    }
}
