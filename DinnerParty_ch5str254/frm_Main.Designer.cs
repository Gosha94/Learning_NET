namespace DinnerParty_ch5str254
{
    partial class frm_Main
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
            this.lbl_NumPeople = new System.Windows.Forms.Label();
            this.numUpD_numbPeople = new System.Windows.Forms.NumericUpDown();
            this.chkBx_Fancy = new System.Windows.Forms.CheckBox();
            this.chkBx_Healthy = new System.Windows.Forms.CheckBox();
            this.lbl_Cost = new System.Windows.Forms.Label();
            this.lbl_CostOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpD_numbPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NumPeople
            // 
            this.lbl_NumPeople.AutoSize = true;
            this.lbl_NumPeople.Location = new System.Drawing.Point(45, 22);
            this.lbl_NumPeople.Name = "lbl_NumPeople";
            this.lbl_NumPeople.Size = new System.Drawing.Size(92, 13);
            this.lbl_NumPeople.TabIndex = 0;
            this.lbl_NumPeople.Text = "Number of People";
            // 
            // numUpD_numbPeople
            // 
            this.numUpD_numbPeople.Location = new System.Drawing.Point(47, 42);
            this.numUpD_numbPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpD_numbPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpD_numbPeople.Name = "numUpD_numbPeople";
            this.numUpD_numbPeople.Size = new System.Drawing.Size(120, 20);
            this.numUpD_numbPeople.TabIndex = 1;
            this.numUpD_numbPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpD_numbPeople.ValueChanged += new System.EventHandler(this.numUpD_numbPeople_ValueChanged);
            // 
            // chkBx_Fancy
            // 
            this.chkBx_Fancy.AutoSize = true;
            this.chkBx_Fancy.Checked = true;
            this.chkBx_Fancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBx_Fancy.Location = new System.Drawing.Point(48, 70);
            this.chkBx_Fancy.Name = "chkBx_Fancy";
            this.chkBx_Fancy.Size = new System.Drawing.Size(112, 17);
            this.chkBx_Fancy.TabIndex = 2;
            this.chkBx_Fancy.Text = "Fancy Decoraions";
            this.chkBx_Fancy.UseVisualStyleBackColor = true;
            this.chkBx_Fancy.CheckedChanged += new System.EventHandler(this.chkBx_Fancy_CheckedChanged);
            // 
            // chkBx_Healthy
            // 
            this.chkBx_Healthy.AutoSize = true;
            this.chkBx_Healthy.Location = new System.Drawing.Point(48, 93);
            this.chkBx_Healthy.Name = "chkBx_Healthy";
            this.chkBx_Healthy.Size = new System.Drawing.Size(96, 17);
            this.chkBx_Healthy.TabIndex = 3;
            this.chkBx_Healthy.Text = "Healthy Option";
            this.chkBx_Healthy.UseVisualStyleBackColor = true;
            this.chkBx_Healthy.CheckedChanged += new System.EventHandler(this.chkBx_Healthy_CheckedChanged);
            // 
            // lbl_Cost
            // 
            this.lbl_Cost.AutoSize = true;
            this.lbl_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Cost.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_Cost.Location = new System.Drawing.Point(47, 132);
            this.lbl_Cost.Name = "lbl_Cost";
            this.lbl_Cost.Size = new System.Drawing.Size(32, 13);
            this.lbl_Cost.TabIndex = 4;
            this.lbl_Cost.Text = "Cost";
            // 
            // lbl_CostOut
            // 
            this.lbl_CostOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_CostOut.Location = new System.Drawing.Point(97, 122);
            this.lbl_CostOut.Name = "lbl_CostOut";
            this.lbl_CostOut.Size = new System.Drawing.Size(100, 23);
            this.lbl_CostOut.TabIndex = 5;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 173);
            this.Controls.Add(this.lbl_CostOut);
            this.Controls.Add(this.lbl_Cost);
            this.Controls.Add(this.chkBx_Healthy);
            this.Controls.Add(this.chkBx_Fancy);
            this.Controls.Add(this.numUpD_numbPeople);
            this.Controls.Add(this.lbl_NumPeople);
            this.Name = "frm_Main";
            this.Text = "Dinner Party Planner";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpD_numbPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NumPeople;
        private System.Windows.Forms.NumericUpDown numUpD_numbPeople;
        private System.Windows.Forms.CheckBox chkBx_Fancy;
        private System.Windows.Forms.CheckBox chkBx_Healthy;
        private System.Windows.Forms.Label lbl_Cost;
        private System.Windows.Forms.Label lbl_CostOut;
    }
}

