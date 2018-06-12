using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RPGClassLibrary
{
	public enum QuestState
	{
		Finished,
		InProgress,
		NotTaken
	}

	public class PlayerQuest
    {
		public int Id { get; set; }

		public virtual List<Player> Player { get; set; }
		public int PlayerId { get; set; }

		public int QuestId { get; set; }
		public virtual List<Quest> Quest { get; set; }



		public QuestState QuestState { get; set; }
	}
}
