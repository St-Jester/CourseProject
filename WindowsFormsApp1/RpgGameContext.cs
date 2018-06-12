using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RPGClassLibrary;
namespace WindowsFormsApp1
{
	public class RpgGameContext:DbContext
	{
		public virtual DbSet<Item> Items { get; set; }
		public virtual DbSet<JournalRecord> JournalRecords { get; set; }
		public virtual DbSet<Player> Players { get; set; }
		public virtual DbSet<PlayerQuest> PlayerQuests { get; set; }
		public virtual DbSet<Quest> Quests { get; set; }
		public virtual DbSet<PlayerRecord> PlayerRecords { get; set; }

		public RpgGameContext()
			: base("RpgDatabase")
		{
		}

		//protected override void OnModelCreating(DbModelBuilder modelBuilder)
		//{
		//	modelBuilder.Entity<Quest>()
		//		.HasMany(e => e.JournalRecords)
		//		.WithRequired(e => e.PlayerQuests)
		//		.WillCascadeOnDelete(false);
		//}
	}
}
