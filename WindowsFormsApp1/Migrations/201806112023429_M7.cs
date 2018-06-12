namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JournalRecords", "QuestName", c => c.String());
            AddColumn("dbo.JournalRecords", "QuestDescription", c => c.String());
            DropColumn("dbo.PlayerRecords", "QuestName");
            DropColumn("dbo.PlayerRecords", "QuestDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PlayerRecords", "QuestDescription", c => c.String());
            AddColumn("dbo.PlayerRecords", "QuestName", c => c.String());
            DropColumn("dbo.JournalRecords", "QuestDescription");
            DropColumn("dbo.JournalRecords", "QuestName");
        }
    }
}
