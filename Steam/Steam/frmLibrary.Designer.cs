namespace SteamLibrary
{
    partial class frm_steamLibrary
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
            this.lbGames = new System.Windows.Forms.ListBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHoursPlayed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAchievementName = new System.Windows.Forms.Label();
            this.cmbAchievements = new System.Windows.Forms.ComboBox();
            this.lblAchievementDescription = new System.Windows.Forms.Label();
            this.lblNM = new System.Windows.Forms.Label();
            this.lblIsIntalled = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumberOfGames = new System.Windows.Forms.Label();
            this.lblIsCompleted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbGames
            // 
            this.lbGames.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGames.ForeColor = System.Drawing.SystemColors.Window;
            this.lbGames.FormattingEnabled = true;
            this.lbGames.ItemHeight = 31;
            this.lbGames.Location = new System.Drawing.Point(38, 94);
            this.lbGames.Name = "lbGames";
            this.lbGames.Size = new System.Drawing.Size(312, 531);
            this.lbGames.TabIndex = 0;
            this.lbGames.SelectedIndexChanged += new System.EventHandler(this.lbGames_SelectedIndexChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserName.Location = new System.Drawing.Point(102, 26);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(100, 37);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "label1";
            this.lblUserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "User:";
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGameName.Location = new System.Drawing.Point(411, 85);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(274, 55);
            this.lblGameName.TabIndex = 4;
            this.lblGameName.Text = "gameName";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Black;
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescription.Location = new System.Drawing.Point(416, 163);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(807, 31);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "                                                                                 " +
    "                                                   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1044, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "hours played";
            // 
            // lblHoursPlayed
            // 
            this.lblHoursPlayed.AutoSize = true;
            this.lblHoursPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursPlayed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHoursPlayed.Location = new System.Drawing.Point(953, 106);
            this.lblHoursPlayed.MaximumSize = new System.Drawing.Size(97, 29);
            this.lblHoursPlayed.MinimumSize = new System.Drawing.Size(97, 29);
            this.lblHoursPlayed.Name = "lblHoursPlayed";
            this.lblHoursPlayed.Size = new System.Drawing.Size(97, 29);
            this.lblHoursPlayed.TabIndex = 7;
            this.lblHoursPlayed.Text = "1000.00";
            this.lblHoursPlayed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(416, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Achievements";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblAchievementName
            // 
            this.lblAchievementName.AutoSize = true;
            this.lblAchievementName.BackColor = System.Drawing.Color.Black;
            this.lblAchievementName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAchievementName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchievementName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAchievementName.Location = new System.Drawing.Point(421, 373);
            this.lblAchievementName.Name = "lblAchievementName";
            this.lblAchievementName.Size = new System.Drawing.Size(204, 31);
            this.lblAchievementName.TabIndex = 9;
            this.lblAchievementName.Text = "AchivementName";
            this.lblAchievementName.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbAchievements
            // 
            this.cmbAchievements.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbAchievements.FormattingEnabled = true;
            this.cmbAchievements.Location = new System.Drawing.Point(691, 330);
            this.cmbAchievements.Name = "cmbAchievements";
            this.cmbAchievements.Size = new System.Drawing.Size(121, 21);
            this.cmbAchievements.TabIndex = 13;
            this.cmbAchievements.SelectedIndexChanged += new System.EventHandler(this.cmbAchievements_SelectedIndexChanged);
            // 
            // lblAchievementDescription
            // 
            this.lblAchievementDescription.AutoSize = true;
            this.lblAchievementDescription.BackColor = System.Drawing.Color.Black;
            this.lblAchievementDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAchievementDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchievementDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAchievementDescription.Location = new System.Drawing.Point(421, 429);
            this.lblAchievementDescription.Name = "lblAchievementDescription";
            this.lblAchievementDescription.Size = new System.Drawing.Size(783, 31);
            this.lblAchievementDescription.TabIndex = 14;
            this.lblAchievementDescription.Text = "label1aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            // 
            // lblNM
            // 
            this.lblNM.AutoSize = true;
            this.lblNM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNM.Location = new System.Drawing.Point(585, 321);
            this.lblNM.Name = "lblNM";
            this.lblNM.Size = new System.Drawing.Size(98, 29);
            this.lblNM.TabIndex = 15;
            this.lblNM.Text = "( N / M )";
            // 
            // lblIsIntalled
            // 
            this.lblIsIntalled.AutoSize = true;
            this.lblIsIntalled.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsIntalled.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIsIntalled.Location = new System.Drawing.Point(686, 106);
            this.lblIsIntalled.Name = "lblIsIntalled";
            this.lblIsIntalled.Size = new System.Drawing.Size(175, 29);
            this.lblIsIntalled.TabIndex = 16;
            this.lblIsIntalled.Text = "( Not Installed )";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(481, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 54);
            this.button1.TabIndex = 17;
            this.button1.Text = "Install / Uninstall";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(839, 539);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 54);
            this.button2.TabIndex = 18;
            this.button2.Text = "Play !";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(67, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "games";
            // 
            // lblNumberOfGames
            // 
            this.lblNumberOfGames.AutoSize = true;
            this.lblNumberOfGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfGames.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumberOfGames.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblNumberOfGames.Location = new System.Drawing.Point(12, 66);
            this.lblNumberOfGames.MinimumSize = new System.Drawing.Size(63, 25);
            this.lblNumberOfGames.Name = "lblNumberOfGames";
            this.lblNumberOfGames.Size = new System.Drawing.Size(63, 25);
            this.lblNumberOfGames.TabIndex = 20;
            this.lblNumberOfGames.Text = "User:";
            this.lblNumberOfGames.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblIsCompleted
            // 
            this.lblIsCompleted.AutoSize = true;
            this.lblIsCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsCompleted.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIsCompleted.Location = new System.Drawing.Point(649, 375);
            this.lblIsCompleted.Name = "lblIsCompleted";
            this.lblIsCompleted.Size = new System.Drawing.Size(148, 29);
            this.lblIsCompleted.TabIndex = 21;
            this.lblIsCompleted.Text = "(Completed)";
            // 
            // frm_steamLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblIsCompleted);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNumberOfGames);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblIsIntalled);
            this.Controls.Add(this.lblNM);
            this.Controls.Add(this.lblAchievementDescription);
            this.Controls.Add(this.cmbAchievements);
            this.Controls.Add(this.lblAchievementName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHoursPlayed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lbGames);
            this.Location = new System.Drawing.Point(5, 5);
            this.Name = "frm_steamLibrary";
            this.Text = "Steam Library";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_steamLibrary_FormClosed);
            this.Load += new System.EventHandler(this.frm_steamLibrary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGames;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHoursPlayed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAchievementName;
        private System.Windows.Forms.ComboBox cmbAchievements;
        private System.Windows.Forms.Label lblAchievementDescription;
        private System.Windows.Forms.Label lblNM;
        private System.Windows.Forms.Label lblIsIntalled;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumberOfGames;
        private System.Windows.Forms.Label lblIsCompleted;
    }
}

