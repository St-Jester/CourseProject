using System;
using System.Collections.Generic;
using System.Text;



namespace RPGClassLibrary
{
    public class Quest
    {
        public int Id { get; set; }
		
		public string QuestDescription { get; set; }             //description of quest that goes into journal  
        public string QuestName { get; set; }               //Name of the quest - to journal
        public double QuestXp { get; set; }                 //base Xp reward for completing
        public double QuestReward { get; set; }        //base money reward for completing
        public double StaminaRequirement { get; set; }      //calculate stamina required


		public virtual PlayerQuest PlayerQuest { get; set; }
		public int? PlayerQuestId { get; set; }


		//[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		//public virtual ICollection<JournalRecord> JournalRecords { get; set; }
		
	}
}
