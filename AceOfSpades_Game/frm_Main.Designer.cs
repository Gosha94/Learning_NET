namespace AceOfSpades_Game
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
            this.btn_GetCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GetCard
            // 
            this.btn_GetCard.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetCard.Location = new System.Drawing.Point(55, 38);
            this.btn_GetCard.Name = "btn_GetCard";
            this.btn_GetCard.Size = new System.Drawing.Size(168, 60);
            this.btn_GetCard.TabIndex = 0;
            this.btn_GetCard.Text = "Взять карту";
            this.btn_GetCard.UseVisualStyleBackColor = true;
            this.btn_GetCard.Click += new System.EventHandler(this.btn_GetCard_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 129);
            this.Controls.Add(this.btn_GetCard);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main";
            this.Text = "Случайный выбор карты";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GetCard;
    }
}