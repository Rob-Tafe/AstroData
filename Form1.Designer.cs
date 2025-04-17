namespace AstroData
{
    partial class AstroDataForm
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
            this.ButtonRandomData = new System.Windows.Forms.Button();
            this.ListBoxData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ButtonRandomData
            // 
            this.ButtonRandomData.Location = new System.Drawing.Point(13, 13);
            this.ButtonRandomData.Name = "ButtonRandomData";
            this.ButtonRandomData.Size = new System.Drawing.Size(139, 23);
            this.ButtonRandomData.TabIndex = 0;
            this.ButtonRandomData.Text = "Load Astrometric Data";
            this.ButtonRandomData.UseVisualStyleBackColor = true;
            // 
            // ListBoxData
            // 
            this.ListBoxData.FormattingEnabled = true;
            this.ListBoxData.Location = new System.Drawing.Point(13, 52);
            this.ListBoxData.Name = "ListBoxData";
            this.ListBoxData.Size = new System.Drawing.Size(139, 303);
            this.ListBoxData.TabIndex = 1;
            // 
            // AstroDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 426);
            this.Controls.Add(this.ListBoxData);
            this.Controls.Add(this.ButtonRandomData);
            this.Name = "AstroDataForm";
            this.Text = "AstroData";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonRandomData;
        private System.Windows.Forms.ListBox ListBoxData;
    }
}

