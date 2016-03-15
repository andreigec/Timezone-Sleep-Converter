using ANDREICSLIB.NewControls;

namespace Timezone_Sleep_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.fromTZ = new System.Windows.Forms.ComboBox();
            this.setmytime = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toTZ = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.T1hoursawakelabel = new System.Windows.Forms.Label();
            this.T1hoursasleeplabel = new System.Windows.Forms.Label();
            this.T2hoursasleeplabel = new System.Windows.Forms.Label();
            this.T2hoursawakelabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.option1 = new System.Windows.Forms.Label();
            this.T2Bar = new DragBar();
            this.T1Bar = new DragBar();
            this.option2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Timezone:";
            // 
            // fromTZ
            // 
            this.fromTZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromTZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromTZ.FormattingEnabled = true;
            this.fromTZ.Location = new System.Drawing.Point(15, 57);
            this.fromTZ.Name = "fromTZ";
            this.fromTZ.Size = new System.Drawing.Size(600, 21);
            this.fromTZ.TabIndex = 2;
            this.fromTZ.TextChanged += new System.EventHandler(this.fromTZ_TextChanged);
            // 
            // setmytime
            // 
            this.setmytime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setmytime.Location = new System.Drawing.Point(621, 55);
            this.setmytime.Name = "setmytime";
            this.setmytime.Size = new System.Drawing.Size(119, 23);
            this.setmytime.TabIndex = 4;
            this.setmytime.Text = "Set to my time zone";
            this.setmytime.UseVisualStyleBackColor = true;
            this.setmytime.Click += new System.EventHandler(this.setmytime_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resize the bar to match the hours you are awake";
            // 
            // toTZ
            // 
            this.toTZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toTZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toTZ.FormattingEnabled = true;
            this.toTZ.Location = new System.Drawing.Point(12, 241);
            this.toTZ.Name = "toTZ";
            this.toTZ.Size = new System.Drawing.Size(722, 21);
            this.toTZ.TabIndex = 7;
            this.toTZ.TextChanged += new System.EventHandler(this.toTZ_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Foreign Timezone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resize the bar to match the hours you will be awake";
            // 
            // T1hoursawakelabel
            // 
            this.T1hoursawakelabel.AutoSize = true;
            this.T1hoursawakelabel.Location = new System.Drawing.Point(12, 180);
            this.T1hoursawakelabel.Name = "T1hoursawakelabel";
            this.T1hoursawakelabel.Size = new System.Drawing.Size(38, 13);
            this.T1hoursawakelabel.TabIndex = 10;
            this.T1hoursawakelabel.Text = "Hours:";
            // 
            // T1hoursasleeplabel
            // 
            this.T1hoursasleeplabel.AutoSize = true;
            this.T1hoursasleeplabel.Location = new System.Drawing.Point(122, 180);
            this.T1hoursasleeplabel.Name = "T1hoursasleeplabel";
            this.T1hoursasleeplabel.Size = new System.Drawing.Size(38, 13);
            this.T1hoursasleeplabel.TabIndex = 11;
            this.T1hoursasleeplabel.Text = "Hours:";
            // 
            // T2hoursasleeplabel
            // 
            this.T2hoursasleeplabel.AutoSize = true;
            this.T2hoursasleeplabel.Location = new System.Drawing.Point(122, 360);
            this.T2hoursasleeplabel.Name = "T2hoursasleeplabel";
            this.T2hoursasleeplabel.Size = new System.Drawing.Size(38, 13);
            this.T2hoursasleeplabel.TabIndex = 13;
            this.T2hoursasleeplabel.Text = "Hours:";
            // 
            // T2hoursawakelabel
            // 
            this.T2hoursawakelabel.AutoSize = true;
            this.T2hoursawakelabel.Location = new System.Drawing.Point(9, 360);
            this.T2hoursawakelabel.Name = "T2hoursawakelabel";
            this.T2hoursawakelabel.Size = new System.Drawing.Size(38, 13);
            this.T2hoursawakelabel.TabIndex = 12;
            this.T2hoursawakelabel.Text = "Hours:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "To match this foreign awake pattern:";
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.Location = new System.Drawing.Point(9, 419);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(35, 13);
            this.option1.TabIndex = 15;
            this.option1.Text = "label6";
            // 
            // T2Bar
            // 
            this.T2Bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.T2Bar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.T2Bar.BackColour = System.Drawing.Color.Gray;
            this.T2Bar.BarColour = System.Drawing.Color.Tomato;
            this.T2Bar.BarMaximumValue = 23;
            this.T2Bar.BarMinimumValue = 7;
            this.T2Bar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.T2Bar.DrawScale = true;
            this.T2Bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T2Bar.Location = new System.Drawing.Point(12, 287);
            this.T2Bar.MaximumValue = 24;
            this.T2Bar.MinimumValue = 0;
            this.T2Bar.Name = "T2Bar";
            this.T2Bar.ScaleColour = System.Drawing.Color.WhiteSmoke;
            this.T2Bar.Size = new System.Drawing.Size(725, 70);
            this.T2Bar.TabIndex = 8;
            this.T2Bar.BarValueChange += new DragBar.BarEvent(this.T2Bar_BarValueChange);
            // 
            // T1Bar
            // 
            this.T1Bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.T1Bar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.T1Bar.BackColour = System.Drawing.Color.Gray;
            this.T1Bar.BarColour = System.Drawing.Color.Tomato;
            this.T1Bar.BarMaximumValue = 23;
            this.T1Bar.BarMinimumValue = 7;
            this.T1Bar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.T1Bar.DrawScale = true;
            this.T1Bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T1Bar.Location = new System.Drawing.Point(12, 107);
            this.T1Bar.MaximumValue = 24;
            this.T1Bar.MinimumValue = 0;
            this.T1Bar.Name = "T1Bar";
            this.T1Bar.ScaleColour = System.Drawing.Color.WhiteSmoke;
            this.T1Bar.Size = new System.Drawing.Size(725, 70);
            this.T1Bar.TabIndex = 3;
            this.T1Bar.BarValueChange += new DragBar.BarEvent(this.dragBar1_BarValueChange);
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Location = new System.Drawing.Point(9, 449);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(35, 13);
            this.option2.TabIndex = 16;
            this.option2.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 480);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.T2hoursasleeplabel);
            this.Controls.Add(this.T2hoursawakelabel);
            this.Controls.Add(this.T1hoursasleeplabel);
            this.Controls.Add(this.T1hoursawakelabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.T2Bar);
            this.Controls.Add(this.toTZ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setmytime);
            this.Controls.Add(this.T1Bar);
            this.Controls.Add(this.fromTZ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox fromTZ;
        private ANDREICSLIB.NewControls.DragBar T1Bar;
		private System.Windows.Forms.Button setmytime;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox toTZ;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
        private ANDREICSLIB.NewControls.DragBar T2Bar;
		private System.Windows.Forms.Label T1hoursawakelabel;
		private System.Windows.Forms.Label T1hoursasleeplabel;
		private System.Windows.Forms.Label T2hoursasleeplabel;
		private System.Windows.Forms.Label T2hoursawakelabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label option1;
		private System.Windows.Forms.Label option2;
	}
}

