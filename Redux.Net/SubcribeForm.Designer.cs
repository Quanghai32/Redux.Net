namespace Redux.Net
{
    partial class SubcribeForm
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
            this.labelCounter = new System.Windows.Forms.Label();
            this.buttonIncrement = new System.Windows.Forms.Button();
            this.buttonDecrement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCounter.Location = new System.Drawing.Point(120, 141);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(39, 42);
            this.labelCounter.TabIndex = 0;
            this.labelCounter.Text = "0";
            // 
            // buttonIncrement
            // 
            this.buttonIncrement.Location = new System.Drawing.Point(33, 62);
            this.buttonIncrement.Name = "buttonIncrement";
            this.buttonIncrement.Size = new System.Drawing.Size(75, 55);
            this.buttonIncrement.TabIndex = 1;
            this.buttonIncrement.Text = "+";
            this.buttonIncrement.UseVisualStyleBackColor = true;
            this.buttonIncrement.Click += new System.EventHandler(this.buttonIncrement_Click);
            // 
            // buttonDecrement
            // 
            this.buttonDecrement.Location = new System.Drawing.Point(175, 62);
            this.buttonDecrement.Name = "buttonDecrement";
            this.buttonDecrement.Size = new System.Drawing.Size(75, 55);
            this.buttonDecrement.TabIndex = 2;
            this.buttonDecrement.Text = "-";
            this.buttonDecrement.UseVisualStyleBackColor = true;
            this.buttonDecrement.Click += new System.EventHandler(this.buttonDecrement_Click);
            // 
            // SubcribeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonDecrement);
            this.Controls.Add(this.buttonIncrement);
            this.Controls.Add(this.labelCounter);
            this.Name = "SubcribeForm";
            this.Text = "SubcribeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.Button buttonIncrement;
        private System.Windows.Forms.Button buttonDecrement;
    }
}