namespace SpotifyWindowAPP
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
            this.SongName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Artist = new System.Windows.Forms.Label();
            this.CopyRight = new System.Windows.Forms.Label();
            this.Album = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TrackTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SongName
            // 
            this.SongName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SongName.AutoSize = true;
            this.SongName.BackColor = System.Drawing.Color.Black;
            this.SongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongName.ForeColor = System.Drawing.Color.White;
            this.SongName.Location = new System.Drawing.Point(323, 2);
            this.SongName.MaximumSize = new System.Drawing.Size(10000, 0);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(371, 73);
            this.SongName.TabIndex = 0;
            this.SongName.Text = "Song Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 328);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Artist
            // 
            this.Artist.AutoSize = true;
            this.Artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artist.ForeColor = System.Drawing.Color.White;
            this.Artist.Location = new System.Drawing.Point(326, 85);
            this.Artist.MaximumSize = new System.Drawing.Size(10000, 0);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(132, 55);
            this.Artist.TabIndex = 3;
            this.Artist.Text = "Artist";
            // 
            // CopyRight
            // 
            this.CopyRight.AutoSize = true;
            this.CopyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyRight.ForeColor = System.Drawing.Color.White;
            this.CopyRight.Location = new System.Drawing.Point(330, 249);
            this.CopyRight.MaximumSize = new System.Drawing.Size(10000, 0);
            this.CopyRight.Name = "CopyRight";
            this.CopyRight.Size = new System.Drawing.Size(151, 33);
            this.CopyRight.TabIndex = 5;
            this.CopyRight.Text = "CopyRight";
            // 
            // Album
            // 
            this.Album.AutoSize = true;
            this.Album.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Album.ForeColor = System.Drawing.Color.White;
            this.Album.Location = new System.Drawing.Point(329, 140);
            this.Album.MaximumSize = new System.Drawing.Size(10000, 0);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(194, 42);
            this.Album.TabIndex = 6;
            this.Album.Text = "Album Info";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TrackTimer
            // 
            this.TrackTimer.Tick += new System.EventHandler(this.TrackTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1389, 300);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.CopyRight);
            this.Controls.Add(this.Artist);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SongName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Spotify Twitch App (Created By Thermalnuke)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SongName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Artist;
        private System.Windows.Forms.Label CopyRight;
        private System.Windows.Forms.Label Album;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer TrackTimer;
    }
}

