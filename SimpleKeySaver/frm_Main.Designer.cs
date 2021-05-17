namespace SimpleKeySaver
{
    partial class frm_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.txtBx_Data = new System.Windows.Forms.TextBox();
            this.btn_AddResource = new System.Windows.Forms.Button();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.lstBx_Resources = new System.Windows.Forms.ListBox();
            this.lbl_Resources = new System.Windows.Forms.Label();
            this.chkBx_AddResource = new System.Windows.Forms.CheckBox();
            this.lbl_ResourceName = new System.Windows.Forms.Label();
            this.lbl_Link = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txtBx_ResourceName = new System.Windows.Forms.TextBox();
            this.txtBx_Link = new System.Windows.Forms.TextBox();
            this.txtBx_Username = new System.Windows.Forms.TextBox();
            this.txtBx_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(346, 11);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(99, 23);
            this.btn_Encrypt.TabIndex = 0;
            this.btn_Encrypt.Text = "Зашифровать";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(346, 40);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(99, 23);
            this.btn_Decrypt.TabIndex = 1;
            this.btn_Decrypt.Text = "Расшифровать";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // txtBx_Data
            // 
            this.txtBx_Data.Location = new System.Drawing.Point(12, 115);
            this.txtBx_Data.Multiline = true;
            this.txtBx_Data.Name = "txtBx_Data";
            this.txtBx_Data.Size = new System.Drawing.Size(132, 95);
            this.txtBx_Data.TabIndex = 2;
            // 
            // btn_AddResource
            // 
            this.btn_AddResource.Location = new System.Drawing.Point(190, 181);
            this.btn_AddResource.Name = "btn_AddResource";
            this.btn_AddResource.Size = new System.Drawing.Size(112, 38);
            this.btn_AddResource.TabIndex = 3;
            this.btn_AddResource.Text = " Добавить ресурс";
            this.btn_AddResource.UseVisualStyleBackColor = true;
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Location = new System.Drawing.Point(12, 97);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(48, 13);
            this.lbl_Data.TabIndex = 4;
            this.lbl_Data.Text = "Данные";
            // 
            // lstBx_Resources
            // 
            this.lstBx_Resources.FormattingEnabled = true;
            this.lstBx_Resources.Location = new System.Drawing.Point(12, 25);
            this.lstBx_Resources.Name = "lstBx_Resources";
            this.lstBx_Resources.Size = new System.Drawing.Size(87, 69);
            this.lstBx_Resources.TabIndex = 5;
            // 
            // lbl_Resources
            // 
            this.lbl_Resources.AutoSize = true;
            this.lbl_Resources.Location = new System.Drawing.Point(9, 6);
            this.lbl_Resources.Name = "lbl_Resources";
            this.lbl_Resources.Size = new System.Drawing.Size(51, 13);
            this.lbl_Resources.TabIndex = 6;
            this.lbl_Resources.Text = "Ресурсы";
            // 
            // chkBx_AddResource
            // 
            this.chkBx_AddResource.AutoSize = true;
            this.chkBx_AddResource.Location = new System.Drawing.Point(346, 93);
            this.chkBx_AddResource.Name = "chkBx_AddResource";
            this.chkBx_AddResource.Size = new System.Drawing.Size(120, 17);
            this.chkBx_AddResource.TabIndex = 7;
            this.chkBx_AddResource.Text = "Добавить ресурс?";
            this.chkBx_AddResource.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkBx_AddResource.UseVisualStyleBackColor = true;
            // 
            // lbl_ResourceName
            // 
            this.lbl_ResourceName.AutoSize = true;
            this.lbl_ResourceName.Location = new System.Drawing.Point(189, 11);
            this.lbl_ResourceName.Name = "lbl_ResourceName";
            this.lbl_ResourceName.Size = new System.Drawing.Size(144, 13);
            this.lbl_ResourceName.TabIndex = 8;
            this.lbl_ResourceName.Text = "Краткое описание ресурса";
            // 
            // lbl_Link
            // 
            this.lbl_Link.AutoSize = true;
            this.lbl_Link.Location = new System.Drawing.Point(191, 56);
            this.lbl_Link.Name = "lbl_Link";
            this.lbl_Link.Size = new System.Drawing.Size(111, 13);
            this.lbl_Link.TabIndex = 9;
            this.lbl_Link.Text = "Ссылка ( если сайт )";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(191, 98);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(38, 13);
            this.lbl_Username.TabIndex = 10;
            this.lbl_Username.Text = "Логин";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(192, 140);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(45, 13);
            this.lbl_Password.TabIndex = 11;
            this.lbl_Password.Text = "Пароль";
            // 
            // txtBx_ResourceName
            // 
            this.txtBx_ResourceName.Location = new System.Drawing.Point(190, 29);
            this.txtBx_ResourceName.Name = "txtBx_ResourceName";
            this.txtBx_ResourceName.Size = new System.Drawing.Size(112, 20);
            this.txtBx_ResourceName.TabIndex = 12;
            // 
            // txtBx_Link
            // 
            this.txtBx_Link.Location = new System.Drawing.Point(190, 74);
            this.txtBx_Link.Name = "txtBx_Link";
            this.txtBx_Link.Size = new System.Drawing.Size(112, 20);
            this.txtBx_Link.TabIndex = 13;
            // 
            // txtBx_Username
            // 
            this.txtBx_Username.Location = new System.Drawing.Point(190, 115);
            this.txtBx_Username.Name = "txtBx_Username";
            this.txtBx_Username.Size = new System.Drawing.Size(112, 20);
            this.txtBx_Username.TabIndex = 14;
            // 
            // txtBx_Password
            // 
            this.txtBx_Password.Location = new System.Drawing.Point(192, 155);
            this.txtBx_Password.Name = "txtBx_Password";
            this.txtBx_Password.PasswordChar = '*';
            this.txtBx_Password.Size = new System.Drawing.Size(110, 20);
            this.txtBx_Password.TabIndex = 15;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimpleKeySaver.Properties.Resources.KeyPic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(478, 222);
            this.Controls.Add(this.txtBx_Password);
            this.Controls.Add(this.txtBx_Username);
            this.Controls.Add(this.txtBx_Link);
            this.Controls.Add(this.txtBx_ResourceName);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Link);
            this.Controls.Add(this.lbl_ResourceName);
            this.Controls.Add(this.chkBx_AddResource);
            this.Controls.Add(this.lbl_Resources);
            this.Controls.Add(this.lstBx_Resources);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.btn_AddResource);
            this.Controls.Add(this.txtBx_Data);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main";
            this.Text = "Simple Key Saver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.TextBox txtBx_Data;
        private System.Windows.Forms.Button btn_AddResource;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.ListBox lstBx_Resources;
        private System.Windows.Forms.Label lbl_Resources;
        private System.Windows.Forms.CheckBox chkBx_AddResource;
        private System.Windows.Forms.Label lbl_ResourceName;
        private System.Windows.Forms.Label lbl_Link;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txtBx_ResourceName;
        private System.Windows.Forms.TextBox txtBx_Link;
        private System.Windows.Forms.TextBox txtBx_Username;
        private System.Windows.Forms.TextBox txtBx_Password;
    }
}

