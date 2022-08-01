using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;
using System;
using System.Windows;
using System.Collections;
using static FotoFrame.imageProcess;


namespace FotoFrame
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }
        //default size
        private static int default_length = 150;
        
        private int user_length = 150;

        //for reducing the size of images when loading into the flowlayoutpanel, it does not affect the quality of final output images
        private static int thumbnail_factor = 10; 
      
        public string folderPath = "";
        public string inputFolderPath = "";
        public string outputFolderPath = "";
        
        private Image[] imageList_thumb;
        private FileInfo[] imagesPath;
        private PictureBox[] pic;
        private Label[] pic_name;
        private CheckBox[] pic_select;

        private int item_Count = 0;
        //image of preview
        Image preview_img = FotoFrame.Properties.Resources.DSCF2816_min;

        //default frame color : white
        public Color user_selectColor = Color.White;
        
        //creating process object
        imageProcess processingTool = new imageProcess();
        private int posX_adjust = 0;
        private int posY_adjust = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.item_Count_label.Text = item_Count.ToString();
            preview_img = preview_img.GetThumbnailImage(preview_img.Width / thumbnail_factor, preview_img.Height / thumbnail_factor, () => false, IntPtr.Zero);
            processingTool.set_preview_ratio(preview_img);
            Preview();
        }
        
        /*
         * select output folder button event
         * 
         * */
        private void selectoutput_button_Click(object sender, EventArgs e)
        {
            outputfolder_textBox.Text = openDialog();
            outputFolderPath = outputfolder_textBox.Text;
        }
        /*
         * select iutput folder button event
         * 
         * */
        private void selectinput_button_Click(object sender, EventArgs e)
        {
            inputfolder_textBox.Text = openDialog();
            inputFolderPath = inputfolder_textBox.Text;
            if (inputFolderPath != String.Empty)
            {
                
                Load_directory(inputFolderPath);
                LoadImage(default_length);
                if (pic.Length == 0)
                {
                    System.Windows.MessageBox.Show(pic.Length + " phtots was loaded, please check the content of input folder");
                }
                else
                {
                    System.Windows.MessageBox.Show(pic.Length + " phtots was loaded");
                }
            }
            
        }
        /*
         * About page event
         * open "About FotoFrame" form
         * */
        private void Aboutpage_button_Click(object sender, EventArgs e)
        {
            AboutPage newAboutpage = new AboutPage();
            newAboutpage.Show();
        }
        /*
         * functions for opening dialog can select folder
         * 
         * return: Filepath of selected folder
         * */
        private string openDialog()
        {   
            CommonOpenFileDialog inputFileDialog1 = new CommonOpenFileDialog();

            inputFileDialog1.IsFolderPicker = true;
            inputFileDialog1.DefaultDirectory = @"C:\";
            inputFileDialog1.RestoreDirectory = true;
            if (inputFileDialog1.ShowDialog() == CommonFileDialogResult.Ok)
            {
                folderPath = inputFileDialog1.FileName;               
            }
            else
            {
               return String.Empty;
            }
            return folderPath;
        }
        /*
         * function for loading the directory
         * storing imagesPath and Images data to array
         * 
         * parameter: directory path (string)
         * 
         */
        private void Load_directory(string diPath)
        {
            Image_load img_load = new Image_load();
            
            string[] extensions = new[] { ".jpg", ".jpeg", ".png" };
           
            DirectoryInfo di = new DirectoryInfo(diPath);
                                   
            imagesPath = di.GetFiles()
                .Where(f => extensions.Contains(f.Extension.ToLower()))
                .ToArray();
            imageList_thumb = new Image[imagesPath.Length];
            img_load.max_set(imagesPath.Length);
            
            pic = new PictureBox[imagesPath.Length];
            pic_name = new Label[imagesPath.Length];
            pic_select = new CheckBox[imagesPath.Length];
           
            
            img_load.Show();
            for (int i = 0; i < imagesPath.Length; i++)
            {
                img_load.change_event(imagesPath[i].Name);
                
                Image image_i = Image.FromFile(imagesPath[i].ToString());
                
                imageList_thumb[i] = image_i.GetThumbnailImage(image_i.Width/thumbnail_factor, image_i.Height / thumbnail_factor, () => false, IntPtr.Zero);
                
                image_i.Dispose();
                
            }
            img_load.Close();
            GC.Collect();
        }
        /*
         * function for loading images from Image array and display in flowlayoutpanel
         * 
         * parameters: picturebox length (int)
         * 
         */
        private void LoadImage(int length)
        {
            
            flowLayoutPanel1.Padding = new Padding(5);
            for (int i = 0; i < imagesPath.Length;i++)
            {
                //create picturebox for images
                pic[i] = new PictureBox();
                pic[i].Width = length;
                pic[i].Height = length;
                //configuration of picturebox
                pic[i].BackgroundImageLayout = ImageLayout.Stretch;
                pic[i].SizeMode = PictureBoxSizeMode.Zoom;
                pic[i].BorderStyle = BorderStyle.None;
                pic[i].Margin = new Padding(10,1,10,1);
                pic[i].Tag = imagesPath[i].FullName.ToString();
                pic[i].Name = i.ToString();
                //create file name label
                pic_name[i] = new Label();
                pic_name[i].Text = imagesPath[i].Name.ToString();
                pic_name[i].Dock = DockStyle.Bottom;
                pic_name[i].TextAlign = ContentAlignment.MiddleCenter;
                //create checkbox
                pic_select[i] = new CheckBox();
                pic_select[i].Text = "";
                pic_select[i].AutoCheck = false;
                pic_select[i].Visible = false;
                pic_select[i].Name = i.ToString();
              

                //insert images in picturebox
                
                pic[i].Image = imageList_thumb[i];
                
                //add file name and checkbox in each picturebox
                pic[i].Controls.Add(pic_name[i]);
                pic[i].Controls.Add(pic_select[i]);
                
                //add picturebox to flowlayoutpanel
                flowLayoutPanel1.Controls.Add(pic[i]);
                pic[i].Click += new EventHandler(picbox_Click);
                pic[i].MouseEnter += new EventHandler(MouseEnter_event);
                pic[i].MouseLeave += new EventHandler(MouseLeave_event);
                                              
            }
          
                
        }
        /*
         * function setting the size of photos in flowlayoutpanel
         * param: int length;
         */
       
        private void change_size(int user_length)
        {
            for (int i = 0; i < imagesPath.Length; i++)
            {
                pic[i].Width = user_length;
                pic[i].Height = user_length;
                
            }
        }
        /*
         * event when cursor enter the picturebox
         */
        private void MouseEnter_event (object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.MintCream;
            
        }
        /*
         * event when cursor leave the picturebox
         */
        private void MouseLeave_event (object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Transparent;
        }
        /*
         * event when user clicked the picturebox,
         * i.e. select the target image
         */
         
        private void picbox_Click(object sender,EventArgs e)
        {

            int pic_num = Int32.Parse(((PictureBox)sender).Name);
            if (((CheckBox)pic_select[pic_num]).Checked == false)
            {
                ((CheckBox)pic_select[pic_num]).Checked = true;
                ((CheckBox)pic_select[pic_num]).Visible = true;
                item_Count++;
            }
            else
            {
                ((CheckBox)pic_select[pic_num]).Checked = false;
                ((CheckBox)pic_select[pic_num]).Visible = false;
                item_Count--;
            }
            this.item_Count_label.Text = item_Count.ToString();

        }
        /*
         * select all images
         */
        private void select_All_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < imagesPath.Length; i++)
            {
                ((CheckBox)pic_select[i]).Checked = true;
                ((CheckBox)pic_select[i]).Visible = true;
            }
            item_Count = imagesPath.Length;
            this.item_Count_label.Text = item_Count.ToString();
        }
        /*
         * select no images
         */
        private void select_None_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < imagesPath.Length; i++)
            {
                ((CheckBox)pic_select[i]).Checked = false;
                ((CheckBox)pic_select[i]).Visible = false;
            }
            item_Count = 0;
            this.item_Count_label.Text = item_Count.ToString();
        }
       

        /*
         * enlarge button event
         */
        private void enlarge_size_Click(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Controls.Clear();
            user_length += 40;                       
            
            change_size(user_length);
        }
        /*
         * reduce button event
         */
        private void reduce_size_Click (object sender ,EventArgs e)
        {
           
            
            user_length -= 40;
            
            change_size(user_length);
        }
        /*
         * reload the images on the flowlayoutpanel
         */
        private void reloadButton_Click(object sender, EventArgs e)
        {
            
            flowLayoutPanel1.Controls.Clear();
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                control.Dispose();
            }            
            GC.Collect();
            try
            {
                Load_directory(inputFolderPath);
                LoadImage(default_length);
            }
            catch 
            {
                System.Windows.Forms.MessageBox.Show("No folder is selected");
            }
            finally
            {
                user_length = default_length;
            }
        }
        /*
         * Convert button event, start processing the images
         */
        private void Convert_button_Click (object sender, EventArgs e)
        {
            bool valid_check = true;
            int select_num = 0;
            progressBar1.Maximum = item_Count;
            progressBar1.Minimum = 0;
            string TargetImagePath = "";            
            for (int i = 0; i< imageList_thumb.Length; i++)
            {
                if (((CheckBox) pic_select[i]).Checked == true)
                {
                    select_num++;
                    //create a temp processed image
                    Image temp = processingTool.AddFrame(Image.FromFile(imagesPath[i].ToString()),posX_adjust,posY_adjust, false);
                    
                    //check whether output path is selected
                    if (outputFolderPath == String.Empty)
                    {
                        valid_check = false;
                        System.Windows.Forms.MessageBox.Show("Output folder is empty, Please try again.");
                        break;
                    }
                    //if output path available, create the new image path
                    TargetImagePath = outputFolderPath + "/" + Path.GetFileNameWithoutExtension(imagesPath[i].Name) + "_FotoFrame";
                    progressBar1.Value += 1;
                    progressBar1.Refresh();
                    if (!(IMG_save(temp, imagesPath[i].Extension.ToString(), TargetImagePath, valid_check)))
                    {
                        break;
                    }
                    temp.Dispose();
                    GC.Collect();
                }                              
            }
            if (select_num <= 0)
            {
                System.Windows.Forms.MessageBox.Show("No photos are selected");
            }
            else if (valid_check)
            {
                System.Windows.Forms.MessageBox.Show("Done");
            }            
            progressBar1.Value = 0;
            
        }     
        /*
         * function for saving the new image in folder
         * 
         * params: Image, extension(string), target path(string), flag (bool)
         * 
         * return: result flag (bool)
         */
        private bool IMG_save(Image img, string extension, string savePath, bool check)
        {
           //save the new files according to the format of original
           //default : *.bmp
            switch (extension)
            {
                case ".jpg":
                case ".jpeg":
                    try
                    {
                        img.Save(savePath+".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        check = false;
                        System.Windows.Forms.MessageBox.Show("Output folder is Invalid, Please try again.");
                    }
                    break;
                case ".png":
                    try
                    {
                        img.Save(savePath+".png", System.Drawing.Imaging.ImageFormat.Png);
                    }
                    catch
                    {
                        check = false;
                        System.Windows.Forms.MessageBox.Show("Output folder is Invalid, Please try again.");
                    }
                    break;

                default:
                    try
                    {
                        img.Save(savePath+".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                    }
                    catch
                    {
                        check = false;
                        System.Windows.Forms.MessageBox.Show("Output folder is Invalid, Please try again.");
                    }
                    break;

            }
            
            return check;
        }
        /*
         * 
         * fucntion for showing preview box
         */
        
        private void Preview()
        {
            //temp processed image for preview
            Image img = processingTool.AddFrame(preview_img, posX_adjust, posY_adjust, true);
            
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }
            this.pictureBox1.Image = img;
            GC.Collect();
            
        }
        
        
        /*
         * fucntion for selecting frame color
         * 
         */
        private void select_color_button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
             
                color_preview_textBox1.BackColor = colorDialog1.Color;
                colorName_preview_textBox2.Text = colorDialog1.Color.Name.ToString();
                processingTool.set_Color(colorDialog1.Color);
                user_selectColor = colorDialog1.Color;
            }
            Preview();
        }
        /*
         * series of functions for controling the postion of photos
         */
       
        private void up_button1_Click(object sender, EventArgs e)
        {
            posY_adjust -= 5;
            Preview();
        }

        private void down_button1_Click(object sender, EventArgs e)
        {
            posY_adjust += 5;
            Preview();
        }

        private void left_button1_Click(object sender, EventArgs e)
        {
            posX_adjust -= 5;
            Preview();
        }

        private void right_button1_Click(object sender, EventArgs e)
        {
            posX_adjust += 5;
            Preview();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                posY_adjust -= 5;
                Preview();
            }
            else if (keyData == Keys.Down)
            {
                posY_adjust += 5;
                Preview();
            }
            else if (keyData == Keys.Left)
            {
                posX_adjust -= 5;
                Preview();
            }
            else if (keyData == Keys.Right)
            {
                posX_adjust += 5;
                Preview();
            }
            else if (keyData == Keys.Home)
            {
                posX_adjust = 0;
                posY_adjust = 0;
                Preview();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        /*
         * reset the position
         */
        private void re_pos_button1_Click(object sender, EventArgs e)
        {
            posX_adjust = 0;
            posY_adjust = 0;
            Preview();
        }
        /*
         * exit
         */
        private void Exit(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
                
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }
    }
}