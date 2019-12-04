using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {

        VideoCaptureDevice frame;
        FilterInfoCollection Devices;

        public Form2()
        {
            InitializeComponent();
        }

        void Start_cam()
        {
            Devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            frame = new VideoCaptureDevice(Devices[0].MonikerString);
            frame.NewFrame += new AForge.Video.NewFrameEventHandler(NewFrame_event);
            frame.Start();
        }
        string output;
        void NewFrame_event(object send, NewFrameEventArgs e)
        {
            try
            {
                pictureBox1.Image = (Image)e.Frame.Clone();
            }
            catch (Exception ex) { }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void strtbtn_Click(object sender, EventArgs e)
        {
            Start_cam();
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            frame.Stop();
            pictureBox1.Image = null;
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }
    }
}
