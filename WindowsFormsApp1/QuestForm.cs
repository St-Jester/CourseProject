using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGClassLibrary;

namespace WindowsFormsApp1
{
	public partial class QuestForm : Form
	{
		public PlayerQuest currentQuest;
		public string QuestNameProp { get; set; }
		public string QuestDescriptionProp { get; set; }
		public int QuestIDD { get; set; }
		public QuestForm()
		{
			InitializeComponent();
			currentQuest = new PlayerQuest();
		}

		public QuestForm(Quest _currentQuest)
		{
			InitializeComponent();
		}

		private void DeclineQButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.No;
			this.Close();
		}

		private void AcceptQButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			using (var db = new RpgGameContext())
			{
				var cq = db.PlayerQuests.Where(q => q.Id == currentQuest.Id).FirstOrDefault();
				cq.QuestState = QuestState.InProgress;
			}
			this.Close();
		}

		private void QuestForm_Load(object sender, EventArgs e)
		{
			if (PlayerManager.instance.playerQuesting == QuestState.NotTaken)
			{
				using (var db = new RpgGameContext())
				{
					var qs = db.PlayerQuests.Where(q => q.QuestState == QuestState.NotTaken).ToList();

					Random r = new Random();
					if (qs.Count > 1)
					{ currentQuest = qs.ElementAt(r.Next(qs.Count - 1)); }
					else
					{ currentQuest = qs.ElementAt(0); }

					QuestIDD = currentQuest.QuestId;
					var currQuestInfo = db.Quests.Where(q => q.Id == currentQuest.QuestId).FirstOrDefault();

					QuestName.Text = currQuestInfo.QuestName;
					QuestNameProp = QuestName.Text;

					QuestDescrioptionlabel.Text = currQuestInfo.QuestDescription;
					QuestDescriptionProp = QuestDescrioptionlabel.Text;

					Stamina.Text = currQuestInfo.StaminaRequirement.ToString();
					RewardLabel.Text = currQuestInfo.QuestReward.ToString();
				}
			}
			else
			{
				AcceptQButton.Enabled = false;
				MessageBox.Show("Already has a quest!");
			}
			
		}
	}
}
