namespace CRMProjeyeni.UI
{
    partial class PersonelForm
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
            this.personellerDgv = new System.Windows.Forms.DataGridView();
            this.uzmanlikLabel = new System.Windows.Forms.Label();
            this.soyadLabel = new System.Windows.Forms.Label();
            this.adLabel = new System.Windows.Forms.Label();
            this.silButton = new System.Windows.Forms.Button();
            this.kaydetButton = new System.Windows.Forms.Button();
            this.uzmanlikCmbbox = new System.Windows.Forms.ComboBox();
            this.soyadtxtBox = new System.Windows.Forms.TextBox();
            this.adtxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.personellerDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // personellerDgv
            // 
            this.personellerDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personellerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personellerDgv.Location = new System.Drawing.Point(459, 3);
            this.personellerDgv.MultiSelect = false;
            this.personellerDgv.Name = "personellerDgv";
            this.personellerDgv.ReadOnly = true;
            this.personellerDgv.RowHeadersWidth = 51;
            this.personellerDgv.RowTemplate.Height = 24;
            this.personellerDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personellerDgv.Size = new System.Drawing.Size(475, 578);
            this.personellerDgv.TabIndex = 8;
            this.personellerDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personellerDgv_CellContentClick);
            // 
            // uzmanlikLabel
            // 
            this.uzmanlikLabel.AutoSize = true;
            this.uzmanlikLabel.Location = new System.Drawing.Point(260, 184);
            this.uzmanlikLabel.Name = "uzmanlikLabel";
            this.uzmanlikLabel.Size = new System.Drawing.Size(62, 16);
            this.uzmanlikLabel.TabIndex = 20;
            this.uzmanlikLabel.Text = "Uzmanlık";
            // 
            // soyadLabel
            // 
            this.soyadLabel.AutoSize = true;
            this.soyadLabel.Location = new System.Drawing.Point(275, 154);
            this.soyadLabel.Name = "soyadLabel";
            this.soyadLabel.Size = new System.Drawing.Size(47, 16);
            this.soyadLabel.TabIndex = 19;
            this.soyadLabel.Text = "Soyad";
            // 
            // adLabel
            // 
            this.adLabel.AutoSize = true;
            this.adLabel.Location = new System.Drawing.Point(275, 126);
            this.adLabel.Name = "adLabel";
            this.adLabel.Size = new System.Drawing.Size(27, 16);
            this.adLabel.TabIndex = 18;
            this.adLabel.Text = "Ad ";
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(378, 248);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(75, 23);
            this.silButton.TabIndex = 17;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // kaydetButton
            // 
            this.kaydetButton.Location = new System.Drawing.Point(297, 248);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(75, 23);
            this.kaydetButton.TabIndex = 16;
            this.kaydetButton.Text = "Kaydet";
            this.kaydetButton.UseVisualStyleBackColor = true;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // uzmanlikCmbbox
            // 
            this.uzmanlikCmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uzmanlikCmbbox.FormattingEnabled = true;
            this.uzmanlikCmbbox.Items.AddRange(new object[] {
            "CİLT BAKIM UZMANI",
            "MAKYAJ UZMANI",
            "EL & AYAK BAKIM UZMANI",
            "MAKYAJ UZMANI"});
            this.uzmanlikCmbbox.Location = new System.Drawing.Point(332, 176);
            this.uzmanlikCmbbox.Name = "uzmanlikCmbbox";
            this.uzmanlikCmbbox.Size = new System.Drawing.Size(121, 24);
            this.uzmanlikCmbbox.TabIndex = 15;
            this.uzmanlikCmbbox.SelectedIndexChanged += new System.EventHandler(this.uzmanlikCmbbox_SelectedIndexChanged);
            // 
            // soyadtxtBox
            // 
            this.soyadtxtBox.Location = new System.Drawing.Point(344, 148);
            this.soyadtxtBox.Name = "soyadtxtBox";
            this.soyadtxtBox.Size = new System.Drawing.Size(100, 22);
            this.soyadtxtBox.TabIndex = 14;
            // 
            // adtxtBox
            // 
            this.adtxtBox.Location = new System.Drawing.Point(344, 120);
            this.adtxtBox.Name = "adtxtBox";
            this.adtxtBox.Size = new System.Drawing.Size(100, 22);
            this.adtxtBox.TabIndex = 13;
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 593);
            this.Controls.Add(this.uzmanlikLabel);
            this.Controls.Add(this.soyadLabel);
            this.Controls.Add(this.adLabel);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.kaydetButton);
            this.Controls.Add(this.uzmanlikCmbbox);
            this.Controls.Add(this.soyadtxtBox);
            this.Controls.Add(this.adtxtBox);
            this.Controls.Add(this.personellerDgv);
            this.Name = "PersonelForm";
            this.Text = "PersonelForm";
            this.Load += new System.EventHandler(this.PersonelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personellerDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView personellerDgv;
        private System.Windows.Forms.Label uzmanlikLabel;
        private System.Windows.Forms.Label soyadLabel;
        private System.Windows.Forms.Label adLabel;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.ComboBox uzmanlikCmbbox;
        private System.Windows.Forms.TextBox soyadtxtBox;
        private System.Windows.Forms.TextBox adtxtBox;
    }
}