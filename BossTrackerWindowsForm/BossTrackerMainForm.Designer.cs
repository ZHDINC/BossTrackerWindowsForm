namespace BossTrackerWindowsForm
{
    partial class BossTrackerMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BossTrackerMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bossListBox = new System.Windows.Forms.ListBox();
            this.bossNameLabel = new System.Windows.Forms.Label();
            this.bossFoughtInt = new System.Windows.Forms.NumericUpDown();
            this.bossVictoryInt = new System.Windows.Forms.NumericUpDown();
            this.beatenCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bossAddTextBox = new System.Windows.Forms.TextBox();
            this.bossAdd = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bossFoughtInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossVictoryInt)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // bossListBox
            // 
            this.bossListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bossListBox.FormattingEnabled = true;
            this.bossListBox.Location = new System.Drawing.Point(12, 82);
            this.bossListBox.Name = "bossListBox";
            this.bossListBox.Size = new System.Drawing.Size(131, 121);
            this.bossListBox.TabIndex = 1;
            this.bossListBox.SelectedIndexChanged += new System.EventHandler(this.bossListBox_SelectedIndexChanged);
            this.bossListBox.SelectedValueChanged += new System.EventHandler(this.bossListBox_SelectedValueChanged);
            this.bossListBox.DoubleClick += new System.EventHandler(this.bossListBox_DoubleClick);
            // 
            // bossNameLabel
            // 
            this.bossNameLabel.AutoSize = true;
            this.bossNameLabel.Location = new System.Drawing.Point(159, 92);
            this.bossNameLabel.Name = "bossNameLabel";
            this.bossNameLabel.Size = new System.Drawing.Size(0, 13);
            this.bossNameLabel.TabIndex = 2;
            // 
            // bossFoughtInt
            // 
            this.bossFoughtInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bossFoughtInt.Location = new System.Drawing.Point(159, 133);
            this.bossFoughtInt.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.bossFoughtInt.Name = "bossFoughtInt";
            this.bossFoughtInt.Size = new System.Drawing.Size(120, 20);
            this.bossFoughtInt.TabIndex = 3;
            this.bossFoughtInt.ValueChanged += new System.EventHandler(this.bossFoughtInt_ValueChanged);
            // 
            // bossVictoryInt
            // 
            this.bossVictoryInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bossVictoryInt.Location = new System.Drawing.Point(312, 133);
            this.bossVictoryInt.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.bossVictoryInt.Name = "bossVictoryInt";
            this.bossVictoryInt.Size = new System.Drawing.Size(120, 20);
            this.bossVictoryInt.TabIndex = 4;
            this.bossVictoryInt.ValueChanged += new System.EventHandler(this.bossVictoryInt_ValueChanged);
            // 
            // beatenCheckBox
            // 
            this.beatenCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.beatenCheckBox.AutoSize = true;
            this.beatenCheckBox.Location = new System.Drawing.Point(312, 170);
            this.beatenCheckBox.Name = "beatenCheckBox";
            this.beatenCheckBox.Size = new System.Drawing.Size(66, 17);
            this.beatenCheckBox.TabIndex = 5;
            this.beatenCheckBox.Text = "Beaten?";
            this.beatenCheckBox.UseVisualStyleBackColor = true;
            this.beatenCheckBox.CheckedChanged += new System.EventHandler(this.beatenCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of times fought";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of times victorious";
            // 
            // bossAddTextBox
            // 
            this.bossAddTextBox.Location = new System.Drawing.Point(12, 39);
            this.bossAddTextBox.Name = "bossAddTextBox";
            this.bossAddTextBox.Size = new System.Drawing.Size(177, 20);
            this.bossAddTextBox.TabIndex = 8;
            // 
            // bossAdd
            // 
            this.bossAdd.Location = new System.Drawing.Point(205, 36);
            this.bossAdd.Name = "bossAdd";
            this.bossAdd.Size = new System.Drawing.Size(113, 23);
            this.bossAdd.TabIndex = 9;
            this.bossAdd.Text = "Add Boss";
            this.bossAdd.UseVisualStyleBackColor = true;
            this.bossAdd.Click += new System.EventHandler(this.bossAdd_Click);
            // 
            // BossTrackerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 216);
            this.Controls.Add(this.bossAdd);
            this.Controls.Add(this.bossAddTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.beatenCheckBox);
            this.Controls.Add(this.bossVictoryInt);
            this.Controls.Add(this.bossFoughtInt);
            this.Controls.Add(this.bossNameLabel);
            this.Controls.Add(this.bossListBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BossTrackerMainForm";
            this.Text = "Boss Tracker";
            this.Load += new System.EventHandler(this.BossTrackerMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bossFoughtInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossVictoryInt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ListBox bossListBox;
        private System.Windows.Forms.Label bossNameLabel;
        private System.Windows.Forms.NumericUpDown bossFoughtInt;
        private System.Windows.Forms.NumericUpDown bossVictoryInt;
        private System.Windows.Forms.CheckBox beatenCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bossAddTextBox;
        private System.Windows.Forms.Button bossAdd;
    }
}

