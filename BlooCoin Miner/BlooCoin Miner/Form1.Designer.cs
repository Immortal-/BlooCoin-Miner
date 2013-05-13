namespace BlooCoin_Miner
{
    partial class Miner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Miner));
            this.infobox = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.Label();
            this.threads = new System.Windows.Forms.Label();
            this.coins = new System.Windows.Forms.Label();
            this.hashI = new System.Windows.Forms.Label();
            this.logScreen = new System.Windows.Forms.TextBox();
            this.beginminer = new System.Windows.Forms.Button();
            this.endminer = new System.Windows.Forms.Button();
            this.settingsbox = new System.Windows.Forms.GroupBox();
            this.tamt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.thamt = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.set1 = new System.Windows.Forms.Label();
            this.infobox.SuspendLayout();
            this.settingsbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thamt)).BeginInit();
            this.SuspendLayout();
            // 
            // infobox
            // 
            this.infobox.Controls.Add(this.status);
            this.infobox.Controls.Add(this.threads);
            this.infobox.Controls.Add(this.coins);
            this.infobox.Controls.Add(this.hashI);
            this.infobox.Location = new System.Drawing.Point(11, 12);
            this.infobox.Name = "infobox";
            this.infobox.Size = new System.Drawing.Size(371, 62);
            this.infobox.TabIndex = 0;
            this.infobox.TabStop = false;
            this.infobox.Text = "Information";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(219, 38);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(76, 13);
            this.status.TabIndex = 3;
            this.status.Text = "Status: waiting";
            // 
            // threads
            // 
            this.threads.AutoSize = true;
            this.threads.Location = new System.Drawing.Point(219, 16);
            this.threads.Name = "threads";
            this.threads.Size = new System.Drawing.Size(58, 13);
            this.threads.TabIndex = 2;
            this.threads.Text = "Threads: 1";
            // 
            // coins
            // 
            this.coins.AutoSize = true;
            this.coins.Location = new System.Drawing.Point(6, 38);
            this.coins.Name = "coins";
            this.coins.Size = new System.Drawing.Size(64, 13);
            this.coins.TabIndex = 1;
            this.coins.Text = "Blc found: 0";
            // 
            // hashI
            // 
            this.hashI.AutoSize = true;
            this.hashI.Location = new System.Drawing.Point(6, 17);
            this.hashI.Name = "hashI";
            this.hashI.Size = new System.Drawing.Size(41, 13);
            this.hashI.TabIndex = 0;
            this.hashI.Text = "kh/s: 0";
            // 
            // logScreen
            // 
            this.logScreen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logScreen.Cursor = System.Windows.Forms.Cursors.Default;
            this.logScreen.Location = new System.Drawing.Point(9, 112);
            this.logScreen.Multiline = true;
            this.logScreen.Name = "logScreen";
            this.logScreen.ReadOnly = true;
            this.logScreen.Size = new System.Drawing.Size(371, 136);
            this.logScreen.TabIndex = 1;
            // 
            // beginminer
            // 
            this.beginminer.Image = ((System.Drawing.Image)(resources.GetObject("beginminer.Image")));
            this.beginminer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.beginminer.Location = new System.Drawing.Point(75, 79);
            this.beginminer.Name = "beginminer";
            this.beginminer.Size = new System.Drawing.Size(103, 23);
            this.beginminer.TabIndex = 2;
            this.beginminer.Text = "Start Mining";
            this.beginminer.UseVisualStyleBackColor = true;
            this.beginminer.Click += new System.EventHandler(this.beginminer_Click);
            // 
            // endminer
            // 
            this.endminer.Enabled = false;
            this.endminer.Image = ((System.Drawing.Image)(resources.GetObject("endminer.Image")));
            this.endminer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.endminer.Location = new System.Drawing.Point(210, 79);
            this.endminer.Name = "endminer";
            this.endminer.Size = new System.Drawing.Size(103, 23);
            this.endminer.TabIndex = 3;
            this.endminer.Text = "Stop Mining";
            this.endminer.UseVisualStyleBackColor = true;
            this.endminer.Click += new System.EventHandler(this.endminer_Click);
            // 
            // settingsbox
            // 
            this.settingsbox.Controls.Add(this.tamt);
            this.settingsbox.Controls.Add(this.label1);
            this.settingsbox.Controls.Add(this.thamt);
            this.settingsbox.Controls.Add(this.textBox1);
            this.settingsbox.Controls.Add(this.set1);
            this.settingsbox.Location = new System.Drawing.Point(9, 254);
            this.settingsbox.Name = "settingsbox";
            this.settingsbox.Size = new System.Drawing.Size(371, 115);
            this.settingsbox.TabIndex = 4;
            this.settingsbox.TabStop = false;
            this.settingsbox.Text = "Settings";
            // 
            // tamt
            // 
            this.tamt.AutoSize = true;
            this.tamt.Location = new System.Drawing.Point(6, 99);
            this.tamt.Name = "tamt";
            this.tamt.Size = new System.Drawing.Size(13, 13);
            this.tamt.TabIndex = 4;
            this.tamt.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "How many threads?";
            // 
            // thamt
            // 
            this.thamt.Location = new System.Drawing.Point(29, 65);
            this.thamt.Maximum = 1000;
            this.thamt.Minimum = 1;
            this.thamt.Name = "thamt";
            this.thamt.Size = new System.Drawing.Size(320, 45);
            this.thamt.TabIndex = 2;
            this.thamt.TickStyle = System.Windows.Forms.TickStyle.None;
            this.thamt.Value = 1;
            this.thamt.Scroll += new System.EventHandler(this.thamt_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 20);
            this.textBox1.TabIndex = 1;
            // 
            // set1
            // 
            this.set1.AutoSize = true;
            this.set1.Location = new System.Drawing.Point(7, 15);
            this.set1.Name = "set1";
            this.set1.Size = new System.Drawing.Size(123, 13);
            this.set1.TabIndex = 0;
            this.set1.Text = "Your BlooCoing address:";
            // 
            // Miner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 378);
            this.Controls.Add(this.settingsbox);
            this.Controls.Add(this.endminer);
            this.Controls.Add(this.beginminer);
            this.Controls.Add(this.logScreen);
            this.Controls.Add(this.infobox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Miner";
            this.Text = "BlooCoin Miner";
            this.infobox.ResumeLayout(false);
            this.infobox.PerformLayout();
            this.settingsbox.ResumeLayout(false);
            this.settingsbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thamt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox infobox;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label threads;
        private System.Windows.Forms.Label coins;
        private System.Windows.Forms.Label hashI;
        private System.Windows.Forms.TextBox logScreen;
        private System.Windows.Forms.Button beginminer;
        private System.Windows.Forms.Button endminer;
        private System.Windows.Forms.GroupBox settingsbox;
        private System.Windows.Forms.TrackBar thamt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label set1;
        private System.Windows.Forms.Label tamt;
        private System.Windows.Forms.Label label1;
    }
}

