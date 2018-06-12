namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlayerQuests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerId = c.Int(nullable: false),
                        QuestId = c.Int(nullable: false),
                        QuestState = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Quests", "PlayerQuestId", c => c.Int());
            AddColumn("dbo.Players", "PlayerQuestId", c => c.Int());
            CreateIndex("dbo.Quests", "PlayerQuestId");
            CreateIndex("dbo.Players", "PlayerQuestId");
            AddForeignKey("dbo.Players", "PlayerQuestId", "dbo.PlayerQuests", "Id");
            AddForeignKey("dbo.Quests", "PlayerQuestId", "dbo.PlayerQuests", "Id");
            DropColumn("dbo.Quests", "Completed");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Quests", "Completed", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Quests", "PlayerQuestId", "dbo.PlayerQuests");
            DropForeignKey("dbo.Players", "PlayerQuestId", "dbo.PlayerQuests");
            DropIndex("dbo.Players", new[] { "PlayerQuestId" });
            DropIndex("dbo.Quests", new[] { "PlayerQuestId" });
            DropColumn("dbo.Players", "PlayerQuestId");
            DropColumn("dbo.Quests", "PlayerQuestId");
            DropTable("dbo.PlayerQuests");
        }
    }
}
