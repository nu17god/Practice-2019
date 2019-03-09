namespace Tanks
{
    partial class frmNewGame
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
            this.lblAppleCount = new System.Windows.Forms.Label();
            this.lblTanksCount = new System.Windows.Forms.Label();
            this.ctlAppleCount = new System.Windows.Forms.NumericUpDown();
            this.ctlTanksCount = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.ctlSpeed = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.ctlSize = new System.Windows.Forms.GroupBox();
            this.btnSize3 = new System.Windows.Forms.RadioButton();
            this.btnSize2 = new System.Windows.Forms.RadioButton();
            this.btnSize1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ctlAppleCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlTanksCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlSpeed)).BeginInit();
            this.ctlSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAppleCount
            // 
            this.lblAppleCount.AutoSize = true;
            this.lblAppleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAppleCount.Location = new System.Drawing.Point(16, 16);
            this.lblAppleCount.Name = "lblAppleCount";
            this.lblAppleCount.Size = new System.Drawing.Size(97, 20);
            this.lblAppleCount.TabIndex = 0;
            this.lblAppleCount.Text = "Apple Count";
            // 
            // lblTanksCount
            // 
            this.lblTanksCount.AutoSize = true;
            this.lblTanksCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTanksCount.Location = new System.Drawing.Point(16, 61);
            this.lblTanksCount.Name = "lblTanksCount";
            this.lblTanksCount.Size = new System.Drawing.Size(118, 20);
            this.lblTanksCount.TabIndex = 1;
            this.lblTanksCount.Text = "Enemies Count";
            // 
            // ctlAppleCount
            // 
            this.ctlAppleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ctlAppleCount.Location = new System.Drawing.Point(140, 14);
            this.ctlAppleCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ctlAppleCount.Name = "ctlAppleCount";
            this.ctlAppleCount.ReadOnly = true;
            this.ctlAppleCount.Size = new System.Drawing.Size(75, 26);
            this.ctlAppleCount.TabIndex = 2;
            this.ctlAppleCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ctlTanksCount
            // 
            this.ctlTanksCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ctlTanksCount.Location = new System.Drawing.Point(140, 55);
            this.ctlTanksCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ctlTanksCount.Name = "ctlTanksCount";
            this.ctlTanksCount.ReadOnly = true;
            this.ctlTanksCount.Size = new System.Drawing.Size(75, 26);
            this.ctlTanksCount.TabIndex = 3;
            this.ctlTanksCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(354, 149);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 30);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ctlSpeed
            // 
            this.ctlSpeed.Location = new System.Drawing.Point(140, 99);
            this.ctlSpeed.Maximum = 5;
            this.ctlSpeed.Minimum = 1;
            this.ctlSpeed.Name = "ctlSpeed";
            this.ctlSpeed.Size = new System.Drawing.Size(75, 45);
            this.ctlSpeed.TabIndex = 5;
            this.ctlSpeed.Value = 1;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpeed.Location = new System.Drawing.Point(16, 99);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(56, 20);
            this.lblSpeed.TabIndex = 6;
            this.lblSpeed.Text = "Speed";
            // 
            // ctlSize
            // 
            this.ctlSize.Controls.Add(this.btnSize3);
            this.ctlSize.Controls.Add(this.btnSize2);
            this.ctlSize.Controls.Add(this.btnSize1);
            this.ctlSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ctlSize.Location = new System.Drawing.Point(252, 12);
            this.ctlSize.Name = "ctlSize";
            this.ctlSize.Size = new System.Drawing.Size(192, 128);
            this.ctlSize.TabIndex = 8;
            this.ctlSize.TabStop = false;
            this.ctlSize.Text = "Map size";
            // 
            // btnSize3
            // 
            this.btnSize3.AutoSize = true;
            this.btnSize3.Location = new System.Drawing.Point(11, 85);
            this.btnSize3.Name = "btnSize3";
            this.btnSize3.Size = new System.Drawing.Size(78, 24);
            this.btnSize3.TabIndex = 2;
            this.btnSize3.Text = "40 x 40";
            this.btnSize3.UseVisualStyleBackColor = true;
            // 
            // btnSize2
            // 
            this.btnSize2.AutoSize = true;
            this.btnSize2.Location = new System.Drawing.Point(11, 55);
            this.btnSize2.Name = "btnSize2";
            this.btnSize2.Size = new System.Drawing.Size(78, 24);
            this.btnSize2.TabIndex = 1;
            this.btnSize2.Text = "20 x 20";
            this.btnSize2.UseVisualStyleBackColor = true;
            // 
            // btnSize1
            // 
            this.btnSize1.AutoSize = true;
            this.btnSize1.Checked = true;
            this.btnSize1.Location = new System.Drawing.Point(11, 25);
            this.btnSize1.Name = "btnSize1";
            this.btnSize1.Size = new System.Drawing.Size(78, 24);
            this.btnSize1.TabIndex = 0;
            this.btnSize1.TabStop = true;
            this.btnSize1.Text = "10 x 10";
            this.btnSize1.UseVisualStyleBackColor = true;
            // 
            // frmNewGame
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 191);
            this.Controls.Add(this.ctlSize);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.ctlSpeed);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ctlTanksCount);
            this.Controls.Add(this.ctlAppleCount);
            this.Controls.Add(this.lblTanksCount);
            this.Controls.Add(this.lblAppleCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 230);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 230);
            this.Name = "frmNewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Game";
            ((System.ComponentModel.ISupportInitialize)(this.ctlAppleCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlTanksCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlSpeed)).EndInit();
            this.ctlSize.ResumeLayout(false);
            this.ctlSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppleCount;
        private System.Windows.Forms.Label lblTanksCount;
        private System.Windows.Forms.NumericUpDown ctlAppleCount;
        private System.Windows.Forms.NumericUpDown ctlTanksCount;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TrackBar ctlSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.GroupBox ctlSize;
        private System.Windows.Forms.RadioButton btnSize3;
        private System.Windows.Forms.RadioButton btnSize2;
        private System.Windows.Forms.RadioButton btnSize1;
    }
}