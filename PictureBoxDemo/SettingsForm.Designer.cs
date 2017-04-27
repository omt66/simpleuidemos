namespace PictureBoxDemo
{
    partial class SettingsForm
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
            this.cbAutoSlideshow = new System.Windows.Forms.CheckBox();
            this.tbTimerInterval = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimerInterval = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimerInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.cbAutoSlideshow.AutoSize = true;
            this.cbAutoSlideshow.Location = new System.Drawing.Point(34, 29);
            this.cbAutoSlideshow.Name = "checkBox1";
            this.cbAutoSlideshow.Size = new System.Drawing.Size(99, 17);
            this.cbAutoSlideshow.TabIndex = 0;
            this.cbAutoSlideshow.Text = "Auto Slideshow";
            this.cbAutoSlideshow.UseVisualStyleBackColor = true;
            this.cbAutoSlideshow.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbTimerInterval
            // 
            this.tbTimerInterval.Location = new System.Drawing.Point(108, 68);
            this.tbTimerInterval.Maximum = 5000;
            this.tbTimerInterval.Minimum = 250;
            this.tbTimerInterval.Name = "tbTimerInterval";
            this.tbTimerInterval.Size = new System.Drawing.Size(243, 45);
            this.tbTimerInterval.TabIndex = 1;
            this.tbTimerInterval.Value = 250;
            this.tbTimerInterval.Scroll += new System.EventHandler(this.tbTimerInterval_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Timer Interval";
            // 
            // lblTimeInterval
            // 
            this.lblTimerInterval.AutoSize = true;
            this.lblTimerInterval.Location = new System.Drawing.Point(373, 77);
            this.lblTimerInterval.Name = "lblTimeInterval";
            this.lblTimerInterval.Size = new System.Drawing.Size(20, 13);
            this.lblTimerInterval.TabIndex = 3;
            this.lblTimerInterval.Text = "ms";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(168, 143);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 33);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 215);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTimerInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTimerInterval);
            this.Controls.Add(this.cbAutoSlideshow);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.tbTimerInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbAutoSlideshow;
        private System.Windows.Forms.TrackBar tbTimerInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimerInterval;
        private System.Windows.Forms.Button btnOK;
    }
}