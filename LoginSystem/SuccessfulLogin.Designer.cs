namespace LoginSystem
{
    partial class SuccessfulLogin
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
            this.UIText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UIText
            // 
            this.UIText.AutoSize = true;
            this.UIText.Location = new System.Drawing.Point(99, 86);
            this.UIText.Name = "UIText";
            this.UIText.Size = new System.Drawing.Size(39, 16);
            this.UIText.TabIndex = 0;
            this.UIText.Text = "Hello ";
            // 
            // SuccessfulLogin
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.UIText);
            this.Name = "SuccessfulLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UIText;
    }
}