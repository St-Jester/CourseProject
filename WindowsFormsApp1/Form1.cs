using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGClassLibrary;
namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		private int questtimerduration = 3;
		
		private int playerId = 0;
		//private Thread UIupdater;

		public Player currentPlayer;
		public PlayerManager PM;
		public Quest currentQuestInfo;
		
		public Form1(int _playerId)
		{
			InitializeComponent();
			playerId = _playerId;
			JournalHandler.instance = new JournalHandler();

			using (var xdb = new RpgGameContext())
			{
				var c_player = xdb.Players.Where(p => p.Id == playerId).FirstOrDefault();
				
				currentPlayer = new Player()
				{
					Id = c_player.Id,
					PlayerName = c_player.PlayerName,
					SavesPath = c_player.SavesPath

				};
				PM = new PlayerManager(currentPlayer.PlayerName, new Stat(100), new Stat(100), 1, 0, 0);

				
			}

			
		}

		

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Owner.Enabled = false;
			UpdateUI();
		}

		private void RecoverButton_Click(object sender, EventArgs e)
		{
			if (TavernTimer.Enabled == true)
			{
				TavernTimer.Stop();
			}
			else
			{
				TavernTimer.Start();
			}
		}

		private void GetQuestButon_Click(object sender, EventArgs e)
		{
			DisplayDialog();
		}

		private void LeaveTavernButton_Click(object sender, EventArgs e)
		{
			TavernTimer.Stop();
			tabControl1.SelectedTab = tabPage1;
		}
		private void DisplayDialog()
		{

			if (PM.playerQuesting == QuestState.NotTaken)
			{
				QuestForm dlg = new QuestForm();

				// Show the dialog and determine the state of the 
				// DialogResult property for the form.
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					
					MessageBox.Show("Accepted");
					PM.playerQuesting = QuestState.InProgress;
					using (var xdb = new RpgGameContext())
					{
						
						var currQuest = xdb.PlayerQuests.Where(p => p.QuestId == dlg.QuestIDD).FirstOrDefault();
						currQuest.QuestState = QuestState.InProgress;
						xdb.SaveChanges();


						currentQuestInfo = xdb.Quests.Where(p => p.Id == currQuest.QuestId).FirstOrDefault();
					}
					//if quest is finished - add in JR
					string qname = dlg.QuestNameProp;
					string qdesc = dlg.QuestDescriptionProp;
					
					//Add in journalrecords
					using (var xdb = new RpgGameContext())
					{

						JournalRecord jr = new JournalRecord()
						{
							QuestDescription = qdesc,
							QuestName = qname
						};

						xdb.JournalRecords.Add(jr);
						xdb.SaveChanges();

						var i = xdb.PlayerRecords.Add(new PlayerRecord()
						{
							PlayerId = currentPlayer.Id,
							JournalRecordId = jr.Id
						});
						
						xdb.SaveChanges();
						xdb.JournalRecords.Where(x => x.Id == jr.Id).FirstOrDefault().PlayerRecordId = i.Id;

						xdb.SaveChanges();

						var currntplayerjournal = xdb.PlayerRecords.Where(p => p.PlayerId == playerId).ToList();

						foreach (var item in currntplayerjournal)
						{
							JournalHandler.instance.AddRecord(
								xdb.JournalRecords.Where(c => c.PlayerRecordId == item.Id).FirstOrDefault().QuestName,
								xdb.JournalRecords.Where(c => c.PlayerRecordId == item.Id).FirstOrDefault().QuestDescription
								);
						}
						
					}

					//handle journal records
					QuestName.Text = qname;
					QuestDescrioptionlabel.Text = qdesc;

					foreach (var i in JournalHandler.instance.JournalRecords)
					{
						var si = listView1.Items.Add(i.Key);
						si.SubItems.Add(i.Value);
					}

					StrtQuest.Enabled = true;
				}
				else
				{
					//return to tavern continue drinking
					MessageBox.Show("Declined");
				}
			}
			else
			{
				MessageBox.Show("Already has a quest!");
			}

		}

		private void TavernTimer_Tick(object sender, EventArgs e)
		{
		
			if (PM.HP.CurrentValue >= PM.HP.BaseValue && PM.Stamina.CurrentValue < PM.Stamina.BaseValue)
			{
				PM.Stamina.CurrentValue = PM.Stamina.CurrentValue + 1.0;
			}
			if (PM.HP.CurrentValue < PM.HP.BaseValue && PM.Stamina.CurrentValue >= PM.Stamina.BaseValue)
			{
				PM.HP.CurrentValue = PM.HP.CurrentValue + 1.0;
			}
			if (PM.HP.CurrentValue < PM.HP.BaseValue && PM.Stamina.CurrentValue < PM.Stamina.BaseValue)
			{
				PM.HP.CurrentValue = PM.HP.CurrentValue + 1.0;
				PM.Stamina.CurrentValue = PM.Stamina.CurrentValue + 1.0;
			}
			if (PM.HP.CurrentValue >= PM.HP.BaseValue && PM.Stamina.CurrentValue >= PM.Stamina.BaseValue)
			{
				TavernTimer.Stop();

			}
			UpdateUI();
		}

		private void UpdateUI()
		{
			
			StaminatextBox.Text = PM.Stamina.CurrentValue.ToString();
			HPtextBox.Text = PM.HP.CurrentValue.ToString();
			GoldtextBox.Text = PM.Money.ToString();
			
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			//save data to saves
			
			//stopthread
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Owner.Enabled = true;
			m_StopThread = true;
		}

		public void SaveProgress()
		{
			//find path
			//openfile
			//rewrite it
			//savechanges
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void TavernButton_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabPage2;
		}

		private void JornalButton_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabPage3;

		}

		private void StrtQuest_Click(object sender, EventArgs e)
		{
			TavernTimer.Stop();
			//start quest timer
			QuesTimer.Start();
			PM.Stamina.CurrentValue -= currentQuestInfo.StaminaRequirement;
			UpdateUI();
			
				this.Enabled = true;

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void QuesTimer_Tick(object sender, EventArgs e)
		{
			//countdown
			questtimerduration -= 1;

			if (questtimerduration <= 0)
			{
				QuesTimer.Stop();
				//enable form
				this.Enabled = true;
				if (questtimerduration <= 0)
				{
					//disable button & reset timer time
					StrtQuest.Enabled = false;
					questtimerduration = 3;

					PM.Money += currentQuestInfo.QuestReward;
					PM.AddXp(currentQuestInfo.QuestXp);
					Random randomDamage = new Random();
					//give random damage
					int calculatedrandomdamage = randomDamage.Next(0, 30);
					PM.SubtractHP(calculatedrandomdamage);
					PM.playerQuesting = QuestState.NotTaken;

					MessageBox.Show($"You finished quest {currentQuestInfo.QuestName}," +
						$" you got {calculatedrandomdamage} damage, " +
						$"you earned {currentQuestInfo.QuestReward} gold and {currentQuestInfo.QuestXp} XP",
						$"{currentQuestInfo.QuestName} completed");
					UpdateUI();

				}
			}
		}
	}
}
