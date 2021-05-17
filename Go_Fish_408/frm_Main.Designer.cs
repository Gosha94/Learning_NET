namespace Go_Fish_408
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_StartGame = new System.Windows.Forms.Button();
            this.lbl_Progress = new System.Windows.Forms.Label();
            this.lstBx_PlayerHand = new System.Windows.Forms.ListBox();
            this.lbl_Hand = new System.Windows.Forms.Label();
            this.lbl_Books = new System.Windows.Forms.Label();
            this.btn_AskCards = new System.Windows.Forms.Button();
            this.txtBx_PlayerName = new System.Windows.Forms.TextBox();
            this.txtBx_Progress = new System.Windows.Forms.TextBox();
            this.txtBx_Books = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(5, 6);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // btn_StartGame
            // 
            this.btn_StartGame.Location = new System.Drawing.Point(114, 24);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(89, 23);
            this.btn_StartGame.TabIndex = 1;
            this.btn_StartGame.Text = "Start the game";
            this.btn_StartGame.UseVisualStyleBackColor = true;
            this.btn_StartGame.Click += new System.EventHandler(this.btn_StartGame_Click);
            // 
            // lbl_Progress
            // 
            this.lbl_Progress.AutoSize = true;
            this.lbl_Progress.Location = new System.Drawing.Point(4, 58);
            this.lbl_Progress.Name = "lbl_Progress";
            this.lbl_Progress.Size = new System.Drawing.Size(79, 13);
            this.lbl_Progress.TabIndex = 2;
            this.lbl_Progress.Text = "Game Progress";
            // 
            // lstBx_PlayerHand
            // 
            this.lstBx_PlayerHand.FormattingEnabled = true;
            this.lstBx_PlayerHand.Location = new System.Drawing.Point(209, 25);
            this.lstBx_PlayerHand.Name = "lstBx_PlayerHand";
            this.lstBx_PlayerHand.Size = new System.Drawing.Size(139, 381);
            this.lstBx_PlayerHand.TabIndex = 4;
            // 
            // lbl_Hand
            // 
            this.lbl_Hand.AutoSize = true;
            this.lbl_Hand.Location = new System.Drawing.Point(206, 6);
            this.lbl_Hand.Name = "lbl_Hand";
            this.lbl_Hand.Size = new System.Drawing.Size(58, 13);
            this.lbl_Hand.TabIndex = 5;
            this.lbl_Hand.Text = "Your Hand";
            // 
            // lbl_Books
            // 
            this.lbl_Books.AutoSize = true;
            this.lbl_Books.Location = new System.Drawing.Point(5, 311);
            this.lbl_Books.Name = "lbl_Books";
            this.lbl_Books.Size = new System.Drawing.Size(37, 13);
            this.lbl_Books.TabIndex = 6;
            this.lbl_Books.Text = "Books";
            // 
            // btn_AskCards
            // 
            this.btn_AskCards.Enabled = false;
            this.btn_AskCards.Location = new System.Drawing.Point(209, 415);
            this.btn_AskCards.Name = "btn_AskCards";
            this.btn_AskCards.Size = new System.Drawing.Size(139, 23);
            this.btn_AskCards.TabIndex = 8;
            this.btn_AskCards.Text = "Ack for a cards";
            this.btn_AskCards.UseVisualStyleBackColor = true;
            this.btn_AskCards.Click += new System.EventHandler(this.btn_AskCards_Click);
            // 
            // txtBx_PlayerName
            // 
            this.txtBx_PlayerName.Location = new System.Drawing.Point(7, 26);
            this.txtBx_PlayerName.Name = "txtBx_PlayerName";
            this.txtBx_PlayerName.Size = new System.Drawing.Size(101, 20);
            this.txtBx_PlayerName.TabIndex = 9;
            // 
            // txtBx_Progress
            // 
            this.txtBx_Progress.Location = new System.Drawing.Point(8, 75);
            this.txtBx_Progress.Multiline = true;
            this.txtBx_Progress.Name = "txtBx_Progress";
            this.txtBx_Progress.ReadOnly = true;
            this.txtBx_Progress.Size = new System.Drawing.Size(195, 233);
            this.txtBx_Progress.TabIndex = 10;
            // 
            // txtBx_Books
            // 
            this.txtBx_Books.Location = new System.Drawing.Point(7, 328);
            this.txtBx_Books.Multiline = true;
            this.txtBx_Books.Name = "txtBx_Books";
            this.txtBx_Books.ReadOnly = true;
            this.txtBx_Books.Size = new System.Drawing.Size(196, 109);
            this.txtBx_Books.TabIndex = 11;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 449);
            this.Controls.Add(this.txtBx_Books);
            this.Controls.Add(this.txtBx_Progress);
            this.Controls.Add(this.txtBx_PlayerName);
            this.Controls.Add(this.btn_AskCards);
            this.Controls.Add(this.lbl_Books);
            this.Controls.Add(this.lbl_Hand);
            this.Controls.Add(this.lstBx_PlayerHand);
            this.Controls.Add(this.lbl_Progress);
            this.Controls.Add(this.btn_StartGame);
            this.Controls.Add(this.lbl_Name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main";
            this.Text = "Go Fish Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_StartGame;
        private System.Windows.Forms.Label lbl_Progress;
        private System.Windows.Forms.ListBox lstBx_PlayerHand;
        private System.Windows.Forms.Label lbl_Hand;
        private System.Windows.Forms.Label lbl_Books;
        private System.Windows.Forms.Button btn_AskCards;
        private System.Windows.Forms.TextBox txtBx_PlayerName;
        private System.Windows.Forms.TextBox txtBx_Progress;
        private System.Windows.Forms.TextBox txtBx_Books;
    }
}

