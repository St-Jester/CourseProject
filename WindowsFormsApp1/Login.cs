using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGClassLibrary;
namespace WindowsFormsApp1
{
	public partial class Login : Form
	{
		bool isOld;
		RpgGameContext db;

		NameGenerator ng;
		public Login()
		{
			InitializeComponent();
			this.ActiveControl = textBox1;
			ng = new NameGenerator();
			//if db isnt empty give selection of all players avaliable
			db = new RpgGameContext();
			//TODO reset it if button pressed
			
		}

		private void PopulateCombobox()
		{
			var players = db.Players.ToList();

			foreach (var p in players)
			{
				NamecomboBox.Items.Add(p.PlayerName);
			}
		}

		private bool PlayersCheck()
		{
			return db.Players.Count() > 0;

		}



		private void button2_Click(object sender, EventArgs e)
		{
			string playername = "";
			if (!isOld)
			{
				playername = textBox1.Text;
				//TODO create a playerinstance in database
				//handle createdplayers
				string savespath = CreateSavesFolder(playername);
				Player player = new Player() { PlayerName = playername, SavesPath = savespath };
				db.Players.Add(player);
				db.SaveChanges();

				var allQuests = db.Quests.ToList();
				foreach (var q in allQuests)
				{

					db.PlayerQuests.Add(new PlayerQuest()
					{
						PlayerId = player.Id,
						QuestId = q.Id,
						QuestState = QuestState.NotTaken
					});
				}
				db.SaveChanges();
			}
			else
			{
				playername = (string)NamecomboBox.SelectedItem;
			}

			int PlayerId = db.Players.Where(p => p.PlayerName == playername).FirstOrDefault().Id;

			Form1 game = new Form1(PlayerId)
			{
				Owner = this
			};
			game.Show();
		}

		private void RandomizeButton_Click(object sender, EventArgs e)
		{
			string generatedname = ng.GenerateName();
			generatedname = generatedname.First().ToString().ToUpper() + generatedname.Substring(1);
			textBox1.Text = generatedname;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			EnterButton.Visible = true;
		}

		private void NamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			EnterButton.Visible = true;
		}

		private void NewNameButton_Click(object sender, EventArgs e)
		{
			isOld = false;
			ManageControlsGroupPresentation(true);
		}

		private void SavedNameButton_Click(object sender, EventArgs e)
		{
			ManageControlsGroupPresentation(false);
			isOld = true;
			if (isOld)
				PopulateCombobox();
		}

		private string CreateSavesFolder(string _playername)
		{
			byte[] codedinfo;
			string pathString = $@"..\..\Profiles\{_playername}\DataSaves";
			System.IO.Directory.CreateDirectory(pathString);
			string fileName = $"{DateTime.Now.ToShortDateString()}.dat";
			pathString = System.IO.Path.Combine(pathString, fileName);
			using (BinaryWriter writer = new BinaryWriter(File.Open(pathString, FileMode.Create)))
			{
				codedinfo = new byte[1024];
				codedinfo = Encoding.ASCII.GetBytes(_playername);

				writer.Write(codedinfo);
			}

			//if (File.Exists(pathString))
			//{
			//	string s;
			//	using (BinaryReader reader = new BinaryReader(File.Open(pathString, FileMode.Open)))
			//	{
			//		byte[] buffer = new byte[1024];
			//		buffer = reader.ReadBytes(buffer.Length);
			//		s = System.Text.Encoding.Default.GetString(buffer);
			//	}
			//	MessageBox.Show(s);
			//}
			return pathString;
		}

		private void BackButton_Click(object sender, EventArgs e)
		{
			LoginInfogroupBox.Visible = false;
			FirstButtonsGroup.Enabled = true;
		}

		private void ManageControlsGroupPresentation(bool _isNew)
		{
			//env=bling needed components
			LoginInfogroupBox.Visible = true;
			FirstButtonsGroup.Enabled = false;
			BackButton.Visible = true;

			if (_isNew)
			{
				textBox1.Visible = true;
				RandomizeButton.Visible = true;
				NamecomboBox.Visible = false;

			}
			else
			{
				textBox1.Visible = false;
				NamecomboBox.Visible = true;
			}
		}
	}
}
