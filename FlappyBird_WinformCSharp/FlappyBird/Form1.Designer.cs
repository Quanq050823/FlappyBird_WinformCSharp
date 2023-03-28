namespace FlappyBird
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scorelb = new System.Windows.Forms.Label();
            this.bestlb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.doubleBufferedPanel1 = new FlappyBird.DoubleBufferedPanel();
            this.bird2 = new CircularPictureBox();
            this.NOTE = new System.Windows.Forms.Label();
            this.GO = new System.Windows.Forms.PictureBox();
            this.restartbtn = new CircularPictureBox();
            this.bird = new CircularPictureBox();
            this.toppipe = new System.Windows.Forms.PictureBox();
            this.item = new CircularPictureBox();
            this.botpipe = new System.Windows.Forms.PictureBox();
            this.circularPictureBox1 = new CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.doubleBufferedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bird2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toppipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botpipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // myTimer
            // 
            this.myTimer.Interval = 30;
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::FlappyBird.Properties.Resources.ground;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // scorelb
            // 
            resources.ApplyResources(this.scorelb, "scorelb");
            this.scorelb.BackColor = System.Drawing.Color.Transparent;
            this.scorelb.ForeColor = System.Drawing.Color.Red;
            this.scorelb.Image = global::FlappyBird.Properties.Resources.colour2;
            this.scorelb.Name = "scorelb";
            // 
            // bestlb
            // 
            resources.ApplyResources(this.bestlb, "bestlb");
            this.bestlb.BackColor = System.Drawing.Color.Transparent;
            this.bestlb.ForeColor = System.Drawing.Color.Red;
            this.bestlb.Image = global::FlappyBird.Properties.Resources.colour2;
            this.bestlb.Name = "bestlb";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Image = global::FlappyBird.Properties.Resources.colour2;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Image = global::FlappyBird.Properties.Resources.colour2;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Image = global::FlappyBird.Properties.Resources.colour2;
            this.label3.Name = "label3";
            // 
            // doubleBufferedPanel1
            // 
            this.doubleBufferedPanel1.BackgroundImage = global::FlappyBird.Properties.Resources.background;
            resources.ApplyResources(this.doubleBufferedPanel1, "doubleBufferedPanel1");
            this.doubleBufferedPanel1.Controls.Add(this.bird2);
            this.doubleBufferedPanel1.Controls.Add(this.NOTE);
            this.doubleBufferedPanel1.Controls.Add(this.GO);
            this.doubleBufferedPanel1.Controls.Add(this.restartbtn);
            this.doubleBufferedPanel1.Controls.Add(this.bird);
            this.doubleBufferedPanel1.Controls.Add(this.toppipe);
            this.doubleBufferedPanel1.Controls.Add(this.item);
            this.doubleBufferedPanel1.Controls.Add(this.botpipe);
            this.doubleBufferedPanel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.doubleBufferedPanel1.Name = "doubleBufferedPanel1";
            // 
            // bird2
            // 
            this.bird2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bird2, "bird2");
            this.bird2.InitialImage = global::FlappyBird.Properties.Resources.Q;
            this.bird2.Name = "bird2";
            this.bird2.TabStop = false;
            // 
            // NOTE
            // 
            resources.ApplyResources(this.NOTE, "NOTE");
            this.NOTE.BackColor = System.Drawing.Color.Transparent;
            this.NOTE.ForeColor = System.Drawing.Color.Red;
            this.NOTE.Name = "NOTE";
            // 
            // GO
            // 
            this.GO.BackColor = System.Drawing.Color.Transparent;
            this.GO.Image = global::FlappyBird.Properties.Resources.pngaaa1;
            resources.ApplyResources(this.GO, "GO");
            this.GO.Name = "GO";
            this.GO.TabStop = false;
            // 
            // restartbtn
            // 
            this.restartbtn.BackColor = System.Drawing.Color.Transparent;
            this.restartbtn.BackgroundImage = global::FlappyBird.Properties.Resources.to_replay;
            resources.ApplyResources(this.restartbtn, "restartbtn");
            this.restartbtn.Name = "restartbtn";
            this.restartbtn.TabStop = false;
            this.restartbtn.Click += new System.EventHandler(this.restartbtn_Click);
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = global::FlappyBird.Properties.Resources.Frame_1;
            resources.ApplyResources(this.bird, "bird");
            this.bird.InitialImage = global::FlappyBird.Properties.Resources.Q;
            this.bird.Name = "bird";
            this.bird.TabStop = false;
            // 
            // toppipe
            // 
            this.toppipe.BackColor = System.Drawing.Color.Transparent;
            this.toppipe.Image = global::FlappyBird.Properties.Resources.pipe__1_;
            resources.ApplyResources(this.toppipe, "toppipe");
            this.toppipe.Name = "toppipe";
            this.toppipe.TabStop = false;
            // 
            // item
            // 
            this.item.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.item, "item");
            this.item.Name = "item";
            this.item.TabStop = false;
            // 
            // botpipe
            // 
            this.botpipe.BackColor = System.Drawing.Color.Transparent;
            this.botpipe.Image = global::FlappyBird.Properties.Resources.pipe;
            resources.ApplyResources(this.botpipe, "botpipe");
            this.botpipe.Name = "botpipe";
            this.botpipe.TabStop = false;
            // 
            // circularPictureBox1
            // 
            resources.ApplyResources(this.circularPictureBox1, "circularPictureBox1");
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bestlb);
            this.Controls.Add(this.scorelb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.doubleBufferedPanel1);
            this.Controls.Add(this.circularPictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.doubleBufferedPanel1.ResumeLayout(false);
            this.doubleBufferedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bird2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toppipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botpipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.PictureBox toppipe;
        private System.Windows.Forms.PictureBox botpipe;
        private CircularPictureBox bird;
        private CircularPictureBox circularPictureBox1;
        private CircularPictureBox item;
        private DoubleBufferedPanel doubleBufferedPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularPictureBox restartbtn;
        private System.Windows.Forms.PictureBox GO;
        private System.Windows.Forms.Label scorelb;
        private System.Windows.Forms.Label bestlb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NOTE;
        private CircularPictureBox bird2;
    }
}

