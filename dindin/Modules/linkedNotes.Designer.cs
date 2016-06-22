namespace dindin.Modules
{
    partial class linkedNotes
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
            this.lnks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lnks
            // 
            this.lnks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnks.FormattingEnabled = true;
            this.lnks.ItemHeight = 24;
            this.lnks.Location = new System.Drawing.Point(0, 0);
            this.lnks.Name = "lnks";
            this.lnks.Size = new System.Drawing.Size(199, 460);
            this.lnks.TabIndex = 0;
            // 
            // linkedNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 460);
            this.ControlBox = false;
            this.Controls.Add(this.lnks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "linkedNotes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linked notes";
            this.Load += new System.EventHandler(this.linkedNotes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lnks;
    }
}