using System;
using System.Windows.Forms;
using System.Configuration;
using SpotifyAPI.Web; //Base Namespace
using SpotifyAPI.Web.Auth; //All Authentication-related classes
using SpotifyAPI.Web.Enums; //Enums
using System.Threading;
using System.Drawing;

namespace SpotifyWindowAPP
{
    public partial class Form1 : Form
    {
        public SpotifyWebAPI _spotify;
        WebAPIFactory webApiFactory = new WebAPIFactory("http://localhost/", 8000, ConfigurationManager.AppSettings["ClientID"], Scope.UserModifyPlaybackState, TimeSpan.FromSeconds(60));
        private int SongNameLength = 0;
        private int AlbumNameLength = 0;
        private int ArtistNameLength = 0;
        private int CopyRightNameLength = 0;
        private string CurrentSongID = "";
        private int SongStopped = 0;
        private KeyHandler ghk;


        public Form1()
        {
            ghk = new KeyHandler(Keys.MediaNextTrack, this);
            ghk.Register();
            ghk = new KeyHandler(Keys.MediaPreviousTrack, this);
            ghk.Register();
            ghk = new KeyHandler(Keys.MediaPlayPause, this);
            ghk.Register();
            ghk = new KeyHandler(Keys.MediaStop, this);
            ghk.Register();

            this.BackColor = Color.Black;
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //This will open the user's browser and returns once
                _spotify = await webApiFactory.GetWebApi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (_spotify == null)
            {
                SongName.Text = "App Not Connected";
            }
            else
            {
                GetSongInfo(); //get current song on App startup
            }
        }

        private async void GetSongInfo()
        {
            Thread.Sleep(5000);
            var context = _spotify.GetPlayingTrack();
            if (context.Item != null)
            {
                try
                {
                    var album = await _spotify.GetAlbumAsync(context.Item.Album.Id);
                    TrackTimer.Stop();
                    TrackTimer.Enabled = false;
                    TrackTimer.Interval = (context.Item.DurationMs - context.ProgressMs);
                    TrackTimer.Enabled = true;
                    TrackTimer.Start();
                    CurrentSongID = context.Item.Id;
                    SongName.Text = context.Item.Name;
                    Artist.Text = context.Item.Artists[0].Name;
                    Album.Text = album.Name + "(" + album.ReleaseDate + ")" /*+ " Songs: " + album.Tracks.Total*/;
                    CopyRight.Text = "Copyright: " + album.Copyrights[0].Text;
                    pictureBox1.Load(album.Images[1].Url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                //enable timer if song name is longer then what ever is set

                //if (SongName.Text.Length > 35 || Artist.Text.Length > 35 || Album.Text.Length > 35 || CopyRight.Text.Length > 35)                  
                //{
                //    timer1.Interval = 1;
                //    timer1.Enabled = false;
                //    timer1.Start();                    
                //}
                //else
                //{
                //    timer1.Stop();
                //    timer1.Enabled = false;
                //    SongName.Left = 320;
                //    Artist.Left = 320;
                //    Album.Left = 320;
                //    CopyRight.Left = 320;
                //}
            }
            else
            {
                SongName.Text = "Failed To Get Song Info";
                _spotify = await webApiFactory.GetWebApi(); //Refresh Oauth
                GetSongInfo(); //Re-get song info
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SongName.Text.Length > 35)
            {
                if (SongName.Left == (0 - SongNameLength))
                {
                    SongName.Left = this.Width;
                }
                SongName.Left -= 1;
            }

            if (Artist.Text.Length > 35)
            {
                if (Artist.Left == (0 - ArtistNameLength))
                {
                    Artist.Left = this.Width;
                }
                Artist.Left -= 1;
            }

            if (Album.Text.Length > 35)
            {
                if (Album.Left == (0 - AlbumNameLength))
                {
                    Album.Left = this.Width;
                }
                Album.Left -= 1;
            }

            if (CopyRight.Text.Length > 35)
            {
                if (CopyRight.Left == (0 - CopyRightNameLength))
                {
                    CopyRight.Left = this.Width;
                }
                CopyRight.Left -= 1;
            }

        }

        protected override void WndProc(ref Message m)
        {

            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
            {
                switch (GetKey(m.LParam))
                {
                    case Keys.MediaNextTrack:
                        _spotify.SkipPlaybackToNext();
                        GetSongInfo();
                        break;
                    case Keys.MediaPreviousTrack:
                        _spotify.SkipPlaybackToPrevious();
                        GetSongInfo();
                        break;
                    case Keys.MediaPlayPause:
                        if (SongStopped == 0)
                        {
                            _spotify.PausePlayback();
                            TrackTimer.Stop();
                            SongStopped = 1;
                        }
                        else
                        {
                            _spotify.ResumePlayback();
                            TrackTimer.Start();
                            SongStopped = 0;
                        }
                        break;
                    case Keys.MediaStop:
                        if (SongStopped == 0)
                        {
                            _spotify.PausePlayback();
                            TrackTimer.Stop();
                            SongStopped = 1;
                        }
                        else
                        {
                            _spotify.ResumePlayback();
                            TrackTimer.Start();
                            SongStopped = 0;
                        }
                        break;
                }
            }

            base.WndProc(ref m);
        }

        private Keys GetKey(IntPtr LParam)
        {
            return (Keys)((LParam.ToInt32()) >> 16);
        }

        private void TrackTimer_Tick(object sender, EventArgs e)
        {
            GetSongInfo();
        }
    }
}
