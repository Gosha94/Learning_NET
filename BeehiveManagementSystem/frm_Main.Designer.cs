namespace BeehiveManagementSystem
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
            this.comBx_workerBeeJob = new System.Windows.Forms.ComboBox();
            this.numUpd_shifts = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_assignJob = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx_report = new System.Windows.Forms.TextBox();
            this.btn_nextShift = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpd_shifts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comBx_workerBeeJob
            // 
            this.comBx_workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBx_workerBeeJob.FormattingEnabled = true;
            this.comBx_workerBeeJob.Items.AddRange(new object[] {
            "Производство меда",
            "Обучение маленьких пчел",
            "Забота о яйцах",
            "Обслуживание улья",
            "Сбор нектара",
            "Патрулирование"});
            this.comBx_workerBeeJob.Location = new System.Drawing.Point(6, 50);
            this.comBx_workerBeeJob.Name = "comBx_workerBeeJob";
            this.comBx_workerBeeJob.Size = new System.Drawing.Size(163, 21);
            this.comBx_workerBeeJob.TabIndex = 0;
            // 
            // numUpd_shifts
            // 
            this.numUpd_shifts.Location = new System.Drawing.Point(175, 50);
            this.numUpd_shifts.Name = "numUpd_shifts";
            this.numUpd_shifts.Size = new System.Drawing.Size(83, 20);
            this.numUpd_shifts.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_assignJob);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comBx_workerBeeJob);
            this.groupBox1.Controls.Add(this.numUpd_shifts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задания пчелам";
            // 
            // btn_assignJob
            // 
            this.btn_assignJob.Location = new System.Drawing.Point(6, 77);
            this.btn_assignJob.Name = "btn_assignJob";
            this.btn_assignJob.Size = new System.Drawing.Size(252, 23);
            this.btn_assignJob.TabIndex = 4;
            this.btn_assignJob.Text = "Дать задание свободным пчелам";
            this.btn_assignJob.UseVisualStyleBackColor = true;
            this.btn_assignJob.Click += new System.EventHandler(this.btn_assignJob_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Работа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Число смен";
            // 
            // txtBx_report
            // 
            this.txtBx_report.Location = new System.Drawing.Point(12, 124);
            this.txtBx_report.Multiline = true;
            this.txtBx_report.Name = "txtBx_report";
            this.txtBx_report.Size = new System.Drawing.Size(402, 117);
            this.txtBx_report.TabIndex = 3;
            // 
            // btn_nextShift
            // 
            this.btn_nextShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_nextShift.Location = new System.Drawing.Point(284, 18);
            this.btn_nextShift.Name = "btn_nextShift";
            this.btn_nextShift.Size = new System.Drawing.Size(130, 100);
            this.btn_nextShift.TabIndex = 4;
            this.btn_nextShift.Text = "Работать! Следующая смена";
            this.btn_nextShift.UseVisualStyleBackColor = true;
            this.btn_nextShift.Click += new System.EventHandler(this.btn_nextShift_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 310);
            this.Controls.Add(this.btn_nextShift);
            this.Controls.Add(this.txtBx_report);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Main";
            this.Text = "Система управления ульем";
            ((System.ComponentModel.ISupportInitialize)(this.numUpd_shifts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBx_workerBeeJob;
        private System.Windows.Forms.NumericUpDown numUpd_shifts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_assignJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBx_report;
        private System.Windows.Forms.Button btn_nextShift;
    }
}

