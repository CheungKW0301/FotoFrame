using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoFrame
{
    public partial class Image_load : Form
    {
        private int index = 0;
        private float percentage;
        public Image_load()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            file_name_label.Text = "";
            prog_num.Text = "0 %";
        }
        public void max_set (int max_length)
        {
            progressBar1.Maximum = max_length;
        }
        public void change_event (string filename)
        {
            index++;
            percentage = (int)Math.Round((float)(100 * index) / progressBar1.Maximum);

            
            progressBar1.Value++;
            file_name_label.Text = filename;
            prog_num.Text = percentage.ToString() + " %";
            file_name_label.Refresh();
            progressBar1.Refresh();
            prog_num.Refresh();

        }
       
    }
}
