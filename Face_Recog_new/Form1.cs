using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO;
using System.Threading.Tasks;
using System.Threading;



namespace Face_Recog_new
{
    public partial class Form1 : Form
    {
        private Capture videoCapture = null;
        private Image<Bgr, Byte> currentFrame = null;

        //vide capture frame by frame
        Mat frame = new Mat();

        private bool faceDectectionEnabled = false;


        List<int> PersonLabels = new List<int>();
        bool EnableSaveimage = false;

        CascadeClassifier faceCascade = new CascadeClassifier("haarcascade_frontalface_alt.xml");

        public Form1()
        {
            InitializeComponent();
        }



        private void btnCapture_Click(object sender, EventArgs e)
        {
            videoCapture = new Capture();
            videoCapture.ImageGrabbed += ProcessFrame;
            videoCapture.Start();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            //Step 1: video Capture on the first frame 0
            videoCapture.Retrieve(frame, 0);

            //resize image in the picCapture screen
            currentFrame = frame.ToImage<Bgr, Byte>().Resize(picCapture.Width, picCapture.Height, Inter.Cubic);

            //Step 2: Detect Face
            if (faceDectectionEnabled)
            {
                //Convert Colored image to Grey Image
                Mat grayImage = new Mat();
                CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                //echance image to get better result
                CvInvoke.EqualizeHist(grayImage, grayImage);

                Rectangle[] faces = faceCascade.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
                //if face detected
                if (faces.Length > 0)
                {

                    foreach (var face in faces)
                    {
                        //Draw bounding box in the face
                        CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);

                        //Step 3 : add person
                        //Assign face to the picture box when captured
                        Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                        resultImage.ROI = face;

                        // When captured image display
                        picDetected.SizeMode = PictureBoxSizeMode.StretchImage;
                        picDetected.Image = resultImage.Bitmap;

                        if (EnableSaveimage)
                        {
                            //this will create a directory if folder image does not exist
                            string path = Directory.GetCurrentDirectory() + @"\Trained_Images_Mitsumi";
                            if (Directory.Exists(path))
                            {
                                Directory.CreateDirectory(path);


                                //Delay 
                                //to avoud GUI hang use another task

                                Task.Factory.StartNew(() =>
                                {

                                    //
                                    //Save 10 images for accurracy
                                    //
                                    for (int i = 0; i < 10; i++)
                                    {
                                        //resize the image then saving to the Path
                                        //Image is in JPG format
                                        resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + txt_BoxName.Text + "_" + ".jpg");
                                        //10 sec delay
                                        Thread.Sleep(1000);
                                    }

                                });


                            }

                        }

                    }
                }

            }

            //Render the video capture into Picture Box, picCapture
            picCapture.Image = currentFrame.Bitmap;


        }

        private void btnDetectFace_Click(object sender, EventArgs e)
        {
            //switch
            faceDectectionEnabled = true;

        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {

            // SAve image
            btnSaveImage.Enabled = true;
            btnAddPerson.Enabled = false;
            EnableSaveimage = true;
        }

    }
}
