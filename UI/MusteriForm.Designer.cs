namespace CRMProjeyeni.UI
{
    partial class MusteriForm
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
            this.detayPanel = new System.Windows.Forms.Panel();
            this.musteriDgv = new System.Windows.Forms.DataGridView();
            this.silButton = new System.Windows.Forms.Button();
            this.yenimusteriolusturButton = new System.Windows.Forms.Button();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.telefonTxtbox = new System.Windows.Forms.TextBox();
            this.epostaTxtbox = new System.Windows.Forms.TextBox();
            this.adTxtbox = new System.Windows.Forms.TextBox();
            this.epostaLabel = new System.Windows.Forms.Label();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.adLabel = new System.Windows.Forms.Label();
            this.detayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // detayPanel
            // 
            this.detayPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.detayPanel.Controls.Add(this.musteriDgv);
            this.detayPanel.Controls.Add(this.silButton);
            this.detayPanel.Controls.Add(this.yenimusteriolusturButton);
            this.detayPanel.Controls.Add(this.guncelleButton);
            this.detayPanel.Controls.Add(this.telefonTxtbox);
            this.detayPanel.Controls.Add(this.epostaTxtbox);
            this.detayPanel.Controls.Add(this.adTxtbox);
            this.detayPanel.Controls.Add(this.epostaLabel);
            this.detayPanel.Controls.Add(this.telefonLabel);
            this.detayPanel.Controls.Add(this.adLabel);
            this.detayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detayPanel.Location = new System.Drawing.Point(0, 0);
            this.detayPanel.Name = "detayPanel";
            this.detayPanel.Size = new System.Drawing.Size(800, 450);
            this.detayPanel.TabIndex = 15;
            // 
            // musteriDgv
            // 
            this.musteriDgv.AllowUserToAddRows = false;
            this.musteriDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.musteriDgv.BackgroundColor = System.Drawing.Color.White;
            this.musteriDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriDgv.Location = new System.Drawing.Point(464, 3);
            this.musteriDgv.Name = "musteriDgv";
            this.musteriDgv.RowHeadersWidth = 51;
            this.musteriDgv.RowTemplate.Height = 24;
            this.musteriDgv.Size = new System.Drawing.Size(290, 450);
            this.musteriDgv.TabIndex = 13;
            this.musteriDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musteriDgv_CellContentClick);
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(323, 274);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(41, 35);
            this.silButton.TabIndex = 12;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // yenimusteriolusturButton
            // 
            this.yenimusteriolusturButton.Location = new System.Drawing.Point(370, 264);
            this.yenimusteriolusturButton.Name = "yenimusteriolusturButton";
            this.yenimusteriolusturButton.Size = new System.Drawing.Size(88, 55);
            this.yenimusteriolusturButton.TabIndex = 11;
            this.yenimusteriolusturButton.Text = "Yeni müşteri oluştur";
            this.yenimusteriolusturButton.UseVisualStyleBackColor = true;
            this.yenimusteriolusturButton.Click += new System.EventHandler(this.yenimusteriolusturButton_Click);
            // 
            // guncelleButton
            // 
            this.guncelleButton.Location = new System.Drawing.Point(245, 272);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(72, 47);
            this.guncelleButton.TabIndex = 10;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // telefonTxtbox
            // 
            this.telefonTxtbox.Location = new System.Drawing.Point(323, 151);
            this.telefonTxtbox.Name = "telefonTxtbox";
            this.telefonTxtbox.Size = new System.Drawing.Size(100, 22);
            this.telefonTxtbox.TabIndex = 8;
            // 
            // epostaTxtbox
            // 
            this.epostaTxtbox.Location = new System.Drawing.Point(323, 195);
            this.epostaTxtbox.Name = "epostaTxtbox";
            this.epostaTxtbox.Size = new System.Drawing.Size(100, 22);
            this.epostaTxtbox.TabIndex = 7;
            // 
            // adTxtbox
            // 
            this.adTxtbox.Location = new System.Drawing.Point(323, 101);
            this.adTxtbox.Name = "adTxtbox";
            this.adTxtbox.Size = new System.Drawing.Size(100, 22);
            this.adTxtbox.TabIndex = 5;
            // 
            // epostaLabel
            // 
            this.epostaLabel.AutoSize = true;
            this.epostaLabel.Location = new System.Drawing.Point(248, 154);
            this.epostaLabel.Name = "epostaLabel";
            this.epostaLabel.Size = new System.Drawing.Size(50, 16);
            this.epostaLabel.TabIndex = 3;
            this.epostaLabel.Text = "Eposta";
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.Location = new System.Drawing.Point(248, 201);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(53, 16);
            this.telefonLabel.TabIndex = 2;
            this.telefonLabel.Text = "Telefon";
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Location = new System.Drawing.Point(242, 107);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(67, 16);
            this.adLabel.TabIndex = 0;
            this.adLabel.Text = "Ad Soyad";
            // 
            // MusteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.detayPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusteriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MusteriForm";
            this.Load += new System.EventHandler(this.MusteriForm_Load);
            this.detayPanel.ResumeLayout(false);
            this.detayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel detayPanel;
        private System.Windows.Forms.DataGridView musteriDgv;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button yenimusteriolusturButton;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.TextBox telefonTxtbox;
        private System.Windows.Forms.TextBox epostaTxtbox;
        private System.Windows.Forms.TextBox adTxtbox;
        private System.Windows.Forms.Label epostaLabel;
        private System.Windows.Forms.Label telefonLabel;
        private System.Windows.Forms.Label adLabel;
    }
}