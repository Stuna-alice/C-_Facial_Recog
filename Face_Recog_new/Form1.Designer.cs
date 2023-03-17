
namespace Face_Recog_new
{
    partial class Form1
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
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnDetectFace = new System.Windows.Forms.Button();
            this.txt_BoxName = new System.Windows.Forms.TextBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnTrainImage = new System.Windows.Forms.Button();
            this.btnFaceRecognition = new System.Windows.Forms.Button();
            this.picDetected = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).BeginInit();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.Location = new System.Drawing.Point(28, 46);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(419, 356);
            this.picCapture.TabIndex = 0;
            this.picCapture.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(521, 12);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(202, 46);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnDetectFace
            // 
            this.btnDetectFace.Location = new System.Drawing.Point(521, 64);
            this.btnDetectFace.Name = "btnDetectFace";
            this.btnDetectFace.Size = new System.Drawing.Size(202, 42);
            this.btnDetectFace.TabIndex = 2;
            this.btnDetectFace.Text = "Detect Face";
            this.btnDetectFace.UseVisualStyleBackColor = true;
            this.btnDetectFace.Click += new System.EventHandler(this.btnDetectFace_Click);
            // 
            // txt_BoxName
            // 
            this.txt_BoxName.Location = new System.Drawing.Point(521, 272);
            this.txt_BoxName.Name = "txt_BoxName";
            this.txt_BoxName.Size = new System.Drawing.Size(202, 20);
            this.txt_BoxName.TabIndex = 3;
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(521, 112);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(202, 46);
            this.btnAddPerson.TabIndex = 4;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnTrainImage
            // 
            this.btnTrainImage.Location = new System.Drawing.Point(521, 356);
            this.btnTrainImage.Name = "btnTrainImage";
            this.btnTrainImage.Size = new System.Drawing.Size(202, 46);
            this.btnTrainImage.TabIndex = 5;
            this.btnTrainImage.Text = "Train Image";
            this.btnTrainImage.UseVisualStyleBackColor = true;
            // 
            // btnFaceRecognition
            // 
            this.btnFaceRecognition.Location = new System.Drawing.Point(521, 403);
            this.btnFaceRecognition.Name = "btnFaceRecognition";
            this.btnFaceRecognition.Size = new System.Drawing.Size(202, 46);
            this.btnFaceRecognition.TabIndex = 6;
            this.btnFaceRecognition.Text = "Face Recognition";
            this.btnFaceRecognition.UseVisualStyleBackColor = true;
            // 
            // picDetected
            // 
            this.picDetected.Location = new System.Drawing.Point(521, 164);
            this.picDetected.Name = "picDetected";
            this.picDetected.Size = new System.Drawing.Size(202, 102);
            this.picDetected.TabIndex = 7;
            this.picDetected.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
          
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picDetected);
            this.Controls.Add(this.btnFaceRecognition);
            this.Controls.Add(this.btnTrainImage);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.txt_BoxName);
            this.Controls.Add(this.btnDetectFace);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.picCapture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnDetectFace;
        private System.Windows.Forms.TextBox txt_BoxName;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnTrainImage;
        private System.Windows.Forms.Button btnFaceRecognition;
        private System.Windows.Forms.PictureBox picDetected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSaveImage;
    }
}

