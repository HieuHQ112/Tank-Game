using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace BattleCity
{
    public partial class Form2 : Form
    {
        public static class global
        {
            public static string Ten = "Hieu";
            public static int Score = Form3.finalscore;
            public static int scorecon;
        }
        
        //====================================================================//
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form2()
        {
            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(5000);
   
            InitializeComponent();
            trd.Abort();
            
        }

        private void formRun()
        {
            Application.Run(new Form1());

        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            HuongDan huongDanwindow = new HuongDan();
            huongDanwindow.Show();
        }

        private void SoundSetting_btn_Click(object sender, EventArgs e)
        {
            AmThanh AmThanhwindow = new AmThanh();
            AmThanhwindow.Show();
            player.Stop();
        }
 
        private void Newgame_btn_Click(object sender, EventArgs e)
        {
           
            Form3 Newgame = new Form3();
            Newgame.Show();
            global.scorecon = 0;
        }

        void continue_btn_Click(object sender, EventArgs e)
        {
            global.scorecon = 300;
            Form3 Newgame = new Form3();
            Newgame.Show();
        }

        private void keysetting_btn_Click(object sender, EventArgs e)
        {
            KeyMap KeyMapwindow = new KeyMap();
            KeyMapwindow.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            player.SoundLocation = string.Format("{0}Resources\\y2meta.com-_37-Quảng-trường-Gunny-OST-_128-kbps_.wav", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\"))); ;
            player.Play();
            AmThanh.musicglobal.savenhac = player.SoundLocation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiemCao AmThanhwindow = new DiemCao();
            AmThanhwindow.Show();           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                global.Ten = textBox1.Text;
                textBox1.Visible = false;
            }
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_DoubleClick(object sender, EventArgs e)
        {
            player.SoundLocation = AmThanh.musicglobal.savenhac;
            player.Play();
        }
    }
}
