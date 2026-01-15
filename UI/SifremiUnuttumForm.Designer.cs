namespace CRMProjeyeni.UI
{
    partial class SifremiUnuttumForm
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
            this.guncelleButton = new System.Windows.Forms.Button();
            this.kullaniciadiTxtbox = new System.Windows.Forms.TextBox();
            this.yenisifreTxtbox = new System.Windows.Forms.TextBox();
            this.kullaniciadiLabel = new System.Windows.Forms.Label();
            this.yenisifreLabel = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guncelleButton
            // 
            this.guncelleButton.Location = new System.Drawing.Point(247, 139);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(110, 23);
            this.guncelleButton.TabIndex = 0;
            this.guncelleButton.Text = "GÜNCELLE";
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // kullaniciadiTxtbox
            // 
            this.kullaniciadiTxtbox.Location = new System.Drawing.Point(109, 113);
            this.kullaniciadiTxtbox.Name = "kullaniciadiTxtbox";
            this.kullaniciadiTxtbox.Size = new System.Drawing.Size(100, 22);
            this.kullaniciadiTxtbox.TabIndex = 1;
            // 
            // yenisifreTxtbox
            // 
            this.yenisifreTxtbox.Location = new System.Drawing.Point(109, 164);
            this.yenisifreTxtbox.Name = "yenisifreTxtbox";
            this.yenisifreTxtbox.Size = new System.Drawing.Size(100, 22);
            this.yenisifreTxtbox.TabIndex = 2;
            // 
            // kullaniciadiLabel
            // 
            this.kullaniciadiLabel.AutoSize = true;
            this.kullaniciadiLabel.Location = new System.Drawing.Point(14, 113);
            this.kullaniciadiLabel.Name = "kullaniciadiLabel";
            this.kullaniciadiLabel.Size = new System.Drawing.Size(79, 16);
            this.kullaniciadiLabel.TabIndex = 3;
            this.kullaniciadiLabel.Text = "Kullanıcı Adı";
            // 
            // yenisifreLabel
            // 
            this.yenisifreLabel.AutoSize = true;
            this.yenisifreLabel.Location = new System.Drawing.Point(14, 167);
            this.yenisifreLabel.Name = "yenisifreLabel";
            this.yenisifreLabel.Size = new System.Drawing.Size(64, 16);
            this.yenisifreLabel.TabIndex = 4;
            this.yenisifreLabel.Text = "Yeni Şifre";
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Wheat;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.guncelleButton);
            this.panelLogin.Controls.Add(this.yenisifreLabel);
            this.panelLogin.Controls.Add(this.kullaniciadiTxtbox);
            this.panelLogin.Controls.Add(this.kullaniciadiLabel);
            this.panelLogin.Controls.Add(this.yenisifreTxtbox);
            this.panelLogin.Location = new System.Drawing.Point(203, 82);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(391, 277);
            this.panelLogin.TabIndex = 5;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::CRMProjeyeni.Properties.Resources.Poste_de_coiffure_grand_luxe1;
            this.pictureBox1.Location = new System.Drawing.Point(-75, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(879, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // SifremiUnuttumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SifremiUnuttumForm";
            this.Text = "SifremiUnuttumForm";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.TextBox kullaniciadiTxtbox;
        private System.Windows.Forms.TextBox yenisifreTxtbox;
        private System.Windows.Forms.Label kullaniciadiLabel;
        private System.Windows.Forms.Label yenisifreLabel;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}