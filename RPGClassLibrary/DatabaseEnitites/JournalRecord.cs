using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RPGClassLibrary
{
    public class JournalRecord
    {
		[Key]
		public int Id { get; set; }

		public virtual PlayerRecord PlayerRecord { get; set; }
		public int? PlayerRecordId { get; set; }


		public string QuestName { get; set; }
		public string QuestDescription { get; set; }

	}
}
