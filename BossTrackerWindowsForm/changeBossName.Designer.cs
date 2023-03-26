namespace BossTrackerWindowsForm
{
    partial class changeBossName
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
            this.bossNameLabel = new System.Windows.Forms.Label();
            this.newBossNameTextBox = new System.Windows.Forms.TextBox();
            this.acceptNewNameButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bossNameLabel
            // 
            this.bossNameLabel.AutoSize = true;
            this.bossNameLabel.Location = new System.Drawing.Point(25, 13);
            this.bossNameLabel.Name = "bossNameLabel";
            this.bossNameLabel.Size = new System.Drawing.Size(57, 13);
            this.bossNameLabel.TabIndex = 0;
            this.bossNameLabel.Text = "bossName";
            // 
            // newBossNameTextBox
            // 
            this.newBossNameTextBox.Location = new System.Drawing.Point(28, 38);
            this.newBossNameTextBox.Name = "newBossNameTextBox";
            this.newBossNameTextBox.Size = new System.Drawing.Size(320, 20);
            this.newBossNameTextBox.TabIndex = 1;
            // 
            // acceptNewNameButton
            // 
            this.acceptNewNameButton.Location = new System.Drawing.Point(28, 65);
            this.acceptNewNameButton.Name = "acceptNewNameButton";
            this.acceptNewNameButton.Size = new System.Drawing.Size(75, 23);
            this.acceptNewNameButton.TabIndex = 2;
            this.acceptNewNameButton.Text = "Accept";
            this.acceptNewNameButton.UseVisualStyleBackColor = true;
            this.acceptNewNameButton.Click += new System.EventHandler(this.acceptNewNameButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(110, 64);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // changeBossName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 104);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptNewNameButton);
            this.Controls.Add(this.newBossNameTextBox);
            this.Controls.Add(this.bossNameLabel);
            this.Name = "changeBossName";
            this.Text = "Change Boss Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bossNameLabel;
        private System.Windows.Forms.TextBox newBossNameTextBox;
        private System.Windows.Forms.Button acceptNewNameButton;
        private System.Windows.Forms.Button cancelButton;
    }
}