namespace HideAndSeek_HouseExplorer_v2
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
            this.txtBx_Description = new System.Windows.Forms.TextBox();
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.cmbBx_Exits = new System.Windows.Forms.ComboBox();
            this.btn_goHere = new System.Windows.Forms.Button();
            this.btn_GoThroughTheDoor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBx_Description
            // 
            this.txtBx_Description.Location = new System.Drawing.Point(12, 12);
            this.txtBx_Description.Multiline = true;
            this.txtBx_Description.Name = "txtBx_Description";
            this.txtBx_Description.Size = new System.Drawing.Size(351, 196);
            this.txtBx_Description.TabIndex = 4;
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(12, 281);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(351, 23);
            this.btn_Check.TabIndex = 8;
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.Btn_Check_Click);
            // 
            // btn_Hide
            // 
            this.btn_Hide.Location = new System.Drawing.Point(12, 310);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(351, 23);
            this.btn_Hide.TabIndex = 9;
            this.btn_Hide.Text = "Прячься!";
            this.btn_Hide.UseVisualStyleBackColor = true;
            this.btn_Hide.Click += new System.EventHandler(this.Btn_Hide_Click);
            // 
            // cmbBx_Exits
            // 
            this.cmbBx_Exits.FormattingEnabled = true;
            this.cmbBx_Exits.Location = new System.Drawing.Point(161, 220);
            this.cmbBx_Exits.Name = "cmbBx_Exits";
            this.cmbBx_Exits.Size = new System.Drawing.Size(202, 21);
            this.cmbBx_Exits.TabIndex = 10;
            // 
            // btn_goHere
            // 
            this.btn_goHere.Location = new System.Drawing.Point(12, 219);
            this.btn_goHere.Name = "btn_goHere";
            this.btn_goHere.Size = new System.Drawing.Size(143, 23);
            this.btn_goHere.TabIndex = 11;
            this.btn_goHere.Text = "Идти в: ";
            this.btn_goHere.UseVisualStyleBackColor = true;
            this.btn_goHere.Click += new System.EventHandler(this.btn_goHere_Click);
            // 
            // btn_GoThroughTheDoor
            // 
            this.btn_GoThroughTheDoor.Location = new System.Drawing.Point(12, 249);
            this.btn_GoThroughTheDoor.Name = "btn_GoThroughTheDoor";
            this.btn_GoThroughTheDoor.Size = new System.Drawing.Size(351, 23);
            this.btn_GoThroughTheDoor.TabIndex = 12;
            this.btn_GoThroughTheDoor.Text = "Выйти в дверь";
            this.btn_GoThroughTheDoor.UseVisualStyleBackColor = true;
            this.btn_GoThroughTheDoor.Click += new System.EventHandler(this.btn_GoThroughTheDoor_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 343);
            this.Controls.Add(this.btn_GoThroughTheDoor);
            this.Controls.Add(this.btn_goHere);
            this.Controls.Add(this.cmbBx_Exits);
            this.Controls.Add(this.btn_Hide);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.txtBx_Description);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main";
            this.Text = "Прятки в доме";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBx_Description;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_Hide;
        private System.Windows.Forms.ComboBox cmbBx_Exits;
        private System.Windows.Forms.Button btn_goHere;
        private System.Windows.Forms.Button btn_GoThroughTheDoor;
    }
}

