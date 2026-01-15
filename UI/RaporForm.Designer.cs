namespace CRMProjeyeni.UI
{
    partial class RaporForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.raporDgv = new System.Windows.Forms.DataGridView();
            this.ustPanel = new System.Windows.Forms.Panel();
            this.raporLabel = new System.Windows.Forms.Label();
            this.raporCmbbox = new System.Windows.Forms.ComboBox();
            this.raporgetirButton = new System.Windows.Forms.Button();
            this.ozetLabel = new System.Windows.Forms.Label();
            this.raporChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.raporDgv)).BeginInit();
            this.ustPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raporChart)).BeginInit();
            this.SuspendLayout();
            // 
            // raporDgv
            // 
            this.raporDgv.AllowUserToAddRows = false;
            this.raporDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.raporDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raporDgv.Location = new System.Drawing.Point(200, 56);
            this.raporDgv.Name = "raporDgv";
            this.raporDgv.ReadOnly = true;
            this.raporDgv.RowHeadersWidth = 51;
            this.raporDgv.RowTemplate.Height = 24;
            this.raporDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.raporDgv.Size = new System.Drawing.Size(724, 489);
            this.raporDgv.TabIndex = 5;
            this.raporDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.raporDgv_CellContentClick);
            // 
            // ustPanel
            // 
            this.ustPanel.BackColor = System.Drawing.Color.Wheat;
            this.ustPanel.Controls.Add(this.raporLabel);
            this.ustPanel.Controls.Add(this.raporCmbbox);
            this.ustPanel.Controls.Add(this.raporgetirButton);
            this.ustPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ustPanel.Location = new System.Drawing.Point(0, 0);
            this.ustPanel.Name = "ustPanel";
            this.ustPanel.Size = new System.Drawing.Size(871, 60);
            this.ustPanel.TabIndex = 6;
            // 
            // raporLabel
            // 
            this.raporLabel.AutoSize = true;
            this.raporLabel.Location = new System.Drawing.Point(255, 29);
            this.raporLabel.Name = "raporLabel";
            this.raporLabel.Size = new System.Drawing.Size(75, 16);
            this.raporLabel.TabIndex = 2;
            this.raporLabel.Text = "Rapor türü: ";
            // 
            // raporCmbbox
            // 
            this.raporCmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.raporCmbbox.FormattingEnabled = true;
            this.raporCmbbox.Items.AddRange(new object[] {
            "Talep Türüne Göre Hizmet Yoğunluğu",
            "Ortalama Çözüm Süresi",
            "Personel Performans Raporu",
            "Müşteri Bazlı Talep Raporu",
            "Müşteri Memnuniyet Raporu"});
            this.raporCmbbox.Location = new System.Drawing.Point(392, 26);
            this.raporCmbbox.Name = "raporCmbbox";
            this.raporCmbbox.Size = new System.Drawing.Size(180, 24);
            this.raporCmbbox.TabIndex = 0;
            // 
            // raporgetirButton
            // 
            this.raporgetirButton.Location = new System.Drawing.Point(647, 7);
            this.raporgetirButton.Name = "raporgetirButton";
            this.raporgetirButton.Size = new System.Drawing.Size(75, 50);
            this.raporgetirButton.TabIndex = 1;
            this.raporgetirButton.Text = "Rapor Getir";
            this.raporgetirButton.UseVisualStyleBackColor = true;
            this.raporgetirButton.Click += new System.EventHandler(this.raporgetirButton_Click);
            // 
            // ozetLabel
            // 
            this.ozetLabel.AutoSize = true;
            this.ozetLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ozetLabel.Location = new System.Drawing.Point(329, 194);
            this.ozetLabel.Name = "ozetLabel";
            this.ozetLabel.Size = new System.Drawing.Size(35, 16);
            this.ozetLabel.TabIndex = 5;
            this.ozetLabel.Text = "özet ";
            this.ozetLabel.Visible = false;
            // 
            // raporChart
            // 
            chartArea3.Name = "ChartArea1";
            this.raporChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.raporChart.Legends.Add(legend3);
            this.raporChart.Location = new System.Drawing.Point(298, 269);
            this.raporChart.Name = "raporChart";
            this.raporChart.Size = new System.Drawing.Size(561, 256);
            this.raporChart.TabIndex = 7;
            this.raporChart.Text = "chart1";
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 537);
            this.Controls.Add(this.raporChart);
            this.Controls.Add(this.ozetLabel);
            this.Controls.Add(this.ustPanel);
            this.Controls.Add(this.raporDgv);
            this.Name = "RaporForm";
            this.Text = "RaporForm";
            this.Load += new System.EventHandler(this.RaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raporDgv)).EndInit();
            this.ustPanel.ResumeLayout(false);
            this.ustPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raporChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView raporDgv;
        private System.Windows.Forms.Panel ustPanel;
        private System.Windows.Forms.Label raporLabel;
        private System.Windows.Forms.Label ozetLabel;
        private System.Windows.Forms.ComboBox raporCmbbox;
        private System.Windows.Forms.Button raporgetirButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart raporChart;
    }
}