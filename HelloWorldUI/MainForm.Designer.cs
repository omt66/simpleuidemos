namespace HelloWorldUI
{
    partial class MainForm
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
            this.btnOpenSecondForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenSecondForm
            // 
            this.btnOpenSecondForm.Location = new System.Drawing.Point(198, 227);
            this.btnOpenSecondForm.Name = "btnOpenSecondForm";
            this.btnOpenSecondForm.Size = new System.Drawing.Size(106, 31);
            this.btnOpenSecondForm.TabIndex = 0;
            this.btnOpenSecondForm.Text = "Open 2nd Form";
            this.btnOpenSecondForm.UseVisualStyleBackColor = true;
            this.btnOpenSecondForm.Click += new System.EventHandler(this.btnOpenSecondForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 322);
            this.Controls.Add(this.btnOpenSecondForm);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenSecondForm;
    }
}

