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
            ((System.ComponentModel.ISupportInitialize)(this.ctlAppleCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlTanksCount)).BeginInit();
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
            this.lblTanksCount.Location = new System.Drawing.Point(16, 54);
            this.lblTanksCount.Name = "lblTanksCount";
            this.lblTanksCount.Size = new System.Drawing.Size(118, 20);
            this.lblTanksCount.TabIndex = 1;
            this.lblTanksCount.Text = "Enemies Count";
            // 
            // ctlAppleCount
            // 
            this.ctlAppleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ctlAppleCount.Location = new System.Drawing.Point(162, 14);
            this.ctlAppleCount.Name = "ctlAppleCount";
            this.ctlAppleCount.Size = new System.Drawing.Size(120, 26);
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
            this.ctlTanksCount.Location = new System.Drawing.Point(162, 52);
            this.ctlTanksCount.Name = "ctlTanksCount";
            this.ctlTanksCount.Size = new System.Drawing.Size(120, 26);
            this.ctlTanksCount.TabIndex = 3;
            this.ctlTanksCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(207, 84);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmNewGame
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 121);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ctlTanksCount);
            this.Controls.Add(this.ctlAppleCount);
            this.Controls.Add(this.lblTanksCount);
            this.Controls.Add(this.lblAppleCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 160);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 160);
            this.Name = "frmNewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmNewGame";
            ((System.ComponentModel.ISupportInitialize)(this.ctlAppleCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlTanksCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppleCount;
        private System.Windows.Forms.Label lblTanksCount;
        private System.Windows.Forms.NumericUpDown ctlAppleCount;
        private System.Windows.Forms.NumericUpDown ctlTanksCount;
        private System.Windows.Forms.Button btnOK;
    }
}