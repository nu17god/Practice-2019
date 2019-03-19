namespace Tanks
{
    partial class frmReport
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
            this.ctlData = new System.Windows.Forms.DataGridView();
            this.dataFirstCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSecondCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataThirdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFourthCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ctlData)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlData
            // 
            this.ctlData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataFirstCol,
            this.dataSecondCol,
            this.dataThirdCol,
            this.dataFourthCol});
            this.ctlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlData.Location = new System.Drawing.Point(0, 0);
            this.ctlData.Name = "ctlData";
            this.ctlData.ReadOnly = true;
            this.ctlData.Size = new System.Drawing.Size(463, 413);
            this.ctlData.TabIndex = 0;
            // 
            // dataFirstCol
            // 
            this.dataFirstCol.HeaderText = "Player";
            this.dataFirstCol.Name = "dataFirstCol";
            this.dataFirstCol.ReadOnly = true;
            // 
            // dataSecondCol
            // 
            this.dataSecondCol.HeaderText = "Enemies";
            this.dataSecondCol.Name = "dataSecondCol";
            this.dataSecondCol.ReadOnly = true;
            // 
            // dataThirdCol
            // 
            this.dataThirdCol.HeaderText = "Apples";
            this.dataThirdCol.Name = "dataThirdCol";
            this.dataThirdCol.ReadOnly = true;
            // 
            // dataFourthCol
            // 
            this.dataFourthCol.HeaderText = "Walls";
            this.dataFourthCol.Name = "dataFourthCol";
            this.dataFourthCol.ReadOnly = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 413);
            this.Controls.Add(this.ctlData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.ctlData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ctlData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFirstCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSecondCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataThirdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFourthCol;
    }
}