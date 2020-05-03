namespace PartyPlanner_v2_0
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tPage_Dinner = new System.Windows.Forms.TabPage();
            this.lbl_CostOut = new System.Windows.Forms.Label();
            this.numUpD_numbPeople = new System.Windows.Forms.NumericUpDown();
            this.lbl_Cost = new System.Windows.Forms.Label();
            this.lbl_NumPeople = new System.Windows.Forms.Label();
            this.chkBx_Healthy = new System.Windows.Forms.CheckBox();
            this.chkBx_Fancy = new System.Windows.Forms.CheckBox();
            this.tPage_Birth = new System.Windows.Forms.TabPage();
            this.lbl_BirthCost = new System.Windows.Forms.Label();
            this.lbl_tooLong = new System.Windows.Forms.Label();
            this.txtBx_CakeWrit = new System.Windows.Forms.TextBox();
            this.chkBx_FancyDecor = new System.Windows.Forms.CheckBox();
            this.numUpD_NumPipl = new System.Windows.Forms.NumericUpDown();
            this.lbl_labelCost = new System.Windows.Forms.Label();
            this.lbl_CakeWrit = new System.Windows.Forms.Label();
            this.lbl_NumbPipl = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tPage_Dinner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpD_numbPeople)).BeginInit();
            this.tPage_Birth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpD_NumPipl)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tPage_Dinner);
            this.tabControl1.Controls.Add(this.tPage_Birth);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(226, 199);
            this.tabControl1.TabIndex = 0;
            // 
            // tPage_Dinner
            // 
            this.tPage_Dinner.Controls.Add(this.lbl_CostOut);
            this.tPage_Dinner.Controls.Add(this.numUpD_numbPeople);
            this.tPage_Dinner.Controls.Add(this.lbl_Cost);
            this.tPage_Dinner.Controls.Add(this.lbl_NumPeople);
            this.tPage_Dinner.Controls.Add(this.chkBx_Healthy);
            this.tPage_Dinner.Controls.Add(this.chkBx_Fancy);
            this.tPage_Dinner.Location = new System.Drawing.Point(4, 22);
            this.tPage_Dinner.Name = "tPage_Dinner";
            this.tPage_Dinner.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_Dinner.Size = new System.Drawing.Size(218, 173);
            this.tPage_Dinner.TabIndex = 0;
            this.tPage_Dinner.Text = "DinnerParty";
            this.tPage_Dinner.UseVisualStyleBackColor = true;
            // 
            // lbl_CostOut
            // 
            this.lbl_CostOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_CostOut.Location = new System.Drawing.Point(87, 118);
            this.lbl_CostOut.Name = "lbl_CostOut";
            this.lbl_CostOut.Size = new System.Drawing.Size(100, 23);
            this.lbl_CostOut.TabIndex = 11;
            // 
            // numUpD_numbPeople
            // 
            this.numUpD_numbPeople.Location = new System.Drawing.Point(37, 38);
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
            this.numUpD_numbPeople.TabIndex = 7;
            this.numUpD_numbPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpD_numbPeople.ValueChanged += new System.EventHandler(this.numUpD_numbPeople_ValueChanged);
            // 
            // lbl_Cost
            // 
            this.lbl_Cost.AutoSize = true;
            this.lbl_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Cost.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_Cost.Location = new System.Drawing.Point(37, 128);
            this.lbl_Cost.Name = "lbl_Cost";
            this.lbl_Cost.Size = new System.Drawing.Size(32, 13);
            this.lbl_Cost.TabIndex = 10;
            this.lbl_Cost.Text = "Cost";
            // 
            // lbl_NumPeople
            // 
            this.lbl_NumPeople.AutoSize = true;
            this.lbl_NumPeople.Location = new System.Drawing.Point(35, 18);
            this.lbl_NumPeople.Name = "lbl_NumPeople";
            this.lbl_NumPeople.Size = new System.Drawing.Size(92, 13);
            this.lbl_NumPeople.TabIndex = 6;
            this.lbl_NumPeople.Text = "Number of People";
            // 
            // chkBx_Healthy
            // 
            this.chkBx_Healthy.AutoSize = true;
            this.chkBx_Healthy.Location = new System.Drawing.Point(38, 89);
            this.chkBx_Healthy.Name = "chkBx_Healthy";
            this.chkBx_Healthy.Size = new System.Drawing.Size(96, 17);
            this.chkBx_Healthy.TabIndex = 9;
            this.chkBx_Healthy.Text = "Healthy Option";
            this.chkBx_Healthy.UseVisualStyleBackColor = true;
            this.chkBx_Healthy.CheckedChanged += new System.EventHandler(this.chkBx_Healthy_CheckedChanged);
            // 
            // chkBx_Fancy
            // 
            this.chkBx_Fancy.AutoSize = true;
            this.chkBx_Fancy.Checked = true;
            this.chkBx_Fancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBx_Fancy.Location = new System.Drawing.Point(38, 66);
            this.chkBx_Fancy.Name = "chkBx_Fancy";
            this.chkBx_Fancy.Size = new System.Drawing.Size(112, 17);
            this.chkBx_Fancy.TabIndex = 8;
            this.chkBx_Fancy.Text = "Fancy Decoraions";
            this.chkBx_Fancy.UseVisualStyleBackColor = true;
            this.chkBx_Fancy.CheckedChanged += new System.EventHandler(this.chkBx_Fancy_CheckedChanged);
            // 
            // tPage_Birth
            // 
            this.tPage_Birth.Controls.Add(this.lbl_BirthCost);
            this.tPage_Birth.Controls.Add(this.lbl_tooLong);
            this.tPage_Birth.Controls.Add(this.txtBx_CakeWrit);
            this.tPage_Birth.Controls.Add(this.chkBx_FancyDecor);
            this.tPage_Birth.Controls.Add(this.numUpD_NumPipl);
            this.tPage_Birth.Controls.Add(this.lbl_labelCost);
            this.tPage_Birth.Controls.Add(this.lbl_CakeWrit);
            this.tPage_Birth.Controls.Add(this.lbl_NumbPipl);
            this.tPage_Birth.Location = new System.Drawing.Point(4, 22);
            this.tPage_Birth.Name = "tPage_Birth";
            this.tPage_Birth.Padding = new System.Windows.Forms.Padding(3);
            this.tPage_Birth.Size = new System.Drawing.Size(218, 173);
            this.tPage_Birth.TabIndex = 1;
            this.tPage_Birth.Text = "BirthdayParty";
            this.tPage_Birth.UseVisualStyleBackColor = true;
            // 
            // lbl_BirthCost
            // 
            this.lbl_BirthCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_BirthCost.Location = new System.Drawing.Point(85, 141);
            this.lbl_BirthCost.Name = "lbl_BirthCost";
            this.lbl_BirthCost.Size = new System.Drawing.Size(92, 23);
            this.lbl_BirthCost.TabIndex = 7;
            // 
            // lbl_tooLong
            // 
            this.lbl_tooLong.AutoSize = true;
            this.lbl_tooLong.BackColor = System.Drawing.Color.Red;
            this.lbl_tooLong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_tooLong.Location = new System.Drawing.Point(114, 85);
            this.lbl_tooLong.Name = "lbl_tooLong";
            this.lbl_tooLong.Size = new System.Drawing.Size(63, 13);
            this.lbl_tooLong.TabIndex = 6;
            this.lbl_tooLong.Text = "TOO LONG";
            // 
            // txtBx_CakeWrit
            // 
            this.txtBx_CakeWrit.Location = new System.Drawing.Point(41, 109);
            this.txtBx_CakeWrit.Name = "txtBx_CakeWrit";
            this.txtBx_CakeWrit.Size = new System.Drawing.Size(136, 20);
            this.txtBx_CakeWrit.TabIndex = 5;
            this.txtBx_CakeWrit.Text = "Happy Birthday";
            this.txtBx_CakeWrit.TextChanged += new System.EventHandler(this.txtBx_CakeWrit_TextChanged);
            // 
            // chkBx_FancyDecor
            // 
            this.chkBx_FancyDecor.AutoSize = true;
            this.chkBx_FancyDecor.Checked = true;
            this.chkBx_FancyDecor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBx_FancyDecor.Location = new System.Drawing.Point(41, 61);
            this.chkBx_FancyDecor.Name = "chkBx_FancyDecor";
            this.chkBx_FancyDecor.Size = new System.Drawing.Size(115, 17);
            this.chkBx_FancyDecor.TabIndex = 4;
            this.chkBx_FancyDecor.Text = "Fancy Decorations";
            this.chkBx_FancyDecor.UseVisualStyleBackColor = true;
            this.chkBx_FancyDecor.CheckedChanged += new System.EventHandler(this.chkBx_FancyDecor_CheckedChanged);
            // 
            // numUpD_NumPipl
            // 
            this.numUpD_NumPipl.Location = new System.Drawing.Point(41, 32);
            this.numUpD_NumPipl.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpD_NumPipl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpD_NumPipl.Name = "numUpD_NumPipl";
            this.numUpD_NumPipl.Size = new System.Drawing.Size(120, 20);
            this.numUpD_NumPipl.TabIndex = 3;
            this.numUpD_NumPipl.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpD_NumPipl.ValueChanged += new System.EventHandler(this.numUpD_NumPipl_ValueChanged);
            // 
            // lbl_labelCost
            // 
            this.lbl_labelCost.AutoSize = true;
            this.lbl_labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_labelCost.Location = new System.Drawing.Point(38, 141);
            this.lbl_labelCost.Name = "lbl_labelCost";
            this.lbl_labelCost.Size = new System.Drawing.Size(32, 13);
            this.lbl_labelCost.TabIndex = 2;
            this.lbl_labelCost.Text = "Cost";
            // 
            // lbl_CakeWrit
            // 
            this.lbl_CakeWrit.AutoSize = true;
            this.lbl_CakeWrit.Location = new System.Drawing.Point(39, 86);
            this.lbl_CakeWrit.Name = "lbl_CakeWrit";
            this.lbl_CakeWrit.Size = new System.Drawing.Size(68, 13);
            this.lbl_CakeWrit.TabIndex = 1;
            this.lbl_CakeWrit.Text = "Cake Writing";
            // 
            // lbl_NumbPipl
            // 
            this.lbl_NumbPipl.AutoSize = true;
            this.lbl_NumbPipl.Location = new System.Drawing.Point(38, 12);
            this.lbl_NumbPipl.Name = "lbl_NumbPipl";
            this.lbl_NumbPipl.Size = new System.Drawing.Size(92, 13);
            this.lbl_NumbPipl.TabIndex = 0;
            this.lbl_NumbPipl.Text = "Number of People";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 199);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_Main";
            this.Text = "Party Planner v 3.0";
            this.tabControl1.ResumeLayout(false);
            this.tPage_Dinner.ResumeLayout(false);
            this.tPage_Dinner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpD_numbPeople)).EndInit();
            this.tPage_Birth.ResumeLayout(false);
            this.tPage_Birth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpD_NumPipl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tPage_Dinner;
        private System.Windows.Forms.TabPage tPage_Birth;
        private System.Windows.Forms.Label lbl_CostOut;
        private System.Windows.Forms.NumericUpDown numUpD_numbPeople;
        private System.Windows.Forms.Label lbl_Cost;
        private System.Windows.Forms.Label lbl_NumPeople;
        private System.Windows.Forms.CheckBox chkBx_Healthy;
        private System.Windows.Forms.CheckBox chkBx_Fancy;
        private System.Windows.Forms.CheckBox chkBx_FancyDecor;
        private System.Windows.Forms.Label lbl_labelCost;
        private System.Windows.Forms.Label lbl_CakeWrit;
        private System.Windows.Forms.Label lbl_NumbPipl;
        private System.Windows.Forms.Label lbl_tooLong;
        private System.Windows.Forms.TextBox txtBx_CakeWrit;
        private System.Windows.Forms.NumericUpDown numUpD_NumPipl;
        private System.Windows.Forms.Label lbl_BirthCost;
    }
}

