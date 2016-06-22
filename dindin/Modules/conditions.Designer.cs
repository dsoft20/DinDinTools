namespace dindin.Modules
{
    partial class conditions
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.conditionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.conditionText = new System.Windows.Forms.TextBox();
            this.conditionNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // conditionName
            // 
            this.conditionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionName.Location = new System.Drawing.Point(12, 12);
            this.conditionName.Name = "conditionName";
            this.conditionName.Size = new System.Drawing.Size(302, 38);
            this.conditionName.TabIndex = 0;
            this.conditionName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 1;
            // 
            // conditionText
            // 
            this.conditionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conditionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionText.Location = new System.Drawing.Point(12, 72);
            this.conditionText.Multiline = true;
            this.conditionText.Name = "conditionText";
            this.conditionText.ReadOnly = true;
            this.conditionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.conditionText.Size = new System.Drawing.Size(665, 357);
            this.conditionText.TabIndex = 2;
            this.conditionText.TabStop = false;
            // 
            // conditionNameLabel
            // 
            this.conditionNameLabel.AutoSize = true;
            this.conditionNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.conditionNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionNameLabel.ForeColor = System.Drawing.Color.Gray;
            this.conditionNameLabel.Location = new System.Drawing.Point(320, 15);
            this.conditionNameLabel.Name = "conditionNameLabel";
            this.conditionNameLabel.Size = new System.Drawing.Size(0, 31);
            this.conditionNameLabel.TabIndex = 3;
            // 
            // conditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 441);
            this.ControlBox = false;
            this.Controls.Add(this.conditionNameLabel);
            this.Controls.Add(this.conditionText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conditionName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "conditions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conditions";
            this.Load += new System.EventHandler(this.conditions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox conditionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox conditionText;
        private System.Windows.Forms.Label conditionNameLabel;
    }
}