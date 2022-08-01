namespace FotoFrame
{
    partial class Image_load
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.file_name_label = new System.Windows.Forms.Label();
            this.prog_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(426, 43);
            this.progressBar1.TabIndex = 0;
            // 
            // file_name_label
            // 
            this.file_name_label.AutoSize = true;
            this.file_name_label.Location = new System.Drawing.Point(12, 9);
            this.file_name_label.Name = "file_name_label";
            this.file_name_label.Size = new System.Drawing.Size(50, 20);
            this.file_name_label.TabIndex = 1;
            this.file_name_label.Text = "label1";
            // 
            // prog_num
            // 
            this.prog_num.AutoSize = true;
            this.prog_num.Location = new System.Drawing.Point(408, 9);
            this.prog_num.Name = "prog_num";
            this.prog_num.Size = new System.Drawing.Size(21, 20);
            this.prog_num.TabIndex = 2;
            this.prog_num.Text = "%";
            // 
            // Image_load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 87);
            this.Controls.Add(this.prog_num);
            this.Controls.Add(this.file_name_label);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Image_load";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image_load";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar progressBar1;
        private Label file_name_label;
        private Label prog_num;
    }
}