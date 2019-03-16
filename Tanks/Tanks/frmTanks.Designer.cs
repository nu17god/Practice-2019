namespace Tanks
{
    partial class frmTanks
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlMap = new System.Windows.Forms.PictureBox();
            this.ctlTime = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPause = new System.Windows.Forms.Label();
            this.lblReloadValue = new System.Windows.Forms.Label();
            this.lblReload = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblScoretxt = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlMap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // ctlMap
            // 
            this.ctlMap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctlMap.Location = new System.Drawing.Point(0, 54);
            this.ctlMap.Name = "ctlMap";
            this.ctlMap.Size = new System.Drawing.Size(640, 640);
            this.ctlMap.TabIndex = 1;
            this.ctlMap.TabStop = false;
            // 
            // ctlTime
            // 
            this.ctlTime.Tick += new System.EventHandler(this.ctlTime_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.lblPause);
            this.panel1.Controls.Add(this.lblReloadValue);
            this.panel1.Controls.Add(this.lblReload);
            this.panel1.Controls.Add(this.lblScoreValue);
            this.panel1.Controls.Add(this.lblScoretxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 30);
            this.panel1.TabIndex = 2;
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPause.ForeColor = System.Drawing.Color.White;
            this.lblPause.Location = new System.Drawing.Point(3, 4);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(212, 20);
            this.lblPause.TabIndex = 4;
            this.lblPause.Text = "Press \"P\" to pause the game";
            // 
            // lblReloadValue
            // 
            this.lblReloadValue.AutoSize = true;
            this.lblReloadValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReloadValue.ForeColor = System.Drawing.Color.Green;
            this.lblReloadValue.Location = new System.Drawing.Point(554, 4);
            this.lblReloadValue.Name = "lblReloadValue";
            this.lblReloadValue.Size = new System.Drawing.Size(55, 20);
            this.lblReloadValue.TabIndex = 3;
            this.lblReloadValue.Text = "Ready";
            // 
            // lblReload
            // 
            this.lblReload.AutoSize = true;
            this.lblReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReload.ForeColor = System.Drawing.Color.White;
            this.lblReload.Location = new System.Drawing.Point(480, 4);
            this.lblReload.Name = "lblReload";
            this.lblReload.Size = new System.Drawing.Size(68, 20);
            this.lblReload.TabIndex = 2;
            this.lblReload.Text = "Reload :";
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScoreValue.ForeColor = System.Drawing.Color.White;
            this.lblScoreValue.Location = new System.Drawing.Point(349, 4);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(18, 20);
            this.lblScoreValue.TabIndex = 1;
            this.lblScoreValue.Text = "0";
            // 
            // lblScoretxt
            // 
            this.lblScoretxt.AutoSize = true;
            this.lblScoretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScoretxt.ForeColor = System.Drawing.Color.White;
            this.lblScoretxt.Location = new System.Drawing.Point(280, 4);
            this.lblScoretxt.Name = "lblScoretxt";
            this.lblScoretxt.Size = new System.Drawing.Size(63, 20);
            this.lblScoretxt.TabIndex = 0;
            this.lblScoretxt.Text = "Score : ";
            // 
            // frmTanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 694);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctlMap);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(656, 733);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(656, 733);
            this.Name = "frmTanks";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle City Remake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTanks_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlMap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.PictureBox ctlMap;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Timer ctlTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblScoreValue;
        private System.Windows.Forms.Label lblScoretxt;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label lblReloadValue;
        private System.Windows.Forms.Label lblReload;
    }
}

