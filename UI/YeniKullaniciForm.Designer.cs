namespace CRMProjeyeni.UI
{
    partial class YeniKullaniciForm
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.kaydetButton = new System.Windows.Forms.Button();
            this.rolLabel = new System.Windows.Forms.Label();
            this.sifreLable = new System.Windows.Forms.Label();
            this.kullaniciadiLabel = new System.Windows.Forms.Label();
            this.rolCmbbox = new System.Windows.Forms.ComboBox();
            this.sifreTxtbox = new System.Windows.Forms.TextBox();
            this.kullaniciadiTxtbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Wheat;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.kaydetButton);
            this.panelLogin.Controls.Add(this.rolLabel);
            this.panelLogin.Controls.Add(this.sifreLable);
            this.panelLogin.Controls.Add(this.kullaniciadiLabel);
            this.panelLogin.Controls.Add(this.rolCmbbox);
            this.panelLogin.Controls.Add(this.sifreTxtbox);
            this.panelLogin.Controls.Add(this.kullaniciadiTxtbox);
            this.panelLogin.Location = new System.Drawing.Point(194, 72);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(391, 277);
            this.panelLogin.TabIndex = 7;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // kaydetButton
            // 
            this.kaydetButton.Location = new System.Drawing.Point(280, 126);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(75, 23);
            this.kaydetButton.TabIndex = 13;
            this.kaydetButton.Text = "KAYDET";
            this.kaydetButton.UseVisualStyleBackColor = true;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click_1);
            // 
            // rolLabel
            // 
            this.rolLabel.AutoSize = true;
            this.rolLabel.Location = new System.Drawing.Point(26, 188);
            this.rolLabel.Name = "rolLabel";
            this.rolLabel.Size = new System.Drawing.Size(28, 16);
            this.rolLabel.TabIndex = 12;
            this.rolLabel.Text = "Rol";
            // 
            // sifreLable
            // 
            this.sifreLable.AutoSize = true;
            this.sifreLable.Location = new System.Drawing.Point(20, 129);
            this.sifreLable.Name = "sifreLable";
            this.sifreLable.Size = new System.Drawing.Size(34, 16);
            this.sifreLable.TabIndex = 11;
            this.sifreLable.Text = "Şifre";
            // 
            // kullaniciadiLabel
            // 
            this.kullaniciadiLabel.AutoSize = true;
            this.kullaniciadiLabel.Location = new System.Drawing.Point(20, 86);
            this.kullaniciadiLabel.Name = "kullaniciadiLabel";
            this.kullaniciadiLabel.Size = new System.Drawing.Size(67, 16);
            this.kullaniciadiLabel.TabIndex = 10;
            this.kullaniciadiLabel.Text = "Ad Soyad";
            // 
            // rolCmbbox
            // 
            this.rolCmbbox.FormattingEnabled = true;
            this.rolCmbbox.Items.AddRange(new object[] {
            "Admin",
            "Cagri",
            "Destek"});
            this.rolCmbbox.Location = new System.Drawing.Point(93, 180);
            this.rolCmbbox.Name = "rolCmbbox";
            this.rolCmbbox.Size = new System.Drawing.Size(121, 24);
            this.rolCmbbox.TabIndex = 9;
            this.rolCmbbox.SelectedIndexChanged += new System.EventHandler(this.rolCmbbox_SelectedIndexChanged);
            // 
            // sifreTxtbox
            // 
            this.sifreTxtbox.Location = new System.Drawing.Point(93, 126);
            this.sifreTxtbox.Name = "sifreTxtbox";
            this.sifreTxtbox.Size = new System.Drawing.Size(100, 22);
            this.sifreTxtbox.TabIndex = 8;
            // 
            // kullaniciadiTxtbox
            // 
            this.kullaniciadiTxtbox.Location = new System.Drawing.Point(93, 80);
            this.kullaniciadiTxtbox.Name = "kullaniciadiTxtbox";
            this.kullaniciadiTxtbox.Size = new System.Drawing.Size(100, 22);
            this.kullaniciadiTxtbox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::CRMProjeyeni.Properties.Resources.Poste_de_coiffure_grand_luxe1;
            this.pictureBox1.Location = new System.Drawing.Point(-39, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(879, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // YeniKullaniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "YeniKullaniciForm";
            this.Text = "YeniKullaniciForm";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.Label rolLabel;
        private System.Windows.Forms.Label sifreLable;
        private System.Windows.Forms.Label kullaniciadiLabel;
        private System.Windows.Forms.ComboBox rolCmbbox;
        private System.Windows.Forms.TextBox sifreTxtbox;
        private System.Windows.Forms.TextBox kullaniciadiTxtbox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}