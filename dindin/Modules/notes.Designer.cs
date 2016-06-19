namespace dindin.Modules
{
    partial class notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notes));
            this.noteName = new System.Windows.Forms.TextBox();
            this.noteText = new System.Windows.Forms.TextBox();
            this.noteLabelName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveStateLabel = new System.Windows.Forms.Label();
            this.othersFiles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // noteName
            // 
            this.noteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteName.Location = new System.Drawing.Point(12, 12);
            this.noteName.Name = "noteName";
            this.noteName.Size = new System.Drawing.Size(305, 38);
            this.noteName.TabIndex = 0;
            this.noteName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // noteText
            // 
            this.noteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteText.Location = new System.Drawing.Point(12, 77);
            this.noteText.Multiline = true;
            this.noteText.Name = "noteText";
            this.noteText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.noteText.Size = new System.Drawing.Size(567, 380);
            this.noteText.TabIndex = 1;
            this.noteText.TextChanged += new System.EventHandler(this.noteText_TextChanged);
            // 
            // noteLabelName
            // 
            this.noteLabelName.AutoSize = true;
            this.noteLabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabelName.Location = new System.Drawing.Point(332, 9);
            this.noteLabelName.Name = "noteLabelName";
            this.noteLabelName.Size = new System.Drawing.Size(0, 37);
            this.noteLabelName.TabIndex = 2;
            // 
            // saveStateLabel
            // 
            this.saveStateLabel.AutoSize = true;
            this.saveStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveStateLabel.Location = new System.Drawing.Point(9, 53);
            this.saveStateLabel.Name = "saveStateLabel";
            this.saveStateLabel.Size = new System.Drawing.Size(0, 16);
            this.saveStateLabel.TabIndex = 3;
            // 
            // othersFiles
            // 
            this.othersFiles.AutoSize = true;
            this.othersFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othersFiles.Location = new System.Drawing.Point(335, 50);
            this.othersFiles.Name = "othersFiles";
            this.othersFiles.Size = new System.Drawing.Size(0, 18);
            this.othersFiles.TabIndex = 4;
            // 
            // notes
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 471);
            this.Controls.Add(this.othersFiles);
            this.Controls.Add(this.saveStateLabel);
            this.Controls.Add(this.noteLabelName);
            this.Controls.Add(this.noteText);
            this.Controls.Add(this.noteName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "notes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.notes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox noteName;
        private System.Windows.Forms.TextBox noteText;
        private System.Windows.Forms.Label noteLabelName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label saveStateLabel;
        private System.Windows.Forms.Label othersFiles;
    }
}