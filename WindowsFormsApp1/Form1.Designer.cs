namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.JornalButton = new System.Windows.Forms.Button();
			this.TavernButton = new System.Windows.Forms.Button();
			this.StrtQuest = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.RecoverButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.GetQuestButon = new System.Windows.Forms.Button();
			this.LeaveTavernButton = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.QuestDescrioptionlabel = new System.Windows.Forms.TextBox();
			this.RewardLabel = new System.Windows.Forms.Label();
			this.DirectionLabel = new System.Windows.Forms.Label();
			this.Stamina = new System.Windows.Forms.Label();
			this.QuestName = new System.Windows.Forms.Label();
			this.TavernTimer = new System.Windows.Forms.Timer(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.StaminatextBox = new System.Windows.Forms.TextBox();
			this.GoldtextBox = new System.Windows.Forms.TextBox();
			this.HPtextBox = new System.Windows.Forms.TextBox();
			this.StaminaLabel = new System.Windows.Forms.Label();
			this.MoneyLabel = new System.Windows.Forms.Label();
			this.HPLabel = new System.Windows.Forms.Label();
			this.QuesTimer = new System.Windows.Forms.Timer(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tabControl1.Location = new System.Drawing.Point(0, 94);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(539, 335);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.JornalButton);
			this.tabPage1.Controls.Add(this.TavernButton);
			this.tabPage1.Controls.Add(this.StrtQuest);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(531, 306);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "City";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// JornalButton
			// 
			this.JornalButton.Location = new System.Drawing.Point(3, 45);
			this.JornalButton.Name = "JornalButton";
			this.JornalButton.Size = new System.Drawing.Size(131, 33);
			this.JornalButton.TabIndex = 0;
			this.JornalButton.Text = "Read Journal";
			this.JornalButton.UseVisualStyleBackColor = true;
			this.JornalButton.Click += new System.EventHandler(this.JornalButton_Click);
			// 
			// TavernButton
			// 
			this.TavernButton.Location = new System.Drawing.Point(3, 6);
			this.TavernButton.Name = "TavernButton";
			this.TavernButton.Size = new System.Drawing.Size(131, 33);
			this.TavernButton.TabIndex = 0;
			this.TavernButton.Text = "Visit Tavern";
			this.TavernButton.UseVisualStyleBackColor = true;
			this.TavernButton.Click += new System.EventHandler(this.TavernButton_Click);
			// 
			// StrtQuest
			// 
			this.StrtQuest.Enabled = false;
			this.StrtQuest.Location = new System.Drawing.Point(394, 6);
			this.StrtQuest.Name = "StrtQuest";
			this.StrtQuest.Size = new System.Drawing.Size(131, 33);
			this.StrtQuest.TabIndex = 0;
			this.StrtQuest.Text = "Start Quest";
			this.StrtQuest.UseVisualStyleBackColor = true;
			this.StrtQuest.Click += new System.EventHandler(this.StrtQuest_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(531, 306);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Tavern";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.RecoverButton);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.GetQuestButon);
			this.groupBox2.Controls.Add(this.LeaveTavernButton);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(525, 300);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Inn";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// RecoverButton
			// 
			this.RecoverButton.Location = new System.Drawing.Point(6, 22);
			this.RecoverButton.Name = "RecoverButton";
			this.RecoverButton.Size = new System.Drawing.Size(120, 29);
			this.RecoverButton.TabIndex = 0;
			this.RecoverButton.Text = "Get el";
			this.RecoverButton.UseVisualStyleBackColor = true;
			this.RecoverButton.Click += new System.EventHandler(this.RecoverButton_Click);
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(6, 147);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(513, 117);
			this.textBox1.TabIndex = 1;
			// 
			// GetQuestButon
			// 
			this.GetQuestButon.Location = new System.Drawing.Point(6, 57);
			this.GetQuestButon.Name = "GetQuestButon";
			this.GetQuestButon.Size = new System.Drawing.Size(120, 29);
			this.GetQuestButon.TabIndex = 0;
			this.GetQuestButon.Text = "Listen the rumors";
			this.GetQuestButon.UseVisualStyleBackColor = true;
			this.GetQuestButon.Click += new System.EventHandler(this.GetQuestButon_Click);
			// 
			// LeaveTavernButton
			// 
			this.LeaveTavernButton.Location = new System.Drawing.Point(399, 22);
			this.LeaveTavernButton.Name = "LeaveTavernButton";
			this.LeaveTavernButton.Size = new System.Drawing.Size(120, 29);
			this.LeaveTavernButton.TabIndex = 0;
			this.LeaveTavernButton.Text = "LeaveTavern";
			this.LeaveTavernButton.UseVisualStyleBackColor = true;
			this.LeaveTavernButton.Click += new System.EventHandler(this.LeaveTavernButton_Click);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.groupBox4);
			this.tabPage3.Controls.Add(this.groupBox3);
			this.tabPage3.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(531, 306);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Journal";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.listView1);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(0, 133);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(531, 173);
			this.groupBox4.TabIndex = 19;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Previous Records";
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Description});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.Location = new System.Drawing.Point(3, 19);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(525, 151);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// Title
			// 
			this.Title.Text = "Title";
			this.Title.Width = 122;
			// 
			// Description
			// 
			this.Description.Text = "Description";
			this.Description.Width = 460;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.QuestDescrioptionlabel);
			this.groupBox3.Controls.Add(this.RewardLabel);
			this.groupBox3.Controls.Add(this.DirectionLabel);
			this.groupBox3.Controls.Add(this.Stamina);
			this.groupBox3.Controls.Add(this.QuestName);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox3.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
			this.groupBox3.Location = new System.Drawing.Point(0, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(531, 133);
			this.groupBox3.TabIndex = 18;
			this.groupBox3.TabStop = false;
			// 
			// QuestDescrioptionlabel
			// 
			this.QuestDescrioptionlabel.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
			this.QuestDescrioptionlabel.ForeColor = System.Drawing.Color.Black;
			this.QuestDescrioptionlabel.Location = new System.Drawing.Point(7, 32);
			this.QuestDescrioptionlabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.QuestDescrioptionlabel.Multiline = true;
			this.QuestDescrioptionlabel.Name = "QuestDescrioptionlabel";
			this.QuestDescrioptionlabel.ReadOnly = true;
			this.QuestDescrioptionlabel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.QuestDescrioptionlabel.Size = new System.Drawing.Size(499, 63);
			this.QuestDescrioptionlabel.TabIndex = 22;
			// 
			// RewardLabel
			// 
			this.RewardLabel.AutoSize = true;
			this.RewardLabel.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
			this.RewardLabel.Location = new System.Drawing.Point(435, 99);
			this.RewardLabel.Name = "RewardLabel";
			this.RewardLabel.Size = new System.Drawing.Size(51, 17);
			this.RewardLabel.TabIndex = 18;
			this.RewardLabel.Text = "Reward";
			// 
			// DirectionLabel
			// 
			this.DirectionLabel.AutoSize = true;
			this.DirectionLabel.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
			this.DirectionLabel.Location = new System.Drawing.Point(211, 99);
			this.DirectionLabel.Name = "DirectionLabel";
			this.DirectionLabel.Size = new System.Drawing.Size(61, 17);
			this.DirectionLabel.TabIndex = 19;
			this.DirectionLabel.Text = "Direction";
			// 
			// Stamina
			// 
			this.Stamina.AutoSize = true;
			this.Stamina.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
			this.Stamina.Location = new System.Drawing.Point(10, 99);
			this.Stamina.Name = "Stamina";
			this.Stamina.Size = new System.Drawing.Size(41, 17);
			this.Stamina.TabIndex = 20;
			this.Stamina.Text = "label1";
			// 
			// QuestName
			// 
			this.QuestName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.QuestName.AutoSize = true;
			this.QuestName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.QuestName.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic);
			this.QuestName.Location = new System.Drawing.Point(7, 10);
			this.QuestName.Name = "QuestName";
			this.QuestName.Size = new System.Drawing.Size(43, 19);
			this.QuestName.TabIndex = 21;
			this.QuestName.Text = "label1";
			// 
			// TavernTimer
			// 
			this.TavernTimer.Interval = 1000;
			this.TavernTimer.Tick += new System.EventHandler(this.TavernTimer_Tick);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.StaminatextBox);
			this.groupBox1.Controls.Add(this.GoldtextBox);
			this.groupBox1.Controls.Add(this.HPtextBox);
			this.groupBox1.Controls.Add(this.StaminaLabel);
			this.groupBox1.Controls.Add(this.MoneyLabel);
			this.groupBox1.Controls.Add(this.HPLabel);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(539, 94);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Player Stats";
			// 
			// StaminatextBox
			// 
			this.StaminatextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.StaminatextBox.Enabled = false;
			this.StaminatextBox.Location = new System.Drawing.Point(70, 65);
			this.StaminatextBox.Name = "StaminatextBox";
			this.StaminatextBox.ReadOnly = true;
			this.StaminatextBox.Size = new System.Drawing.Size(68, 23);
			this.StaminatextBox.TabIndex = 1;
			// 
			// GoldtextBox
			// 
			this.GoldtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.GoldtextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.GoldtextBox.Enabled = false;
			this.GoldtextBox.Location = new System.Drawing.Point(420, 12);
			this.GoldtextBox.Name = "GoldtextBox";
			this.GoldtextBox.ReadOnly = true;
			this.GoldtextBox.Size = new System.Drawing.Size(99, 23);
			this.GoldtextBox.TabIndex = 1;
			// 
			// HPtextBox
			// 
			this.HPtextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.HPtextBox.Enabled = false;
			this.HPtextBox.Location = new System.Drawing.Point(70, 28);
			this.HPtextBox.Name = "HPtextBox";
			this.HPtextBox.ReadOnly = true;
			this.HPtextBox.Size = new System.Drawing.Size(68, 23);
			this.HPtextBox.TabIndex = 1;
			// 
			// StaminaLabel
			// 
			this.StaminaLabel.AutoSize = true;
			this.StaminaLabel.Location = new System.Drawing.Point(13, 68);
			this.StaminaLabel.Name = "StaminaLabel";
			this.StaminaLabel.Size = new System.Drawing.Size(51, 16);
			this.StaminaLabel.TabIndex = 0;
			this.StaminaLabel.Text = "Stamina";
			// 
			// MoneyLabel
			// 
			this.MoneyLabel.AutoSize = true;
			this.MoneyLabel.Location = new System.Drawing.Point(379, 19);
			this.MoneyLabel.Name = "MoneyLabel";
			this.MoneyLabel.Size = new System.Drawing.Size(35, 16);
			this.MoneyLabel.TabIndex = 0;
			this.MoneyLabel.Text = "Gold";
			// 
			// HPLabel
			// 
			this.HPLabel.AutoSize = true;
			this.HPLabel.Location = new System.Drawing.Point(13, 28);
			this.HPLabel.Name = "HPLabel";
			this.HPLabel.Size = new System.Drawing.Size(25, 16);
			this.HPLabel.TabIndex = 0;
			this.HPLabel.Text = "HP";
			// 
			// QuesTimer
			// 
			this.QuesTimer.Interval = 1000;
			this.QuesTimer.Tick += new System.EventHandler(this.QuesTimer_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(539, 429);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button GetQuestButon;
		private System.Windows.Forms.Button LeaveTavernButton;
		private System.Windows.Forms.Button RecoverButton;
		private System.Windows.Forms.Timer TavernTimer;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader Title;
		private System.Windows.Forms.ColumnHeader Description;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox QuestDescrioptionlabel;
		private System.Windows.Forms.Label RewardLabel;
		private System.Windows.Forms.Label DirectionLabel;
		private System.Windows.Forms.Label Stamina;
		private System.Windows.Forms.Label QuestName;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox StaminatextBox;
		private System.Windows.Forms.TextBox GoldtextBox;
		private System.Windows.Forms.TextBox HPtextBox;
		private System.Windows.Forms.Label StaminaLabel;
		private System.Windows.Forms.Label MoneyLabel;
		private System.Windows.Forms.Label HPLabel;
		private System.Windows.Forms.Button JornalButton;
		private System.Windows.Forms.Button TavernButton;
		private System.Windows.Forms.Button StrtQuest;
		private System.Windows.Forms.Timer QuesTimer;
	}
}

