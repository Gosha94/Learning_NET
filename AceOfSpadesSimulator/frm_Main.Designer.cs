namespace AceOfSpadesSimulator
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
            this.btn_PullCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_PullCard
            // 
            this.btn_PullCard.Location = new System.Drawing.Point(103, 63);
            this.btn_PullCard.Name = "btn_PullCard";
            this.btn_PullCard.Size = new System.Drawing.Size(174, 67);
            this.btn_PullCard.TabIndex = 0;
            this.btn_PullCard.Text = "Выбрать случайную карту";
            this.btn_PullCard.UseVisualStyleBackColor = true;
            this.btn_PullCard.Click += new System.EventHandler(this.btn_PullCard_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 197);
            this.Controls.Add(this.btn_PullCard);
            this.Name = "frm_Main";
            this.Text = "Выбор случайной карты";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_PullCard;
    }
}

