namespace AndonSerial
{
    partial class AndonButtonControl
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
            this.btnControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(110, 39);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(75, 23);
            this.btnControl.TabIndex = 0;
            this.btnControl.Text = "button1";
            this.btnControl.UseVisualStyleBackColor = true;
            // 
            // AndonButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 283);
            this.Controls.Add(this.btnControl);
            this.Name = "AndonButtonControl";
            this.Text = "AndonButtonControl";
            this.Load += new System.EventHandler(this.AndonButtonControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnControl;
    }
}