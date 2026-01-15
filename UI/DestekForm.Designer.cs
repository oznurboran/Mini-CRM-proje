namespace CRMProjeyeni.UI
{
    partial class DestekForm
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
            this.talepdgv = new System.Windows.Forms.DataGridView();
            this.statuPanel = new System.Windows.Forms.Panel();
            this.memnuniyetLabel = new System.Windows.Forms.Label();
            this.memnuniyetkaydetButton = new System.Windows.Forms.Button();
            this.memnuniyetCmbbox = new System.Windows.Forms.ComboBox();
            this.durumCmbbox = new System.Windows.Forms.ComboBox();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.durumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.talepdgv)).BeginInit();
            this.statuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // talepdgv
            // 
            this.talepdgv.AllowUserToAddRows = false;
            this.talepdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.talepdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.talepdgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.talepdgv.Location = new System.Drawing.Point(0, 0);
            this.talepdgv.Name = "talepdgv";
            this.talepdgv.ReadOnly = true;
            this.talepdgv.RowHeadersWidth = 51;
            this.talepdgv.RowTemplate.Height = 24;
            this.talepdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.talepdgv.Size = new System.Drawing.Size(800, 450);
            this.talepdgv.TabIndex = 4;
            this.talepdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.talepdgv_CellContentClick);
            // 
            // statuPanel
            // 
            this.statuPanel.BackColor = System.Drawing.Color.Wheat;
            this.statuPanel.Controls.Add(this.memnuniyetLabel);
            this.statuPanel.Controls.Add(this.memnuniyetkaydetButton);
            this.statuPanel.Controls.Add(this.memnuniyetCmbbox);
            this.statuPanel.Controls.Add(this.durumCmbbox);
            this.statuPanel.Controls.Add(this.guncelleButton);
            this.statuPanel.Controls.Add(this.durumLabel);
            this.statuPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statuPanel.Location = new System.Drawing.Point(0, 254);
            this.statuPanel.Name = "statuPanel";
            this.statuPanel.Size = new System.Drawing.Size(800, 196);
            this.statuPanel.TabIndex = 5;
            // 
            // memnuniyetLabel
            // 
            this.memnuniyetLabel.AutoSize = true;
            this.memnuniyetLabel.Location = new System.Drawing.Point(207, 109);
            this.memnuniyetLabel.Name = "memnuniyetLabel";
            this.memnuniyetLabel.Size = new System.Drawing.Size(116, 16);
            this.memnuniyetLabel.TabIndex = 7;
            this.memnuniyetLabel.Text = "Memnuniyet Puanı";
            // 
            // memnuniyetkaydetButton
            // 
            this.memnuniyetkaydetButton.Location = new System.Drawing.Point(456, 102);
            this.memnuniyetkaydetButton.Name = "memnuniyetkaydetButton";
            this.memnuniyetkaydetButton.Size = new System.Drawing.Size(75, 23);
            this.memnuniyetkaydetButton.TabIndex = 6;
            this.memnuniyetkaydetButton.Text = "Kaydet";
            this.memnuniyetkaydetButton.UseVisualStyleBackColor = true;
            this.memnuniyetkaydetButton.Click += new System.EventHandler(this.memnuniyetkaydetButton_Click);
            // 
            // memnuniyetCmbbox
            // 
            this.memnuniyetCmbbox.FormattingEnabled = true;
            this.memnuniyetCmbbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.memnuniyetCmbbox.Location = new System.Drawing.Point(329, 101);
            this.memnuniyetCmbbox.Name = "memnuniyetCmbbox";
            this.memnuniyetCmbbox.Size = new System.Drawing.Size(121, 24);
            this.memnuniyetCmbbox.TabIndex = 5;
            // 
            // durumCmbbox
            // 
            this.durumCmbbox.FormattingEnabled = true;
            this.durumCmbbox.Items.AddRange(new object[] {
            "Açık",
            "Beklemede",
            "Tamamlandı"});
            this.durumCmbbox.Location = new System.Drawing.Point(329, 57);
            this.durumCmbbox.Name = "durumCmbbox";
            this.durumCmbbox.Size = new System.Drawing.Size(121, 24);
            this.durumCmbbox.TabIndex = 4;
            // 
            // guncelleButton
            // 
            this.guncelleButton.Location = new System.Drawing.Point(456, 57);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(75, 23);
            this.guncelleButton.TabIndex = 3;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // durumLabel
            // 
            this.durumLabel.AutoSize = true;
            this.durumLabel.Location = new System.Drawing.Point(232, 65);
            this.durumLabel.Name = "durumLabel";
            this.durumLabel.Size = new System.Drawing.Size(46, 16);
            this.durumLabel.TabIndex = 0;
            this.durumLabel.Text = "Durum";
            // 
            // DestekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statuPanel);
            this.Controls.Add(this.talepdgv);
            this.Name = "DestekForm";
            this.Text = "DestekForm";
            this.Load += new System.EventHandler(this.DestekForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.talepdgv)).EndInit();
            this.statuPanel.ResumeLayout(false);
            this.statuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView talepdgv;
        private System.Windows.Forms.Panel statuPanel;
        private System.Windows.Forms.ComboBox durumCmbbox;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.Label durumLabel;
        private System.Windows.Forms.Button memnuniyetkaydetButton;
        private System.Windows.Forms.Label memnuniyetLabel;
        public System.Windows.Forms.ComboBox memnuniyetCmbbox;
    }
}