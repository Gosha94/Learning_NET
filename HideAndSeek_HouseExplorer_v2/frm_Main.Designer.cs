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
            this.btn_GoThroughTheDoor = new System.Windows.Forms.Button();
            this.btn_goHere = new System.Windows.Forms.Button();
            this.cmbBx_Exits = new System.Windows.Forms.ComboBox();
            this.txtBx_Description = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GoThroughTheDoor
            // 
            this.btn_GoThroughTheDoor.Location = new System.Drawing.Point(12, 252);
            this.btn_GoThroughTheDoor.Name = "btn_GoThroughTheDoor";
            this.btn_GoThroughTheDoor.Size = new System.Drawing.Size(351, 23);
            this.btn_GoThroughTheDoor.TabIndex = 7;
            this.btn_GoThroughTheDoor.Text = "Выйти в дверь";
            this.btn_GoThroughTheDoor.UseVisualStyleBackColor = true;
            // 
            // btn_goHere
            // 
            this.btn_goHere.Location = new System.Drawing.Point(12, 219);
            this.btn_goHere.Name = "btn_goHere";
            this.btn_goHere.Size = new System.Drawing.Size(131, 23);
            this.btn_goHere.TabIndex = 6;
            this.btn_goHere.Text = "Идти в : ";
            this.btn_goHere.UseVisualStyleBackColor = true;
            // 
            // cmbBx_Exits
            // 
            this.cmbBx_Exits.FormattingEnabled = true;
            this.cmbBx_Exits.Location = new System.Drawing.Point(149, 220);
            this.cmbBx_Exits.Name = "cmbBx_Exits";
            this.cmbBx_Exits.Size = new System.Drawing.Size(214, 21);
            this.cmbBx_Exits.TabIndex = 5;
            // 
            // txtBx_Description
            // 
            this.txtBx_Description.Location = new System.Drawing.Point(12, 12);
            this.txtBx_Description.Multiline = true;
            this.txtBx_Description.Name = "txtBx_Description";
            this.txtBx_Description.Size = new System.Drawing.Size(351, 196);
            this.txtBx_Description.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Смотрим";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(351, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Прячься!";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 343);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_GoThroughTheDoor);
            this.Controls.Add(this.btn_goHere);
            this.Controls.Add(this.cmbBx_Exits);
            this.Controls.Add(this.txtBx_Description);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GoThroughTheDoor;
        private System.Windows.Forms.Button btn_goHere;
        private System.Windows.Forms.ComboBox cmbBx_Exits;
        private System.Windows.Forms.TextBox txtBx_Description;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

