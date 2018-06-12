namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.JournalRecords", "Id", "dbo.PlayerQuests");
            DropIndex("dbo.JournalRecords", new[] { "Id" });
            DropPrimaryKey("dbo.JournalRecords");
            CreateTable(
                "dbo.PlayerRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerId = c.Int(nullable: false),
                        JournalRecordId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.JournalRecords", "PlayerRecordId", c => c.Int());
            AddColumn("dbo.Players", "PlayerRecordId", c => c.Int());
            AlterColumn("dbo.JournalRecords", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.JournalRecords", "Id");
            CreateIndex("dbo.JournalRecords", "PlayerRecordId");
            CreateIndex("dbo.Players", "PlayerRecordId");
            AddForeignKey("dbo.JournalRecords", "PlayerRecordId", "dbo.PlayerRecords", "Id");
            AddForeignKey("dbo.Players", "PlayerRecordId", "dbo.PlayerRecords", "Id");
            DropColumn("dbo.PlayerQuests", "JournalRecordId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PlayerQuests", "JournalRecordId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Players", "PlayerRecordId", "dbo.PlayerRecords");
            DropForeignKey("dbo.JournalRecords", "PlayerRecordId", "dbo.PlayerRecords");
            DropIndex("dbo.Players", new[] { "PlayerRecordId" });
            DropIndex("dbo.JournalRecords", new[] { "PlayerRecordId" });
            DropPrimaryKey("dbo.JournalRecords");
            AlterColumn("dbo.JournalRecords", "Id", c => c.Int(nullable: false));
            DropColumn("dbo.Players", "PlayerRecordId");
            DropColumn("dbo.JournalRecords", "PlayerRecordId");
            DropTable("dbo.PlayerRecords");
            AddPrimaryKey("dbo.JournalRecords", "Id");
            CreateIndex("dbo.JournalRecords", "Id");
            AddForeignKey("dbo.JournalRecords", "Id", "dbo.PlayerQuests", "Id");
        }
    }
}
