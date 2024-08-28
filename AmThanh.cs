using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace BattleCity
{
    public partial class AmThanh : Form
    {

        public static class musicglobal
        {
            public static string savenhac;
        }
        public AmThanh()
        {
            InitializeComponent();
            Volume.Value = 50;
        }
        string[] paths, file;
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = ofd.FileNames;
                paths = ofd.FileNames;
                for (int x = 0; x < file.Length; x++)
                {
                    TrackList.Items.Add(file[x]);
                }

            }
        }

        private void TrackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TrackList.SelectedIndex == 0)
            {
                Player.URL = FileName;
                Player.Ctlcontrols.play();
            }
            else if (TrackList.SelectedIndex == 1)
            {
                Player.URL = FileName2;
                Player.Ctlcontrols.play();
            }
            else if (TrackList.SelectedIndex == 2)
            {
                Player.URL = FileName3;
                Player.Ctlcontrols.play();
            }
            else if (TrackList.SelectedIndex == 3)
            {
                Player.URL = FileName4;
                Player.Ctlcontrols.play();
            }
            else if (TrackList.SelectedIndex == 4)
            {
                Player.URL = FileName5;
                Player.Ctlcontrols.play();
            }
            else if (TrackList.SelectedIndex == 5)
            {
                Player.URL = FileName6;
                Player.Ctlcontrols.play();
            }
            else if (TrackList.SelectedIndex == 6)
            {
                Player.URL = FileName7;
                Player.Ctlcontrols.play();
            }
            else if (TrackList.SelectedIndex == 7)
            {
                Player.URL = FileName8;
                Player.Ctlcontrols.play();
            }
            else if (TrackList.SelectedIndex == 8)
            {
                Player.URL = FileName9;
                Player.Ctlcontrols.play();
            }
            else if (TrackList.SelectedIndex == 9)
            {
                Player.URL = FileName10;
                Player.Ctlcontrols.play();
            } else 
            { 
            Player.URL = paths[TrackList.SelectedIndex-10];
            Player.Ctlcontrols.play();
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void Btn_play_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(TrackList.SelectedIndex<TrackList.Items.Count - 1)
            {
                TrackList.SelectedIndex = TrackList.SelectedIndex + 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Player.playState== WMPLib.WMPPlayState.wmppsPlaying)
            {
                p_bar.Maximum = (int)Player.Ctlcontrols.currentItem.duration;
                p_bar.Value = (int)Player.Ctlcontrols.currentPosition;
            }
            try
            {
                lbl_track_start.Text = Player.Ctlcontrols.currentPositionString;
            }
            catch
            {

            }

        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            AmThanh.musicglobal.savenhac = Player.URL;
        }
        string FileName;
        string FileName2;
        string FileName3;
        string FileName4;
        string FileName5;
        string FileName6;
        string FileName7;
        string FileName8;
        string FileName9;
        string FileName10;
        private void AmThanh_Load(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            FileName = string.Format("{0}Resources\\y2meta.com -  30 Phòng - Gunny OST (128 kbps).wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            FileName2 = string.Format("{0}Resources\\y2meta.com-_37-Quảng-trường-Gunny-OST-_128-kbps_.wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            FileName3 = string.Format("{0}Resources\\y2meta.com-_43-Đêm-an-lành-Gunny-OST-_128-kbps_.wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            FileName4 = string.Format("{0}Resources\\y2meta.com-_44-Mừng-tuổi-Gunny-OST-_128-kbps_.wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            FileName5 = string.Format("{0}Resources\\y2meta.com -  1 Cầu vồng - Gunny OST (128 kbps).wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            FileName6 = string.Format("{0}Resources\\y2meta.com -  10 Đèn lồng vàng - Gunny OST (128 kbps).wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            FileName7 = string.Format("{0}Resources\\y2meta.com -  14 Lễ đường - Gunny OST (128 kbps).wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            FileName8 = string.Format("{0}Resources\\y2meta.com -  16 Thần miếu - Gunny OST (128 kbps).wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            FileName9 = string.Format("{0}Resources\\y2meta.com -  2 Đường bay ma quái - Gunny OST (128 kbps).wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            FileName10 = string.Format("{0}Resources\\y2meta.com -  26 Ưu linh quỷ thành - Gunny OST (128 kbps).wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            Player.URL = FileName;
            Player.Ctlcontrols.play();
            TrackList.Items.Add("Nhạc mặc định");
            TrackList.Items.Add("Nhạc mặc định 2");
            TrackList.Items.Add("Nhạc mặc định 3");
            TrackList.Items.Add("Nhạc mặc định 4");
            TrackList.Items.Add("Nhạc mặc định 5");
            TrackList.Items.Add("Nhạc mặc định 6");
            TrackList.Items.Add("Nhạc mặc định 7");
            TrackList.Items.Add("Nhạc mặc định 8");
            TrackList.Items.Add("Nhạc mặc định 9");
            TrackList.Items.Add("Nhạc mặc định 10");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Âm Thanh: Bật")
            {
                button2.Text = "Âm Thanh: Tắt";
                btn_stop_Click(sender, e);
                Volume.Value = 0;
            } else
            if (button2.Text == "Âm Thanh: Tắt")
            {
                button2.Text = "Âm Thanh: Bật";
                Btn_play_Click(sender, e);
                Volume.Value = 50;
            }
        }




        private void Volume_Scroll(object sender, EventArgs e)
        {
            Player.settings.volume = Volume.Value;
        }

    }
}
