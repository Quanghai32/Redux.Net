namespace Redux.Net
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
            this.buttonIncrement = new System.Windows.Forms.Button();
            this.buttonDecrement = new System.Windows.Forms.Button();
            this.labelCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonIncrement
            // 
            this.buttonIncrement.Location = new System.Drawing.Point(29, 49);
            this.buttonIncrement.Name = "buttonIncrement";
            this.buttonIncrement.Size = new System.Drawing.Size(75, 23);
            this.buttonIncrement.TabIndex = 0;
            this.buttonIncrement.Text = "+";
            this.buttonIncrement.UseVisualStyleBackColor = true;
            this.buttonIncrement.Click += new System.EventHandler(this.buttonIncrement_Click);
            // 
            // buttonDecrement
            // 
            this.buttonDecrement.Location = new System.Drawing.Point(172, 49);
            this.buttonDecrement.Name = "buttonDecrement";
            this.buttonDecrement.Size = new System.Drawing.Size(75, 23);
            this.buttonDecrement.TabIndex = 1;
            this.buttonDecrement.Text = "-";
            this.buttonDecrement.UseVisualStyleBackColor = true;
            this.buttonDecrement.Click += new System.EventHandler(this.buttonDecrement_Click);
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Location = new System.Drawing.Point(126, 125);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(13, 13);
            this.labelCounter.TabIndex = 2;
            this.labelCounter.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.buttonDecrement);
            this.Controls.Add(this.buttonIncrement);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIncrement;
        private System.Windows.Forms.Button buttonDecrement;
        private System.Windows.Forms.Label labelCounter;
    }
}

