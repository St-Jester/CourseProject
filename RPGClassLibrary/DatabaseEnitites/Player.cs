using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassLibrary
{
    public class Player
    {
		public int Id { get; set; }
		public string PlayerName { get; set; }
		public string SavesPath { get; set; }

		public virtual PlayerQuest PlayerQuest { get; set; }
		public int? PlayerQuestId { get; set; }

		public virtual PlayerRecord JournalRecord { get; set; }
		public int? PlayerRecordId { get; set; }
	}
}
