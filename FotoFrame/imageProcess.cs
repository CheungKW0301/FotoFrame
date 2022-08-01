using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;

namespace FotoFrame
{
    
    internal class imageProcess
    {
        
        Color color;

        private int preview_width;
        private int preview_height;
        //constructor, default color is white if not specificed by the user
        public imageProcess()
        {
            color = Color.White;
        }
        //overloaded constructor with specific color
        public imageProcess(Color c)
        {
            color = c;
        }
        public void set_Color(Color c)
        {
            color = c;
        }
        public int get_Color()
        {
            return int.Parse(colorToHex(this.color));
        }
        private string colorToHex (Color c)
        {
            return ColorTranslator.ToHtml(c);
        }

        public void set_preview_ratio (Image preview_img)
        {
            this.preview_width = preview_img.Width;
            this.preview_height = preview_img.Height;
        }
        /*
         * method for adding Frame to image
         * The image will be defautly in the center
         * 
         * parameter: (image)
         */
        public Image AddFrame(Image targetIMG,bool preview_check)
        {
            int IMGwidth = targetIMG.Width;
            int IMGheight = targetIMG.Height;
            
            int max_length = IMGwidth > IMGheight ? IMGwidth : IMGheight;

            double frame_length = (max_length*0.05) * 2 + max_length;

            Bitmap new_IMG = new Bitmap((int)frame_length,(int)frame_length);
            Graphics g = Graphics.FromImage(new_IMG);
            Brush brush = new SolidBrush(color);

            g.FillRectangle(brush, 0, 0, (float)frame_length, (float)frame_length);

            g.DrawImage(targetIMG, get_DrawposX(IMGwidth,frame_length), get_DrawposY(IMGheight, frame_length), IMGwidth,IMGheight);

            return new_IMG;
        }
        /*
         * overloaded method of "AddFrame"
         * for moving image around the frame
         * 
         * parameter: (Image, x_step, y_step)
         */
        public Image AddFrame(Image targetIMG, int x_step, int y_step, bool preview_check)
        {
            int IMGwidth = targetIMG.Width;
            int IMGheight = targetIMG.Height;
            
            int img_posX = preview_check? x_step : IMGwidth * x_step / preview_width;
            int img_posY = preview_check ? y_step : IMGwidth * y_step / preview_height;
            int max_length = IMGwidth > IMGheight ? IMGwidth : IMGheight;

            double frame_length = (max_length * 0.05) * 2 + max_length;

            Bitmap new_IMG = new Bitmap((int)frame_length, (int)frame_length);
            Graphics g = Graphics.FromImage(new_IMG);
            Brush brush = new SolidBrush(color);

            g.FillRectangle(brush, 0, 0, (float)frame_length, (float)frame_length);

            g.DrawImage(targetIMG, get_DrawposX(IMGwidth, frame_length) + img_posX, get_DrawposY(IMGheight, frame_length) + img_posY, IMGwidth, IMGheight);

            return new_IMG;
        }
        
        /*
         * method for calculating the x_coor of drawing pos
         * 
         * parameters: image width, frame length
         */
        private int get_DrawposX (int width, double length)
        {
            
            return (int)length /2 - width/2;
        }
        /*
        * method for calculating the y_coor of drawing pos
        * 
        * parameters: image height, frame length
        */
        private int get_DrawposY (int height, double length)
        {
            
            return (int)length / 2 - height / 2;
        }

    }
}
