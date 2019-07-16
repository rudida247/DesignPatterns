namespace Memento
{
    partial class Form1
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
            this.rText = new System.Windows.Forms.RichTextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.undoBtn = new System.Windows.Forms.Button();
            this.reduBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rText
            // 
            this.rText.Location = new System.Drawing.Point(152, 93);
            this.rText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rText.Name = "rText";
            this.rText.Size = new System.Drawing.Size(1407, 493);
            this.rText.TabIndex = 0;
            this.rText.Text = "";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(152, 665);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(293, 119);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "&Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.Location = new System.Drawing.Point(528, 665);
            this.undoBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(293, 119);
            this.undoBtn.TabIndex = 2;
            this.undoBtn.Text = "&Undo";
            this.undoBtn.UseVisualStyleBackColor = true;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // button1
            // 
            this.reduBtn.Location = new System.Drawing.Point(880, 665);
            this.reduBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.reduBtn.Name = "reduBtn";
            this.reduBtn.Size = new System.Drawing.Size(293, 119);
            this.reduBtn.TabIndex = 3;
            this.reduBtn.Text = "&Redu";
            this.reduBtn.UseVisualStyleBackColor = true;
            this.reduBtn.Click += new System.EventHandler(this.reduBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1875, 861);
            this.Controls.Add(this.reduBtn);
            this.Controls.Add(this.undoBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.rText);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rText;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.Button reduBtn;
    }
}

