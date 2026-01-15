namespace CRMProjeyeni.UI
{
    partial class TalepForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.taleplisteleDgv = new System.Windows.Forms.DataGridView();
            this.TalepId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HizmetAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TalepTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taleplisteleDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.Controls.Add(this.taleplisteleDgv);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1085, 668);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // taleplisteleDgv
            // 
            this.taleplisteleDgv.AllowUserToAddRows = false;
            this.taleplisteleDgv.BackgroundColor = System.Drawing.Color.White;
            this.taleplisteleDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taleplisteleDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TalepId,
            this.MusteriAdi,
            this.HizmetAdi,
            this.Aciklama,
            this.TalepTarihi,
            this.Durum});
            this.taleplisteleDgv.Location = new System.Drawing.Point(207, 48);
            this.taleplisteleDgv.MultiSelect = false;
            this.taleplisteleDgv.Name = "taleplisteleDgv";
            this.taleplisteleDgv.ReadOnly = true;
            this.taleplisteleDgv.RowHeadersVisible = false;
            this.taleplisteleDgv.RowHeadersWidth = 51;
            this.taleplisteleDgv.RowTemplate.Height = 24;
            this.taleplisteleDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taleplisteleDgv.Size = new System.Drawing.Size(750, 430);
            this.taleplisteleDgv.TabIndex = 2;
            this.taleplisteleDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taleplisteleDgv_CellContentClick);
            // 
            // TalepId
            // 
            this.TalepId.DataPropertyName = "TalepId";
            this.TalepId.HeaderText = "Talep No";
            this.TalepId.MinimumWidth = 6;
            this.TalepId.Name = "TalepId";
            this.TalepId.ReadOnly = true;
            this.TalepId.Width = 125;
            // 
            // MusteriAdi
            // 
            this.MusteriAdi.DataPropertyName = "MusteriAdi";
            this.MusteriAdi.HeaderText = "Müşteri";
            this.MusteriAdi.MinimumWidth = 6;
            this.MusteriAdi.Name = "MusteriAdi";
            this.MusteriAdi.ReadOnly = true;
            this.MusteriAdi.Width = 125;
            // 
            // HizmetAdi
            // 
            this.HizmetAdi.DataPropertyName = "HizmetAdi";
            this.HizmetAdi.HeaderText = "Hizmet";
            this.HizmetAdi.MinimumWidth = 6;
            this.HizmetAdi.Name = "HizmetAdi";
            this.HizmetAdi.ReadOnly = true;
            this.HizmetAdi.Width = 125;
            // 
            // Aciklama
            // 
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.MinimumWidth = 6;
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            this.Aciklama.Width = 125;
            // 
            // TalepTarihi
            // 
            this.TalepTarihi.DataPropertyName = "TalepTarihi";
            this.TalepTarihi.HeaderText = "Tarih";
            this.TalepTarihi.MinimumWidth = 6;
            this.TalepTarihi.Name = "TalepTarihi";
            this.TalepTarihi.ReadOnly = true;
            this.TalepTarihi.Width = 125;
            // 
            // Durum
            // 
            this.Durum.DataPropertyName = "Durum";
            this.Durum.HeaderText = "Durum";
            this.Durum.MinimumWidth = 6;
            this.Durum.Name = "Durum";
            this.Durum.ReadOnly = true;
            this.Durum.Width = 125;
            // 
            // TalepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 668);
            this.Controls.Add(this.mainPanel);
            this.Name = "TalepForm";
            this.Text = "TalepForm";
            this.Load += new System.EventHandler(this.TalepForm_Load);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taleplisteleDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView taleplisteleDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TalepId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HizmetAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn TalepTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
    }
}