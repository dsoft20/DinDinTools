namespace dindin.Modules
{
    partial class diceRoller
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
            this.diceLabel = new System.Windows.Forms.Label();
            this.diceSum = new System.Windows.Forms.Label();
            this.diceText = new System.Windows.Forms.TextBox();
            this.diceSummary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // diceLabel
            // 
            this.diceLabel.AutoSize = true;
            this.diceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceLabel.Location = new System.Drawing.Point(8, 9);
            this.diceLabel.Name = "diceLabel";
            this.diceLabel.Size = new System.Drawing.Size(45, 20);
            this.diceLabel.TabIndex = 0;
            this.diceLabel.Text = "Dice:";
            // 
            // diceSum
            // 
            this.diceSum.AutoSize = true;
            this.diceSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceSum.Location = new System.Drawing.Point(427, 311);
            this.diceSum.Name = "diceSum";
            this.diceSum.Size = new System.Drawing.Size(72, 25);
            this.diceSum.TabIndex = 1;
            this.diceSum.Text = "Total:";
            this.diceSum.Click += new System.EventHandler(this.diceSum_Click);
            // 
            // diceText
            // 
            this.diceText.BackColor = System.Drawing.SystemColors.Control;
            this.diceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diceText.Enabled = false;
            this.diceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceText.Location = new System.Drawing.Point(12, 32);
            this.diceText.Multiline = true;
            this.diceText.Name = "diceText";
            this.diceText.ShortcutsEnabled = false;
            this.diceText.Size = new System.Drawing.Size(582, 94);
            this.diceText.TabIndex = 2;
            this.diceText.TabStop = false;
            // 
            // diceSummary
            // 
            this.diceSummary.BackColor = System.Drawing.SystemColors.Control;
            this.diceSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diceSummary.Enabled = false;
            this.diceSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceSummary.Location = new System.Drawing.Point(12, 152);
            this.diceSummary.Multiline = true;
            this.diceSummary.Name = "diceSummary";
            this.diceSummary.Size = new System.Drawing.Size(582, 156);
            this.diceSummary.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Summary:";
            // 
            // diceRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diceSummary);
            this.Controls.Add(this.diceText);
            this.Controls.Add(this.diceSum);
            this.Controls.Add(this.diceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "diceRoller";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice roller";
            this.Load += new System.EventHandler(this.diceRoller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label diceLabel;
        private System.Windows.Forms.Label diceSum;
        private System.Windows.Forms.TextBox diceText;
        private System.Windows.Forms.TextBox diceSummary;
        private System.Windows.Forms.Label label1;
    }
}