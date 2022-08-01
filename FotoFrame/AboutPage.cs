using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace FotoFrame
{
    public partial class AboutPage : Form
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                openUrl("https://github.com/CheungKW0301");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                linkLabel1.LinkVisited = true;
            }
        }

        private void openUrl (String url)
        {
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
        
    }
}
