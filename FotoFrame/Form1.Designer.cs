namespace FotoFrame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inputfolder_Label = new System.Windows.Forms.Label();
            this.inputfolder_textBox = new System.Windows.Forms.TextBox();
            this.selectinput_button = new System.Windows.Forms.Button();
            this.outputfolder_label = new System.Windows.Forms.Label();
            this.outputfolder_textBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.convert_button = new System.Windows.Forms.Button();
            this.selectoutput_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.reloadButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelectedItems = new System.Windows.Forms.Label();
            this.item_Count_label = new System.Windows.Forms.Label();
            this.reduce_size_button = new System.Windows.Forms.Button();
            this.enlarge_size_button = new System.Windows.Forms.Button();
            this.select_none_button = new System.Windows.Forms.Button();
            this.select_all_button = new System.Windows.Forms.Button();
            this.Color_label1 = new System.Windows.Forms.Label();
            this.frame_size_label = new System.Windows.Forms.Label();
            this.color_preview_textBox1 = new System.Windows.Forms.TextBox();
            this.colorName_preview_textBox2 = new System.Windows.Forms.TextBox();
            this.select_color_button1 = new System.Windows.Forms.Button();
            this.image_preview_label1 = new System.Windows.Forms.Label();
            this.up_button1 = new System.Windows.Forms.Button();
            this.left_button1 = new System.Windows.Forms.Button();
            this.right_button1 = new System.Windows.Forms.Button();
            this.down_button1 = new System.Windows.Forms.Button();
            this.re_pos_button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem1.Text = "About FotoFrame";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.Aboutpage_button_Click);
            // 
            // inputfolder_Label
            // 
            this.inputfolder_Label.AutoSize = true;
            this.inputfolder_Label.Location = new System.Drawing.Point(12, 46);
            this.inputfolder_Label.Name = "inputfolder_Label";
            this.inputfolder_Label.Size = new System.Drawing.Size(94, 20);
            this.inputfolder_Label.TabIndex = 2;
            this.inputfolder_Label.Text = "Input folder :";
            // 
            // inputfolder_textBox
            // 
            this.inputfolder_textBox.Location = new System.Drawing.Point(12, 69);
            this.inputfolder_textBox.Name = "inputfolder_textBox";
            this.inputfolder_textBox.ReadOnly = true;
            this.inputfolder_textBox.Size = new System.Drawing.Size(309, 27);
            this.inputfolder_textBox.TabIndex = 3;
            // 
            // selectinput_button
            // 
            this.selectinput_button.Location = new System.Drawing.Point(118, 102);
            this.selectinput_button.Name = "selectinput_button";
            this.selectinput_button.Size = new System.Drawing.Size(203, 29);
            this.selectinput_button.TabIndex = 4;
            this.selectinput_button.Text = "Select Folder";
            this.selectinput_button.UseVisualStyleBackColor = true;
            this.selectinput_button.Click += new System.EventHandler(this.selectinput_button_Click);
            // 
            // outputfolder_label
            // 
            this.outputfolder_label.AutoSize = true;
            this.outputfolder_label.Location = new System.Drawing.Point(12, 159);
            this.outputfolder_label.Name = "outputfolder_label";
            this.outputfolder_label.Size = new System.Drawing.Size(106, 20);
            this.outputfolder_label.TabIndex = 5;
            this.outputfolder_label.Text = "Output folder :";
            // 
            // outputfolder_textBox
            // 
            this.outputfolder_textBox.Location = new System.Drawing.Point(12, 182);
            this.outputfolder_textBox.Name = "outputfolder_textBox";
            this.outputfolder_textBox.ReadOnly = true;
            this.outputfolder_textBox.Size = new System.Drawing.Size(309, 27);
            this.outputfolder_textBox.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 440);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(831, 29);
            this.progressBar1.TabIndex = 8;
            // 
            // convert_button
            // 
            this.convert_button.Location = new System.Drawing.Point(887, 440);
            this.convert_button.Name = "convert_button";
            this.convert_button.Size = new System.Drawing.Size(177, 29);
            this.convert_button.TabIndex = 9;
            this.convert_button.Text = "Convert";
            this.convert_button.UseVisualStyleBackColor = true;
            this.convert_button.Click += new System.EventHandler(this.Convert_button_Click);
            // 
            // selectoutput_button
            // 
            this.selectoutput_button.Location = new System.Drawing.Point(118, 215);
            this.selectoutput_button.Name = "selectoutput_button";
            this.selectoutput_button.Size = new System.Drawing.Size(203, 29);
            this.selectoutput_button.TabIndex = 10;
            this.selectoutput_button.Text = "Select Folder";
            this.selectoutput_button.UseVisualStyleBackColor = true;
            this.selectoutput_button.Click += new System.EventHandler(this.selectoutput_button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(327, 67);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(737, 351);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // reloadButton
            // 
            this.reloadButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.reloadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reloadButton.BackgroundImage")));
            this.reloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reloadButton.Location = new System.Drawing.Point(1028, 30);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(36, 36);
            this.reloadButton.TabIndex = 13;
            this.reloadButton.UseVisualStyleBackColor = false;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.Location = new System.Drawing.Point(196, 293);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // SelectedItems
            // 
            this.SelectedItems.AutoSize = true;
            this.SelectedItems.Location = new System.Drawing.Point(327, 417);
            this.SelectedItems.Name = "SelectedItems";
            this.SelectedItems.Size = new System.Drawing.Size(109, 20);
            this.SelectedItems.TabIndex = 16;
            this.SelectedItems.Text = "Selected items:";
            // 
            // item_Count_label
            // 
            this.item_Count_label.AutoSize = true;
            this.item_Count_label.Location = new System.Drawing.Point(442, 417);
            this.item_Count_label.Name = "item_Count_label";
            this.item_Count_label.Size = new System.Drawing.Size(0, 20);
            this.item_Count_label.TabIndex = 17;
            // 
            // reduce_size_button
            // 
            this.reduce_size_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reduce_size_button.BackgroundImage")));
            this.reduce_size_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reduce_size_button.Location = new System.Drawing.Point(986, 31);
            this.reduce_size_button.Name = "reduce_size_button";
            this.reduce_size_button.Size = new System.Drawing.Size(36, 36);
            this.reduce_size_button.TabIndex = 18;
            this.reduce_size_button.UseVisualStyleBackColor = true;
            this.reduce_size_button.Click += new System.EventHandler(this.reduce_size_Click);
            // 
            // enlarge_size_button
            // 
            this.enlarge_size_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enlarge_size_button.BackgroundImage")));
            this.enlarge_size_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enlarge_size_button.Location = new System.Drawing.Point(944, 31);
            this.enlarge_size_button.Name = "enlarge_size_button";
            this.enlarge_size_button.Size = new System.Drawing.Size(36, 36);
            this.enlarge_size_button.TabIndex = 19;
            this.enlarge_size_button.UseVisualStyleBackColor = true;
            this.enlarge_size_button.Click += new System.EventHandler(this.enlarge_size_Click);
            // 
            // select_none_button
            // 
            this.select_none_button.Location = new System.Drawing.Point(839, 34);
            this.select_none_button.Name = "select_none_button";
            this.select_none_button.Size = new System.Drawing.Size(99, 29);
            this.select_none_button.TabIndex = 20;
            this.select_none_button.Text = "Select None";
            this.select_none_button.UseVisualStyleBackColor = true;
            this.select_none_button.Click += new System.EventHandler(this.select_None_Click);
            // 
            // select_all_button
            // 
            this.select_all_button.Location = new System.Drawing.Point(734, 34);
            this.select_all_button.Name = "select_all_button";
            this.select_all_button.Size = new System.Drawing.Size(99, 29);
            this.select_all_button.TabIndex = 21;
            this.select_all_button.Text = "Select All";
            this.select_all_button.UseVisualStyleBackColor = true;
            this.select_all_button.Click += new System.EventHandler(this.select_All_Click);
            // 
            // Color_label1
            // 
            this.Color_label1.AutoSize = true;
            this.Color_label1.Location = new System.Drawing.Point(9, 270);
            this.Color_label1.Name = "Color_label1";
            this.Color_label1.Size = new System.Drawing.Size(97, 20);
            this.Color_label1.TabIndex = 22;
            this.Color_label1.Text = "Frame Color :";
            // 
            // frame_size_label
            // 
            this.frame_size_label.AutoSize = true;
            this.frame_size_label.Location = new System.Drawing.Point(9, 330);
            this.frame_size_label.Name = "frame_size_label";
            this.frame_size_label.Size = new System.Drawing.Size(68, 20);
            this.frame_size_label.TabIndex = 23;
            this.frame_size_label.Text = "Position :";
            // 
            // color_preview_textBox1
            // 
            this.color_preview_textBox1.BackColor = System.Drawing.Color.White;
            this.color_preview_textBox1.Location = new System.Drawing.Point(12, 293);
            this.color_preview_textBox1.Name = "color_preview_textBox1";
            this.color_preview_textBox1.Size = new System.Drawing.Size(31, 27);
            this.color_preview_textBox1.TabIndex = 24;
            // 
            // colorName_preview_textBox2
            // 
            this.colorName_preview_textBox2.Location = new System.Drawing.Point(40, 293);
            this.colorName_preview_textBox2.Name = "colorName_preview_textBox2";
            this.colorName_preview_textBox2.Size = new System.Drawing.Size(93, 27);
            this.colorName_preview_textBox2.TabIndex = 25;
            this.colorName_preview_textBox2.Text = "White";
            // 
            // select_color_button1
            // 
            this.select_color_button1.Location = new System.Drawing.Point(134, 293);
            this.select_color_button1.Name = "select_color_button1";
            this.select_color_button1.Size = new System.Drawing.Size(41, 27);
            this.select_color_button1.TabIndex = 26;
            this.select_color_button1.Text = "...";
            this.select_color_button1.UseVisualStyleBackColor = true;
            this.select_color_button1.Click += new System.EventHandler(this.select_color_button1_Click);
            // 
            // image_preview_label1
            // 
            this.image_preview_label1.AutoSize = true;
            this.image_preview_label1.Location = new System.Drawing.Point(196, 270);
            this.image_preview_label1.Name = "image_preview_label1";
            this.image_preview_label1.Size = new System.Drawing.Size(67, 20);
            this.image_preview_label1.TabIndex = 27;
            this.image_preview_label1.Text = "Preview :";
            // 
            // up_button1
            // 
            this.up_button1.Location = new System.Drawing.Point(62, 353);
            this.up_button1.Name = "up_button1";
            this.up_button1.Size = new System.Drawing.Size(25, 25);
            this.up_button1.TabIndex = 28;
            this.up_button1.Text = "△";
            this.up_button1.UseVisualStyleBackColor = true;
            this.up_button1.Click += new System.EventHandler(this.up_button1_Click);
            // 
            // left_button1
            // 
            this.left_button1.Location = new System.Drawing.Point(31, 376);
            this.left_button1.Name = "left_button1";
            this.left_button1.Size = new System.Drawing.Size(25, 25);
            this.left_button1.TabIndex = 29;
            this.left_button1.Text = "◁";
            this.left_button1.UseVisualStyleBackColor = true;
            this.left_button1.Click += new System.EventHandler(this.left_button1_Click);
            // 
            // right_button1
            // 
            this.right_button1.Location = new System.Drawing.Point(93, 376);
            this.right_button1.Name = "right_button1";
            this.right_button1.Size = new System.Drawing.Size(25, 25);
            this.right_button1.TabIndex = 30;
            this.right_button1.Text = "▷";
            this.right_button1.UseVisualStyleBackColor = true;
            this.right_button1.Click += new System.EventHandler(this.right_button1_Click);
            // 
            // down_button1
            // 
            this.down_button1.Location = new System.Drawing.Point(62, 393);
            this.down_button1.Name = "down_button1";
            this.down_button1.Size = new System.Drawing.Size(25, 25);
            this.down_button1.TabIndex = 31;
            this.down_button1.Text = "▽";
            this.down_button1.UseVisualStyleBackColor = true;
            this.down_button1.Click += new System.EventHandler(this.down_button1_Click);
            // 
            // re_pos_button1
            // 
            this.re_pos_button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("re_pos_button1.BackgroundImage")));
            this.re_pos_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.re_pos_button1.Location = new System.Drawing.Point(134, 376);
            this.re_pos_button1.Name = "re_pos_button1";
            this.re_pos_button1.Size = new System.Drawing.Size(25, 25);
            this.re_pos_button1.TabIndex = 32;
            this.re_pos_button1.UseVisualStyleBackColor = true;
            this.re_pos_button1.Click += new System.EventHandler(this.re_pos_button1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1076, 489);
            this.Controls.Add(this.re_pos_button1);
            this.Controls.Add(this.down_button1);
            this.Controls.Add(this.right_button1);
            this.Controls.Add(this.left_button1);
            this.Controls.Add(this.up_button1);
            this.Controls.Add(this.image_preview_label1);
            this.Controls.Add(this.select_color_button1);
            this.Controls.Add(this.colorName_preview_textBox2);
            this.Controls.Add(this.color_preview_textBox1);
            this.Controls.Add(this.frame_size_label);
            this.Controls.Add(this.Color_label1);
            this.Controls.Add(this.select_all_button);
            this.Controls.Add(this.select_none_button);
            this.Controls.Add(this.enlarge_size_button);
            this.Controls.Add(this.reduce_size_button);
            this.Controls.Add(this.item_Count_label);
            this.Controls.Add(this.SelectedItems);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.selectoutput_button);
            this.Controls.Add(this.convert_button);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.outputfolder_textBox);
            this.Controls.Add(this.outputfolder_label);
            this.Controls.Add(this.selectinput_button);
            this.Controls.Add(this.inputfolder_textBox);
            this.Controls.Add(this.inputfolder_Label);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FotoFrame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Label inputfolder_Label;
        private TextBox inputfolder_textBox;
        private Button selectinput_button;
        private Label outputfolder_label;
        private TextBox outputfolder_textBox;
        private ProgressBar progressBar1;
        private Button convert_button;
        private Button selectoutput_button;
        private ToolStripMenuItem exitToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button reloadButton;
        private PictureBox pictureBox1;
        private Label SelectedItems;
        private Label item_Count_label;
        private Button reduce_size_button;
        private Button enlarge_size_button;
        private Button select_none_button;
        private Button select_all_button;
        private Label Color_label1;
        private Label frame_size_label;
        private TextBox color_preview_textBox1;
        private TextBox colorName_preview_textBox2;
        private Button select_color_button1;
        private Label image_preview_label1;
        private Button up_button1;
        private Button left_button1;
        private Button right_button1;
        private Button down_button1;
        private Button re_pos_button1;
        private ToolStripMenuItem aboutToolStripMenuItem1;
    }
}