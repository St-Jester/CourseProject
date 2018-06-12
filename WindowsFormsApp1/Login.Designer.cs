namespace WindowsFormsApp1
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.RandomizeButton = new System.Windows.Forms.Button();
			this.EnterButton = new System.Windows.Forms.Button();
			this.NewNameButton = new System.Windows.Forms.Button();
			this.SavedNameButton = new System.Windows.Forms.Button();
			this.NamecomboBox = new System.Windows.Forms.ComboBox();
			this.BackButton = new System.Windows.Forms.Button();
			this.LoginInfogroupBox = new System.Windows.Forms.GroupBox();
			this.FirstButtonsGroup = new System.Windows.Forms.GroupBox();
			this.LoginInfogroupBox.SuspendLayout();
			this.FirstButtonsGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(77, 12);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(142, 23);
			this.textBox1.TabIndex = 0;
			this.textBox1.Visible = false;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "My name is";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(127, 13);
			this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(297, 37);
			this.textBox2.TabIndex = 0;
			this.textBox2.Text = "Castle guard! What is your name?";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// RandomizeButton
			// 
			this.RandomizeButton.Location = new System.Drawing.Point(222, 13);
			this.RandomizeButton.Name = "RandomizeButton";
			this.RandomizeButton.Size = new System.Drawing.Size(75, 23);
			this.RandomizeButton.TabIndex = 2;
			this.RandomizeButton.Text = "Randomize";
			this.RandomizeButton.UseVisualStyleBackColor = true;
			this.RandomizeButton.Visible = false;
			this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
			// 
			// EnterButton
			// 
			this.EnterButton.Location = new System.Drawing.Point(0, 48);
			this.EnterButton.Name = "EnterButton";
			this.EnterButton.Size = new System.Drawing.Size(297, 23);
			this.EnterButton.TabIndex = 2;
			this.EnterButton.Text = "Enter the village";
			this.EnterButton.UseVisualStyleBackColor = true;
			this.EnterButton.Visible = false;
			this.EnterButton.Click += new System.EventHandler(this.button2_Click);
			// 
			// NewNameButton
			// 
			this.NewNameButton.Location = new System.Drawing.Point(0, 21);
			this.NewNameButton.Name = "NewNameButton";
			this.NewNameButton.Size = new System.Drawing.Size(297, 23);
			this.NewNameButton.TabIndex = 3;
			this.NewNameButton.Text = "I am a newcomer";
			this.NewNameButton.UseVisualStyleBackColor = true;
			this.NewNameButton.Click += new System.EventHandler(this.NewNameButton_Click);
			// 
			// SavedNameButton
			// 
			this.SavedNameButton.Location = new System.Drawing.Point(0, 51);
			this.SavedNameButton.Name = "SavedNameButton";
			this.SavedNameButton.Size = new System.Drawing.Size(297, 23);
			this.SavedNameButton.TabIndex = 3;
			this.SavedNameButton.Text = "C\'m on! Don\'t you see, it\'s me!";
			this.SavedNameButton.UseVisualStyleBackColor = true;
			this.SavedNameButton.Click += new System.EventHandler(this.SavedNameButton_Click);
			// 
			// NamecomboBox
			// 
			this.NamecomboBox.FormattingEnabled = true;
			this.NamecomboBox.Location = new System.Drawing.Point(77, 12);
			this.NamecomboBox.Name = "NamecomboBox";
			this.NamecomboBox.Size = new System.Drawing.Size(142, 24);
			this.NamecomboBox.TabIndex = 4;
			this.NamecomboBox.Visible = false;
			this.NamecomboBox.SelectedIndexChanged += new System.EventHandler(this.NamecomboBox_SelectedIndexChanged);
			// 
			// BackButton
			// 
			this.BackButton.Location = new System.Drawing.Point(443, 57);
			this.BackButton.Name = "BackButton";
			this.BackButton.Size = new System.Drawing.Size(75, 52);
			this.BackButton.TabIndex = 5;
			this.BackButton.Text = "Back";
			this.BackButton.UseVisualStyleBackColor = true;
			this.BackButton.Visible = false;
			this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
			// 
			// LoginInfogroupBox
			// 
			this.LoginInfogroupBox.Controls.Add(this.label1);
			this.LoginInfogroupBox.Controls.Add(this.NamecomboBox);
			this.LoginInfogroupBox.Controls.Add(this.RandomizeButton);
			this.LoginInfogroupBox.Controls.Add(this.EnterButton);
			this.LoginInfogroupBox.Controls.Add(this.textBox1);
			this.LoginInfogroupBox.Location = new System.Drawing.Point(127, 115);
			this.LoginInfogroupBox.Name = "LoginInfogroupBox";
			this.LoginInfogroupBox.Size = new System.Drawing.Size(297, 100);
			this.LoginInfogroupBox.TabIndex = 6;
			this.LoginInfogroupBox.TabStop = false;
			this.LoginInfogroupBox.Visible = false;
			// 
			// FirstButtonsGroup
			// 
			this.FirstButtonsGroup.Controls.Add(this.SavedNameButton);
			this.FirstButtonsGroup.Controls.Add(this.NewNameButton);
			this.FirstButtonsGroup.Location = new System.Drawing.Point(127, 35);
			this.FirstButtonsGroup.Name = "FirstButtonsGroup";
			this.FirstButtonsGroup.Size = new System.Drawing.Size(297, 87);
			this.FirstButtonsGroup.TabIndex = 5;
			this.FirstButtonsGroup.TabStop = false;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(530, 297);
			this.Controls.Add(this.BackButton);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.LoginInfogroupBox);
			this.Controls.Add(this.FirstButtonsGroup);
			this.Font = new System.Drawing.Font("Goudy Old Style", 9.75F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Login";
			this.Text = "Login";
			this.LoginInfogroupBox.ResumeLayout(false);
			this.LoginInfogroupBox.PerformLayout();
			this.FirstButtonsGroup.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button RandomizeButton;
		private System.Windows.Forms.Button EnterButton;
		private System.Windows.Forms.Button NewNameButton;
		private System.Windows.Forms.Button SavedNameButton;
		private System.Windows.Forms.ComboBox NamecomboBox;
		private System.Windows.Forms.Button BackButton;
		private System.Windows.Forms.GroupBox LoginInfogroupBox;
		private System.Windows.Forms.GroupBox FirstButtonsGroup;
	}
}