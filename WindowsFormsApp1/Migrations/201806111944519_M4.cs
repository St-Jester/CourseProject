namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M4 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.JournalRecords");
            AddColumn("dbo.PlayerQuests", "JournalRecordId", c => c.Int(nullable: false));
            AlterColumn("dbo.JournalRecords", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.JournalRecords", "Id");
            CreateIndex("dbo.JournalRecords", "Id");
            AddForeignKey("dbo.JournalRecords", "Id", "dbo.PlayerQuests", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JournalRecords", "Id", "dbo.PlayerQuests");
            DropIndex("dbo.JournalRecords", new[] { "Id" });
            DropPrimaryKey("dbo.JournalRecords");
            AlterColumn("dbo.JournalRecords", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.PlayerQuests", "JournalRecordId");
            AddPrimaryKey("dbo.JournalRecords", "Id");
        }
    }
}
