namespace CRMProjeyeni.UI
{
    partial class HizmetForm
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
            this.hizmetformdgv = new System.Windows.Forms.DataGridView();
            this.hizmetyonetimLabel = new System.Windows.Forms.Label();
            this.silButton = new System.Windows.Forms.Button();
            this.kaydetButton = new System.Windows.Forms.Button();
            this.hizmetadiTxtbox = new System.Windows.Forms.TextBox();
            this.aciklamaTxtbox = new System.Windows.Forms.TextBox();
            this.ucretTxtbox = new System.Windows.Forms.TextBox();
            this.ucretLabel = new System.Windows.Forms.Label();
            this.aciklamaLabel = new System.Windows.Forms.Label();
            this.hizmetadiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hizmetformdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // hizmetformdgv
            // 
            this.hizmetformdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hizmetformdgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hizmetformdgv.Location = new System.Drawing.Point(0, 206);
            this.hizmetformdgv.Name = "hizmetformdgv";
            this.hizmetformdgv.ReadOnly = true;
            this.hizmetformdgv.RowHeadersWidth = 51;
            this.hizmetformdgv.RowTemplate.Height = 24;
            this.hizmetformdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hizmetformdgv.Size = new System.Drawing.Size(800, 244);
            this.hizmetformdgv.TabIndex = 9;
            this.hizmetformdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hizmetformdgv_CellContentClick);
            // 
            // hizmetyonetimLabel
            // 
            this.hizmetyonetimLabel.AutoSize = true;
            this.hizmetyonetimLabel.Location = new System.Drawing.Point(285, 17);
            this.hizmetyonetimLabel.Name = "hizmetyonetimLabel";
            this.hizmetyonetimLabel.Size = new System.Drawing.Size(124, 16);
            this.hizmetyonetimLabel.TabIndex = 18;
            this.hizmetyonetimLabel.Text = "HİZMET YÖNETİMİ";
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(713, 109);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(75, 23);
            this.silButton.TabIndex = 17;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // kaydetButton
            // 
            this.kaydetButton.Location = new System.Drawing.Point(617, 109);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(75, 23);
            this.kaydetButton.TabIndex = 16;
            this.kaydetButton.Text = "Kaydet";
            this.kaydetButton.UseVisualStyleBackColor = true;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // hizmetadiTxtbox
            // 
            this.hizmetadiTxtbox.Location = new System.Drawing.Point(471, 49);
            this.hizmetadiTxtbox.Name = "hizmetadiTxtbox";
            this.hizmetadiTxtbox.Size = new System.Drawing.Size(100, 22);
            this.hizmetadiTxtbox.TabIndex = 15;
            // 
            // aciklamaTxtbox
            // 
            this.aciklamaTxtbox.Location = new System.Drawing.Point(471, 82);
            this.aciklamaTxtbox.Multiline = true;
            this.aciklamaTxtbox.Name = "aciklamaTxtbox";
            this.aciklamaTxtbox.Size = new System.Drawing.Size(100, 60);
            this.aciklamaTxtbox.TabIndex = 14;
            // 
            // ucretTxtbox
            // 
            this.ucretTxtbox.Location = new System.Drawing.Point(471, 161);
            this.ucretTxtbox.Name = "ucretTxtbox";
            this.ucretTxtbox.Size = new System.Drawing.Size(100, 22);
            this.ucretTxtbox.TabIndex = 13;
            // 
            // ucretLabel
            // 
            this.ucretLabel.AutoSize = true;
            this.ucretLabel.Location = new System.Drawing.Point(396, 167);
            this.ucretLabel.Name = "ucretLabel";
            this.ucretLabel.Size = new System.Drawing.Size(39, 16);
            this.ucretLabel.TabIndex = 12;
            this.ucretLabel.Text = "Ücret";
            // 
            // aciklamaLabel
            // 
            this.aciklamaLabel.AutoSize = true;
            this.aciklamaLabel.Location = new System.Drawing.Point(372, 89);
            this.aciklamaLabel.Name = "aciklamaLabel";
            this.aciklamaLabel.Size = new System.Drawing.Size(63, 16);
            this.aciklamaLabel.TabIndex = 11;
            this.aciklamaLabel.Text = "Açıklama";
            // 
            // hizmetadiLabel
            // 
            this.hizmetadiLabel.AutoSize = true;
            this.hizmetadiLabel.Location = new System.Drawing.Point(369, 55);
            this.hizmetadiLabel.Name = "hizmetadiLabel";
            this.hizmetadiLabel.Size = new System.Drawing.Size(71, 16);
            this.hizmetadiLabel.TabIndex = 10;
            this.hizmetadiLabel.Text = "Hizmet Adı";
            // 
            // HizmetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hizmetyonetimLabel);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.kaydetButton);
            this.Controls.Add(this.hizmetadiTxtbox);
            this.Controls.Add(this.aciklamaTxtbox);
            this.Controls.Add(this.ucretTxtbox);
            this.Controls.Add(this.ucretLabel);
            this.Controls.Add(this.aciklamaLabel);
            this.Controls.Add(this.hizmetadiLabel);
            this.Controls.Add(this.hizmetformdgv);
            this.Name = "HizmetForm";
            this.Text = "HizmetForm";
            this.Load += new System.EventHandler(this.HizmetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hizmetformdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView hizmetformdgv;
        private System.Windows.Forms.Label hizmetyonetimLabel;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.TextBox hizmetadiTxtbox;
        private System.Windows.Forms.TextBox aciklamaTxtbox;
        private System.Windows.Forms.TextBox ucretTxtbox;
        private System.Windows.Forms.Label ucretLabel;
        private System.Windows.Forms.Label aciklamaLabel;
        private System.Windows.Forms.Label hizmetadiLabel;
    }
}