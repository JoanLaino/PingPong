
namespace PingPong
{
    partial class Juego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pelota = new System.Windows.Forms.PictureBox();
            this.palo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(719, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 28);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pelota
            // 
            this.pelota.BackColor = System.Drawing.Color.Transparent;
            this.pelota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pelota.BackgroundImage")));
            this.pelota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pelota.Location = new System.Drawing.Point(128, 163);
            this.pelota.Name = "pelota";
            this.pelota.Size = new System.Drawing.Size(38, 29);
            this.pelota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pelota.TabIndex = 1;
            this.pelota.TabStop = false;
            // 
            // palo
            // 
            this.palo.BackColor = System.Drawing.Color.White;
            this.palo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.palo.Location = new System.Drawing.Point(739, 172);
            this.palo.Name = "palo";
            this.palo.Size = new System.Drawing.Size(10, 61);
            this.palo.TabIndex = 2;
            this.palo.TabStop = false;
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.palo);
            this.Controls.Add(this.pelota);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Juego_FormClosing);
            this.Load += new System.EventHandler(this.Juego_Load);
            this.Click += new System.EventHandler(this.Juego_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Juego_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pelota;
        private System.Windows.Forms.PictureBox palo;
    }
}