using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassLibrary
{
    public class PlayerRecord
    {
		public int Id { get; set; }

		public virtual List<Player> Player { get; set; }
		public int PlayerId { get; set; }

		public int JournalRecordId { get; set; }
		public virtual List<JournalRecord> JournalRecord { get; set; }
	}
}
