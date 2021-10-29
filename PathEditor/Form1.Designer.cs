
namespace PathEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Map = new System.Windows.Forms.PictureBox();
            this.DetectingAndSaving = new System.Windows.Forms.GroupBox();
            this.SavePoints = new System.Windows.Forms.Button();
            this.DetectPoints = new System.Windows.Forms.Button();
            this.HeightGroupBox = new System.Windows.Forms.GroupBox();
            this.ApplyHeight = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.SpecifiedHeightGroupBox = new System.Windows.Forms.GroupBox();
            this.ZCoord = new System.Windows.Forms.TextBox();
            this.PointNumber = new System.Windows.Forms.TextBox();
            this.ApplySpecHeight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).BeginInit();
            this.DetectingAndSaving.SuspendLayout();
            this.HeightGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SpecifiedHeightGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Map
            // 
            this.Map.Image = ((System.Drawing.Image)(resources.GetObject("Map.Image")));
            this.Map.Location = new System.Drawing.Point(0, 0);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(600, 600);
            this.Map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Map.TabIndex = 0;
            this.Map.TabStop = false;
            // 
            // DetectingAndSaving
            // 
            this.DetectingAndSaving.Controls.Add(this.SavePoints);
            this.DetectingAndSaving.Controls.Add(this.DetectPoints);
            this.DetectingAndSaving.Location = new System.Drawing.Point(606, 12);
            this.DetectingAndSaving.Name = "DetectingAndSaving";
            this.DetectingAndSaving.Size = new System.Drawing.Size(140, 108);
            this.DetectingAndSaving.TabIndex = 1;
            this.DetectingAndSaving.TabStop = false;
            this.DetectingAndSaving.Text = "Detecting and saving";
            // 
            // SavePoints
            // 
            this.SavePoints.Enabled = false;
            this.SavePoints.Location = new System.Drawing.Point(6, 57);
            this.SavePoints.Name = "SavePoints";
            this.SavePoints.Size = new System.Drawing.Size(128, 32);
            this.SavePoints.TabIndex = 1;
            this.SavePoints.Text = "Save points";
            this.SavePoints.UseVisualStyleBackColor = true;
            this.SavePoints.Click += new System.EventHandler(this.SavePoints_Click);
            // 
            // DetectPoints
            // 
            this.DetectPoints.Location = new System.Drawing.Point(6, 19);
            this.DetectPoints.Name = "DetectPoints";
            this.DetectPoints.Size = new System.Drawing.Size(128, 32);
            this.DetectPoints.TabIndex = 0;
            this.DetectPoints.Text = "Detect points";
            this.DetectPoints.UseVisualStyleBackColor = true;
            this.DetectPoints.Click += new System.EventHandler(this.DetectPoints_Click);
            // 
            // HeightGroupBox
            // 
            this.HeightGroupBox.Controls.Add(this.ApplyHeight);
            this.HeightGroupBox.Controls.Add(this.trackBar1);
            this.HeightGroupBox.Location = new System.Drawing.Point(606, 126);
            this.HeightGroupBox.Name = "HeightGroupBox";
            this.HeightGroupBox.Size = new System.Drawing.Size(140, 301);
            this.HeightGroupBox.TabIndex = 2;
            this.HeightGroupBox.TabStop = false;
            this.HeightGroupBox.Text = "Set whole height to 30";
            // 
            // ApplyHeight
            // 
            this.ApplyHeight.Enabled = false;
            this.ApplyHeight.Location = new System.Drawing.Point(54, 19);
            this.ApplyHeight.Name = "ApplyHeight";
            this.ApplyHeight.Size = new System.Drawing.Size(80, 34);
            this.ApplyHeight.TabIndex = 1;
            this.ApplyHeight.Text = "Apply height";
            this.ApplyHeight.UseVisualStyleBackColor = true;
            this.ApplyHeight.Click += new System.EventHandler(this.ApplyHeight_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 16);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 281);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(60, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(76, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(92, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(108, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(124, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(140, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(156, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(28, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(44, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 12);
            this.label13.TabIndex = 15;
            this.label13.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(60, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 12);
            this.label14.TabIndex = 16;
            this.label14.Text = "1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(76, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 12);
            this.label15.TabIndex = 17;
            this.label15.Text = "1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(92, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(10, 12);
            this.label16.TabIndex = 18;
            this.label16.Text = "1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(108, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(10, 12);
            this.label17.TabIndex = 19;
            this.label17.Text = "1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(124, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(10, 12);
            this.label18.TabIndex = 20;
            this.label18.Text = "1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(140, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(10, 12);
            this.label19.TabIndex = 21;
            this.label19.Text = "1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(156, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(10, 12);
            this.label20.TabIndex = 22;
            this.label20.Text = "1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(12, 51);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(10, 12);
            this.label21.TabIndex = 23;
            this.label21.Text = "1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(28, 51);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(10, 12);
            this.label22.TabIndex = 24;
            this.label22.Text = "1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(44, 51);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(10, 12);
            this.label23.TabIndex = 25;
            this.label23.Text = "1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(60, 51);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(10, 12);
            this.label24.TabIndex = 26;
            this.label24.Text = "1";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(76, 51);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(10, 12);
            this.label25.TabIndex = 27;
            this.label25.Text = "1";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(92, 51);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(10, 12);
            this.label26.TabIndex = 28;
            this.label26.Text = "1";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(108, 51);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(10, 12);
            this.label27.TabIndex = 29;
            this.label27.Text = "1";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.Location = new System.Drawing.Point(124, 51);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(10, 12);
            this.label28.TabIndex = 30;
            this.label28.Text = "1";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(140, 51);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(10, 12);
            this.label29.TabIndex = 31;
            this.label29.Text = "1";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.Location = new System.Drawing.Point(156, 51);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(10, 12);
            this.label30.TabIndex = 32;
            this.label30.Text = "1";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.Location = new System.Drawing.Point(12, 80);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(10, 12);
            this.label31.TabIndex = 33;
            this.label31.Text = "1";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.Location = new System.Drawing.Point(28, 80);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(10, 12);
            this.label32.TabIndex = 34;
            this.label32.Text = "1";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.Location = new System.Drawing.Point(44, 80);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(10, 12);
            this.label33.TabIndex = 35;
            this.label33.Text = "1";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.Location = new System.Drawing.Point(60, 80);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(10, 12);
            this.label34.TabIndex = 36;
            this.label34.Text = "1";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label35.Location = new System.Drawing.Point(76, 80);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(10, 12);
            this.label35.TabIndex = 37;
            this.label35.Text = "1";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label36.Location = new System.Drawing.Point(92, 80);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(10, 12);
            this.label36.TabIndex = 38;
            this.label36.Text = "1";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label37.Location = new System.Drawing.Point(108, 80);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(10, 12);
            this.label37.TabIndex = 39;
            this.label37.Text = "1";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label38.Location = new System.Drawing.Point(124, 80);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(10, 12);
            this.label38.TabIndex = 40;
            this.label38.Text = "1";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label39.Location = new System.Drawing.Point(140, 80);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(10, 12);
            this.label39.TabIndex = 41;
            this.label39.Text = "1";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label40.Location = new System.Drawing.Point(156, 80);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(10, 12);
            this.label40.TabIndex = 42;
            this.label40.Text = "1";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label41.Location = new System.Drawing.Point(12, 108);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(10, 12);
            this.label41.TabIndex = 43;
            this.label41.Text = "1";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label42.Location = new System.Drawing.Point(28, 108);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(10, 12);
            this.label42.TabIndex = 44;
            this.label42.Text = "1";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label43.Location = new System.Drawing.Point(44, 108);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(10, 12);
            this.label43.TabIndex = 45;
            this.label43.Text = "1";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label44.Location = new System.Drawing.Point(60, 108);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(10, 12);
            this.label44.TabIndex = 46;
            this.label44.Text = "1";
            // 
            // SpecifiedHeightGroupBox
            // 
            this.SpecifiedHeightGroupBox.Controls.Add(this.ZCoord);
            this.SpecifiedHeightGroupBox.Controls.Add(this.PointNumber);
            this.SpecifiedHeightGroupBox.Controls.Add(this.ApplySpecHeight);
            this.SpecifiedHeightGroupBox.Enabled = false;
            this.SpecifiedHeightGroupBox.Location = new System.Drawing.Point(606, 433);
            this.SpecifiedHeightGroupBox.Name = "SpecifiedHeightGroupBox";
            this.SpecifiedHeightGroupBox.Size = new System.Drawing.Size(140, 154);
            this.SpecifiedHeightGroupBox.TabIndex = 2;
            this.SpecifiedHeightGroupBox.TabStop = false;
            this.SpecifiedHeightGroupBox.Text = "Setting specified height";
            // 
            // ZCoord
            // 
            this.ZCoord.Location = new System.Drawing.Point(6, 100);
            this.ZCoord.Name = "ZCoord";
            this.ZCoord.Size = new System.Drawing.Size(128, 20);
            this.ZCoord.TabIndex = 2;
            this.ZCoord.Text = "Enter Z coordinate";
            // 
            // PointNumber
            // 
            this.PointNumber.Location = new System.Drawing.Point(6, 60);
            this.PointNumber.Name = "PointNumber";
            this.PointNumber.Size = new System.Drawing.Size(128, 20);
            this.PointNumber.TabIndex = 1;
            this.PointNumber.Text = "Enter number of point";
            // 
            // ApplySpecHeight
            // 
            this.ApplySpecHeight.Location = new System.Drawing.Point(6, 19);
            this.ApplySpecHeight.Name = "ApplySpecHeight";
            this.ApplySpecHeight.Size = new System.Drawing.Size(128, 35);
            this.ApplySpecHeight.TabIndex = 0;
            this.ApplySpecHeight.Text = "Apply specified height";
            this.ApplySpecHeight.UseVisualStyleBackColor = true;
            this.ApplySpecHeight.Click += new System.EventHandler(this.ApplySpecHeight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 599);
            this.Controls.Add(this.SpecifiedHeightGroupBox);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeightGroupBox);
            this.Controls.Add(this.DetectingAndSaving);
            this.Controls.Add(this.Map);
            this.MaximumSize = new System.Drawing.Size(768, 638);
            this.MinimumSize = new System.Drawing.Size(768, 638);
            this.Name = "Form1";
            this.Text = "Path Editor";
            ((System.ComponentModel.ISupportInitialize)(this.Map)).EndInit();
            this.DetectingAndSaving.ResumeLayout(false);
            this.HeightGroupBox.ResumeLayout(false);
            this.HeightGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.SpecifiedHeightGroupBox.ResumeLayout(false);
            this.SpecifiedHeightGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Map;
        private System.Windows.Forms.GroupBox DetectingAndSaving;
        private System.Windows.Forms.Button SavePoints;
        private System.Windows.Forms.Button DetectPoints;
        private System.Windows.Forms.GroupBox HeightGroupBox;
        private System.Windows.Forms.Button ApplyHeight;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.GroupBox SpecifiedHeightGroupBox;
        private System.Windows.Forms.TextBox PointNumber;
        private System.Windows.Forms.Button ApplySpecHeight;
        private System.Windows.Forms.TextBox ZCoord;
    }
}

