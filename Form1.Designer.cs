namespace Activity1
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
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblButtonPurpose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(89, 109);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(150, 43);
            this.btnContinue.TabIndex = 0;
            this.btnContinue.Text = "NOW HERE";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblButtonPurpose
            // 
            this.lblButtonPurpose.AutoSize = true;
            this.lblButtonPurpose.Location = new System.Drawing.Point(130, 46);
            this.lblButtonPurpose.Name = "lblButtonPurpose";
            this.lblButtonPurpose.Size = new System.Drawing.Size(70, 13);
            this.lblButtonPurpose.TabIndex = 1;
            this.lblButtonPurpose.Text = "CLICK HERE";
            this.lblButtonPurpose.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 209);
            this.Controls.Add(this.lblButtonPurpose);
            this.Controls.Add(this.btnContinue);
            this.Name = "Form1";
            this.Text = "Activity 1 - Button & Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblButtonPurpose;
    }
}

