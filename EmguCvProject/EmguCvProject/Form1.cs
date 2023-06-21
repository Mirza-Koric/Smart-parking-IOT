using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp;

namespace EmguCvProject
{
    public partial class Form1 : Form
    {

        Image<Bgr, byte> image;
        public static int broj = 0;
        static Random r = new Random();


        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "ts2xXKPWCa4LUOAhGnjTpEV8YYCDw2sLE32bmiKR",
            BasePath = "https://parking-5f5fb-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }

        static System.Timers.Timer timer = new System.Timers.Timer(10000);


        public void Timer()
        {
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Interval = 4000;
            timer.Enabled = false;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            broj = r.Next(1, 100);
            SetText(broj.ToString());
            var setter = client.Set("Number/number", broj);
        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            if (this.lblBroj.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lblBroj.Text = text;
            }
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog Opfile = new OpenFileDialog();
            if (DialogResult.OK == Opfile.ShowDialog())
            {
                image = new Image<Bgr, byte>(Opfile.FileName);

                picInput.Image = image.ToBitmap();
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            broj = 0;

            this.Size = new Size(1350, 650);

            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat hier = new Mat();

            image._SmoothGaussian(3);

            Image<Gray, byte> slika3 = image.Convert<Gray, byte>().ThresholdBinary(new Gray(160), new Gray(255));


            slika3 = slika3.Not();

            CvInvoke.FindContours(slika3, contours, hier, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);


            for (int i = 0; i < contours.Size; i++)
            {
                Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);


                if (rect.Width >= 30 && rect.Height >= 30)
                {
                    image.Draw(rect, new Bgr(0, 255, 0));

                    int cx = rect.Width / 2;
                    int cy = rect.Height / 2;

                    Point center = new Point(rect.X + cx, rect.Y + cy);

                    CvInvoke.Circle(image, center, 3, new MCvScalar(0, 0, 255), 3);

                    broj++;
                }
            }
            lblBroj.Text = broj.ToString();


            CvInvoke.DrawContours(image, contours, -1, new MCvScalar(255, 0, 0));

            picOutput.Image = image.ToBitmap();

            picOutput2.Image = slika3.ToBitmap();
            SendData();
        }

        private void btnConvert2_Click(object sender, EventArgs e)
        {
            broj = 0;

            this.Size = new Size(1350, 650);

            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat hier = new Mat();

            //image._SmoothGaussian(3);

            Image<Gray, byte> slika3 = image.Convert<Gray, byte>().ThresholdBinary(new Gray(80), new Gray(255));


            slika3 = slika3.Not();

            CvInvoke.FindContours(slika3, contours, hier, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);




            for (int i = 0; i < contours.Size; i++)
            {
                Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);


                if (rect.Width >= 100 && rect.Height >= 100)
                {
                    image.Draw(rect, new Bgr(0, 255, 0), 3);

                    int cx = rect.Width / 2;
                    int cy = rect.Height / 2;

                    Point center = new Point(rect.X + cx, rect.Y + cy);

                    CvInvoke.Circle(image, center, 3, new MCvScalar(0, 0, 255), 3);

                    broj++;
                }
            }
            lblBroj.Text = broj.ToString();


            CvInvoke.DrawContours(image, contours, -1, new MCvScalar(255, 0, 0));

            picOutput.Image = image.ToBitmap();

            picOutput2.Image = slika3.ToBitmap();
            SendData();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Timer();
            timer.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch (Exception)
            {

                MessageBox.Show("there was a problem with firebase connection");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendData();
        }

        private void SendData()
        {
            client.Set("Number/number", broj);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            var result = client.Get("Number/number");

            lblBroj.Text = result.ResultAs<string>();
        }



        private void btnEdgeDetection_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1350, 650);
            broj = 0;

            Image<Bgr, byte> copy = image.Clone();

            copy._SmoothGaussian(9);       

            Image<Gray, byte> imageCanny = new Image<Gray, byte>(copy.Width, copy.Height,new Gray(0));
            imageCanny = copy.Canny((double)numericUpDown1.Value, (double)numericUpDown2.Value);
            //picOutput.Image = imageCanny.ToBitmap();


            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat hier = new Mat();


            CvInvoke.FindContours(imageCanny, contours, hier, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);


            for (int i = 0; i < contours.Size; i++)
            {
                Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);


                if (rect.Width >= CarWidth.Value && rect.Height >= CarHeight.Value)
                {
                    copy.Draw(rect, new Bgr(0, 255, 0));

                    int cx = rect.Width / 2;
                    int cy = rect.Height / 2;

                    Point center = new Point(rect.X + cx, rect.Y + cy);

                    CvInvoke.Circle(copy, center, 3, new MCvScalar(0, 0, 255), 3);

                    broj++;
                }
            }
            lblBroj.Text = broj.ToString();


            picOutput.Image = copy.ToBitmap();

            picOutput2.Image = imageCanny.ToBitmap();
            SendData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.Set("Change/color", 1);
        }
    }
}

// parameters: 150, 110; 25, 20  -  1, 2
// parameters: 250, 250; 25, 20  -  3
// parameters: 170, 140; 30, 30  -  4


//1 - 58
//2 - 24(8)
//3 - 208
//4 - 24(7)