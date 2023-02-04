namespace TinhThue
{
    partial class Form2
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
            this.textBoxKetQuaQuyetToan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxKetQuaQuyetToan
            // 
            this.textBoxKetQuaQuyetToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxKetQuaQuyetToan.Location = new System.Drawing.Point(0, 0);
            this.textBoxKetQuaQuyetToan.Multiline = true;
            this.textBoxKetQuaQuyetToan.Name = "textBoxKetQuaQuyetToan";
            this.textBoxKetQuaQuyetToan.Size = new System.Drawing.Size(800, 450);
            this.textBoxKetQuaQuyetToan.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxKetQuaQuyetToan);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKetQuaQuyetToan;
    }
}