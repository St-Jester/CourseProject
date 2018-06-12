namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.JournalRecords", "QuestId", "dbo.Quests");
            AddForeignKey("dbo.JournalRecords", "QuestId", "dbo.Quests", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JournalRecords", "QuestId", "dbo.Quests");
            AddForeignKey("dbo.JournalRecords", "QuestId", "dbo.Quests", "Id");
        }
    }
}
