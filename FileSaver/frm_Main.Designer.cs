namespace FileSaver
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
            this.opFileDia_Open = new System.Windows.Forms.OpenFileDialog();
            this.savFileDia_Save = new System.Windows.Forms.SaveFileDialog();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txtBx_TextArea = new System.Windows.Forms.TextBox();
            this.tblLayPanl_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayout_DownPanl = new System.Windows.Forms.FlowLayoutPanel();
            this.tblLayPanl_Layout.SuspendLayout();
            this.flowLayout_DownPanl.SuspendLayout();
            this.SuspendLayout();
            // 
            // opFileDia_Open
            // 
            this.opFileDia_Open.FileName = "opFileDia_Open";
            this.opFileDia_Open.Filter = "Text Files (*.txt)|*.txt";
            this.opFileDia_Open.InitialDirectory = "D:\\Soft";
            // 
            // savFileDia_Save
            // 
            this.savFileDia_Save.InitialDirectory = "D:\\Drivers";
            this.savFileDia_Save.Title = "Save the file";
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(239, 3);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(75, 23);
            this.btn_Open.TabIndex = 0;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(320, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txtBx_TextArea
            // 
            this.txtBx_TextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBx_TextArea.Location = new System.Drawing.Point(3, 3);
            this.txtBx_TextArea.Multiline = true;
            this.txtBx_TextArea.Name = "txtBx_TextArea";
            this.txtBx_TextArea.Size = new System.Drawing.Size(398, 169);
            this.txtBx_TextArea.TabIndex = 2;
            // 
            // tblLayPanl_Layout
            // 
            this.tblLayPanl_Layout.ColumnCount = 1;
            this.tblLayPanl_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayPanl_Layout.Controls.Add(this.flowLayout_DownPanl, 0, 1);
            this.tblLayPanl_Layout.Controls.Add(this.txtBx_TextArea, 0, 0);
            this.tblLayPanl_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayPanl_Layout.Location = new System.Drawing.Point(0, 0);
            this.tblLayPanl_Layout.Name = "tblLayPanl_Layout";
            this.tblLayPanl_Layout.RowCount = 2;
            this.tblLayPanl_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayPanl_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayPanl_Layout.Size = new System.Drawing.Size(404, 351);
            this.tblLayPanl_Layout.TabIndex = 3;
            // 
            // flowLayout_DownPanl
            // 
            this.flowLayout_DownPanl.Controls.Add(this.btn_Save);
            this.flowLayout_DownPanl.Controls.Add(this.btn_Open);
            this.flowLayout_DownPanl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayout_DownPanl.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayout_DownPanl.Location = new System.Drawing.Point(3, 178);
            this.flowLayout_DownPanl.Name = "flowLayout_DownPanl";
            this.flowLayout_DownPanl.Size = new System.Drawing.Size(398, 170);
            this.flowLayout_DownPanl.TabIndex = 3;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 351);
            this.Controls.Add(this.tblLayPanl_Layout);
            this.Name = "frm_Main";
            this.Text = "Simple Text Editor";
            this.tblLayPanl_Layout.ResumeLayout(false);
            this.tblLayPanl_Layout.PerformLayout();
            this.flowLayout_DownPanl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog opFileDia_Open;
        private System.Windows.Forms.SaveFileDialog savFileDia_Save;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txtBx_TextArea;
        private System.Windows.Forms.TableLayoutPanel tblLayPanl_Layout;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_DownPanl;
    }
}

