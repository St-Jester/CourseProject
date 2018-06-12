namespace WindowsFormsApp1
{
	partial class QuestForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestForm));
			this.RewardLabel = new System.Windows.Forms.Label();
			this.Stamina = new System.Windows.Forms.Label();
			this.QuestName = new System.Windows.Forms.Label();
			this.AcceptQButton = new System.Windows.Forms.Button();
			this.DeclineQButton = new System.Windows.Forms.Button();
			this.QuestDescrioptionlabel = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// RewardLabel
			// 
			this.RewardLabel.AutoSize = true;
			this.RewardLabel.Location = new System.Drawing.Point(115, 160);
			this.RewardLabel.Name = "RewardLabel";
			this.RewardLabel.Size = new System.Drawing.Size(48, 16);
			this.RewardLabel.TabIndex = 5;
			this.RewardLabel.Text = "Reward";
			// 
			// Stamina
			// 
			this.Stamina.AutoSize = true;
			this.Stamina.Location = new System.Drawing.Point(45, 160);
			this.Stamina.Name = "Stamina";
			this.Stamina.Size = new System.Drawing.Size(39, 16);
			this.Stamina.TabIndex = 7;
			this.Stamina.Text = "label1";
			// 
			// QuestName
			// 
			this.QuestName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.QuestName.AutoSize = true;
			this.QuestName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.QuestName.Location = new System.Drawing.Point(232, 9);
			this.QuestName.Name = "QuestName";
			this.QuestName.Size = new System.Drawing.Size(41, 18);
			this.QuestName.TabIndex = 9;
			this.QuestName.Text = "label1";
			// 
			// AcceptQButton
			// 
			this.AcceptQButton.Location = new System.Drawing.Point(49, 224);
			this.AcceptQButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.AcceptQButton.Name = "AcceptQButton";
			this.AcceptQButton.Size = new System.Drawing.Size(87, 28);
			this.AcceptQButton.TabIndex = 3;
			this.AcceptQButton.Text = "Accept";
			this.AcceptQButton.UseVisualStyleBackColor = true;
			this.AcceptQButton.Click += new System.EventHandler(this.AcceptQButton_Click);
			// 
			// DeclineQButton
			// 
			this.DeclineQButton.Location = new System.Drawing.Point(366, 224);
			this.DeclineQButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.DeclineQButton.Name = "DeclineQButton";
			this.DeclineQButton.Size = new System.Drawing.Size(87, 28);
			this.DeclineQButton.TabIndex = 4;
			this.DeclineQButton.Text = "Decline";
			this.DeclineQButton.UseVisualStyleBackColor = true;
			this.DeclineQButton.Click += new System.EventHandler(this.DeclineQButton_Click);
			// 
			// QuestDescrioptionlabel
			// 
			this.QuestDescrioptionlabel.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.QuestDescrioptionlabel.ForeColor = System.Drawing.Color.Black;
			this.QuestDescrioptionlabel.Location = new System.Drawing.Point(14, 52);
			this.QuestDescrioptionlabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.QuestDescrioptionlabel.Multiline = true;
			this.QuestDescrioptionlabel.Name = "QuestDescrioptionlabel";
			this.QuestDescrioptionlabel.ReadOnly = true;
			this.QuestDescrioptionlabel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.QuestDescrioptionlabel.Size = new System.Drawing.Size(499, 91);
			this.QuestDescrioptionlabel.TabIndex = 10;
			// 
			// QuestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525, 366);
			this.Controls.Add(this.QuestDescrioptionlabel);
			this.Controls.Add(this.RewardLabel);
			this.Controls.Add(this.Stamina);
			this.Controls.Add(this.QuestName);
			this.Controls.Add(this.AcceptQButton);
			this.Controls.Add(this.DeclineQButton);
			this.Font = new System.Drawing.Font("Goudy Old Style", 9.75F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "QuestForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QuestForm";
			this.Load += new System.EventHandler(this.QuestForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label RewardLabel;
		private System.Windows.Forms.Label Stamina;
		private System.Windows.Forms.Label QuestName;
		private System.Windows.Forms.Button AcceptQButton;
		private System.Windows.Forms.Button DeclineQButton;
		private System.Windows.Forms.TextBox QuestDescrioptionlabel;
	}
}