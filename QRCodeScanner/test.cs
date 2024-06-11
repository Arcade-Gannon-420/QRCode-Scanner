using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeScanner
{
    public partial class test : Form
    {
        private Size formOriginalSize;
        private Rectangle recBut1;
        private Rectangle recTxt1;
        private Rectangle recPnl1;
        private Rectangle recRdo1;
        public test()
        {
            InitializeComponent();
            this.Resize += test_Resiz;
            formOriginalSize = this.Size;

            // Capture initial sizes and locations of controls
            recBut1 = new Rectangle(button1.Location, button1.Size);
            recTxt1 = new Rectangle(textBox1.Location, textBox1.Size);
            recPnl1 = new Rectangle(panel1.Location, panel1.Size);
            recRdo1 = new Rectangle(radioButton1.Location, radioButton1.Size);
            textBox1.Multiline = true;
        }
        private void test_Resiz(object sender, EventArgs e)
        {
            // Resize controls during form resize event
            resize_Control(button1, recBut1);
            resize_Control(textBox1, recTxt1);
            resize_Control(panel1, recPnl1);
            resize_Control(radioButton1, recRdo1);
        }

        private void resize_Control(System.Windows.Forms.Control c, Rectangle r)
        {
            // Calculate new size and location based on form's new size
            float xRatio = (float)this.Width / formOriginalSize.Width;
            float yRatio = (float)this.Height / formOriginalSize.Height;

            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);
            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            // Update the control's location and size
            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }
    }
}