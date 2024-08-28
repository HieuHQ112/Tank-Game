using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace BattleCity
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        bool right, left, up, down, pauseg, restart;
        Random rdn = new Random();
        int score = Form2.global.scorecon;
        int levelbullet;
        int level = 1;
        public static int finalscore;
        int live = 1;
        Keys keylen;
        Keys keyxuong;
        Keys keytrai;
        Keys keyphai;
        public static class globalform3
        {
            
            public static int sch;
        }


        object bulletnamelv2 = Properties.Resources.ResourceManager.GetObject("snowball21");
        object bricknamelv2 = Properties.Resources.ResourceManager.GetObject("icewall");
        object bosslv2 = Properties.Resources.ResourceManager.GetObject("snowbboss2nobg");
        object bossbulletlv2 = Properties.Resources.ResourceManager.GetObject("snowmanbulfi");
        object tankenelv2 = Properties.Resources.ResourceManager.GetObject("tanknoelfi");
        object bulenelv2 = Properties.Resources.ResourceManager.GetObject("snowenebul");


        object bulletnamelv3 = Properties.Resources.ResourceManager.GetObject("lazerbul");
        object bricknamelv3 = Properties.Resources.ResourceManager.GetObject("egg");
        object bosslv3 = Properties.Resources.ResourceManager.GetObject("bigduck");
        object bossbulletlv3 = Properties.Resources.ResourceManager.GetObject("lv3bossbul");
        object tankenelv3 = Properties.Resources.ResourceManager.GetObject("penguinene1");
        object bulenelv3 = Properties.Resources.ResourceManager.GetObject("bulenelv3fi");
        object playerlv3 = Properties.Resources.ResourceManager.GetObject("yellowduck");


        private static SoundPlayer clipBurst = new SoundPlayer(Properties.Resources.prop);

        private static SoundPlayer clipPlayershoot = new SoundPlayer(Properties.Resources.gun_laser_mav);

        private static SoundPlayer thuangu = new SoundPlayer(Properties.Resources.y2meta_com___Game_Over_Sound_Effect__64_kbps_);

        private static SoundPlayer thangngu = new SoundPlayer(Properties.Resources.y2meta_com___Victory_Sound_Effect__64_kbps_);
        public static void Playerthuangu()
        {
            thuangu.Play();
        }
        public static void Playerthangngu()
        {
            thangngu.Play();
        }
        public static void PlayerShoot()
        {
            clipPlayershoot.Play();
        }
        public static void PlayerMute()
        {
            clipPlayershoot.Stop();
        }
        //Âm thanh attacker bắn
        //Âm thanh attacker nổ
        public static void AttackerBurst()
        {
            clipBurst.Play();
            
        }

        void ea_bulletdown()
        {
            levelbullet = level;
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && x.Tag == "ea_bullet")
                {
                    x.Top += (20);
                    if (x.Top > 900)
                    {
                        int i;
                        i = rdn.Next(50, 500);
                        x.Location = new Point(i, 150);

                    }

                }
            }
        }

        void levelupshow()
        {
            uplv.Visible = true;
        }
        void leveluphide()
        {
            uplv.Visible = false;
        }
        void power()
        {

            if (heartdown.Top < 900)
            {
                heartdown.Top += 5;
            }   

        }
        void power2()
        {
            if (heartdown2.Top < 900)
            {
                heartdown2.Top += 5;
            }
        }
        int eaglealive()
        {
            int k = 0;
            if (score < 50)
            {
                gameover();

            }
            else if (score >= 50 && score < 100)
            {
                gameover();

                eagle.Visible = true;
                HPbar.Visible = true;
                Hpbaric.Visible = true;
                eagle.BackColor = Color.Transparent;
                HPbar.Enabled = true;
                ea_1.Visible = true;
                ea_2.Visible = true;
                ea_3.Visible = true;
                ea_4.Visible = true;
                ea_1.Enabled = true;
                ea_2.Enabled = true;
                ea_3.Enabled = true;
                ea_4.Enabled = true;
                ea_bulletdown();

                if (HPbar.Value == 0)
                {
                    score += 50;
                    txtscore.Text = "Score: " + score;
                    PlayerMute();
                    AttackerBurst();
                    heartdown.Visible = true;
                    levelupshow();


                }
                else
                {
                    int i;
                    i = rdn.Next(-15, 15);
                    eagle.Left += i;
                    eagle.Left -= i;

                    if (b_1.Bounds.IntersectsWith(eagle.Bounds))
                    {
                        HPbar.Value = HPbar.Value - 10;
                    }

                }
                return 1;
            }
            else if (score >= 100 && score < 150)
            {
                
                Form1.ActiveForm.BackgroundImage = global::BattleCity.Properties.Resources.snowmap;

                

                foreach (Control x in this.Controls)
                {

                    if (x is PictureBox && x.Tag == "ea_bullet")
                    {
                        x.BackgroundImage = (Image)bossbulletlv2;

                    }
                }

                gameover();

                if (score > 110)
                {
                    leveluphide();


                }
                HPbar.Visible = false;
                Hpbaric.Visible = false;
                eagle.Visible = false;
                HPbar.Enabled = false;
                ea_1.Visible = false;
                ea_2.Visible = false;
                ea_3.Visible = false;
                ea_4.Visible = false;
                ea_1.Enabled = false;
                ea_2.Enabled = false;
                ea_3.Enabled = false;
                ea_4.Enabled = false;
                HPbar.Value = 100;
            }
            else if (score >= 150 && score < 300)
            {
                gameover();



                eaglelv2.Visible = true;
                HPbar.Visible = true;
                Hpbaric.Visible = true;
                HPbar.Enabled = true;
                ea_1.Visible = true;
                ea_2.Visible = true;
                ea_3.Visible = true;
                ea_4.Visible = true;
                ea_1.Enabled = true;
                ea_2.Enabled = true;
                ea_3.Enabled = true;
                ea_4.Enabled = true;
                ea_bulletdown();

                if (HPbar.Value == 0)
                {
                    score += 50;
                    txtscore.Text = "Score: " + score;
                    AttackerBurst();
                    heartdown2.Visible = true;
                    levelupshow();
                }
                else
                {
                    int i;
                    i = rdn.Next(-15, 15);
                    eagle.Left += i;
                    eagle.Left -= i;

                    if (b_1.Bounds.IntersectsWith(eaglelv2.Bounds))
                    {
                        HPbar.Value = HPbar.Value - 5;
                    }

                }

            }
            else if (score >= 300 && score < 350)
            {
                
                Form1.ActiveForm.BackgroundImage = global::BattleCity.Properties.Resources.space;
                player.BackgroundImage = (Image)playerlv3;

                

                foreach (Control x in this.Controls)
                {

                    if (x is PictureBox && x.Tag == "ea_bullet")
                    {
                        x.BackgroundImage = (Image)bossbulletlv3;

                    }
                }

                gameover();

                if (score > 305)
                {
                    leveluphide();

                }
                HPbar.Visible = false;
                Hpbaric.Visible = false;
                eagle.Visible = false;
                eaglelv2.Visible = false;
                HPbar.Enabled = false;
                ea_1.Visible = false;
                ea_2.Visible = false;
                ea_3.Visible = false;
                ea_4.Visible = false;
                ea_1.Enabled = false;
                ea_2.Enabled = false;
                ea_3.Enabled = false;
                ea_4.Enabled = false;
                HPbar.Value = 100;
            }
            else if (score >= 350)
            {
                gameover1();

                eaglelv3.Visible = true;
                HPbar.Visible = true;
                Hpbaric.Visible = true;
                HPbar.Enabled = true;
                ea_1.Visible = true;
                ea_2.Visible = true;
                ea_3.Visible = true;
                ea_4.Visible = true;
                ea_1.Enabled = true;
                ea_2.Enabled = true;
                ea_3.Enabled = true;
                ea_4.Enabled = true;
                ea_bulletdown();

                if (HPbar.Value == 0)
                {
                    score += 100;
                    txtscore.Text = "Score: " + score;
                    AttackerBurst();
                }
                else
                {
                    int i;
                    i = rdn.Next(-15, 15);
                    eagle.Left += i;
                    eagle.Left -= i;

                    if (b_1.Bounds.IntersectsWith(eaglelv3.Bounds))
                    {
                        HPbar.Value = HPbar.Value - 1;
                    }

                }
            }
            if (score>100 && score<=250)
            {
                power();
            }
            if (score > 250)
            {
                power2();
            }



            return HPbar.Value;
        }
        void gameover()
        {
            foreach (Control x in this.Controls)
            {

                if (player.Bounds.IntersectsWith(x.Bounds) && x.Tag == "block" || player.Bounds.IntersectsWith(x.Bounds) && x.Tag == "ea_bullet" || player.Bounds.IntersectsWith(x.Bounds) && x.Tag == "enemy" || player.Bounds.IntersectsWith(x.Bounds) && x.Tag == "en_bullet")
                {

                    x.Top = 900;
                    if (live == 3)
                    {
                        live = 2;
                    }
                    else if (live == 2)
                    {
                        live = 1;
                    }
                    else
                    {
                        live = 0;
                    }

                }
            }

            if (player.Bounds.IntersectsWith(heartdown.Bounds))
            {
                heartdown.Visible = false;
                heartdown.Enabled = false;
                live = 2;
            }

            if (player.Bounds.IntersectsWith(heartdown2.Bounds))
            {
                heartdown2.Visible = false;
                heartdown.Enabled = false;
                live = 3;
            }
            if (live == 2)
            {
                heart2.Visible = true;
                heart3.Visible = false;
            }
            if (live == 3)
            {
                heart3.Visible = true;
            }
            if (live == 1)
            {
                pictureBox11.Visible = true;
                heart2.Visible = false;
                heart3.Visible = false;
            }
            if (live == 0)
            {
                pictureBox11.Visible = false;
                heart2.Visible = false;
                heart3.Visible = false;
                lbl_over.Visible = true;
                finalscore = score;
                Playerthuangu();
                esc.Visible = true;
                continuebt.Visible = false;
                timer1.Stop();
            }
        }




        void gameover1()
        {

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "block")
                {
                    x.Visible = false;

                }

                if (player.Bounds.IntersectsWith(x.Bounds) && x.Tag == "ea_bullet" || player.Bounds.IntersectsWith(x.Bounds) && x.Tag == "enemy" || player.Bounds.IntersectsWith(x.Bounds) && x.Tag == "en_bullet")
                {

                    x.Top = 900;
                    if (live == 3)
                    {
                        live = 2;
                    }
                    else if (live == 2)
                    {
                        live = 1;
                    }
                    else
                    {
                        live = 0;
                    }
                }
            }
            if (player.Bounds.IntersectsWith(heartdown.Bounds))
            {
                heartdown.Visible = false;
                heartdown.Enabled = false;
                live = 2;
            }

            if (player.Bounds.IntersectsWith(heartdown2.Bounds))
            {
                heartdown2.Visible = false;
                heartdown.Enabled = false;
                live = 3;
            }
            if (live == 2)
            {
                heart2.Visible = true;
                heart3.Visible = false;
            }
            if (live == 3)
            {
                heart3.Visible = true;
            }
            if (live == 1)
            {
                pictureBox11.Visible = true;
                heart2.Visible = false;
                heart3.Visible = false;
            }
            if (live == 0)
            {
                pictureBox11.Visible = false;
                heart2.Visible = false;
                heart3.Visible = false;
                lbl_over.Visible = true;
                Playerthuangu();
                finalscore = score;
                esc.Visible = true;
                continuebt.Visible = false;
                timer1.Stop();
            }
        }

        int game_result()
        {
            int sc;


            if (eaglealive() == 0 && level > 3)
            {
                lbl_over.Text = "Điểm: " + score + "\n Chúc mừng bạn đã hoàn thành trò chơi";
                lbl_over.Visible = true;
                lbl_over.Image = null;
                Playerthangngu();
                esc.Visible = true;
                continuebt.Visible = false;
                timer1.Stop();

            }
            //if (pauseg)
            //{
            //    Time.timeScale = 0;
            //}
            //else
            //{
            //    Time.timeScale = 1;
            //}

            sc = score;

            finalscore = sc;
            return sc;
        }

        void Bullets()
        {
            
                if (score < 100)
                {
                    int i = 500;
                    levelbullet = level * 2+level;
                    b_1.Top -= 40;
                    if (b_1.Top < player.Top - i)
                    {
                        b_1.Top = player.Top;
                        b_1.Left = player.Left + 10;
                        PlayerShoot();
                        //b_1.Image = Properties.Resources.a2;
                        b_1.Image = resizeImage(Properties.Resources.a2, new Size(20, 20));
                    }

                    en_1.Top += (10 + levelbullet);
                    if (en_1.Top > 850)
                    {
                        en_1.Top = enemy1.Top + 40;
                        en_1.Left = enemy1.Left + 20;
                        en_1.Image = Properties.Resources.BulletDown;
                    }

                    en_2.Top += (10 + levelbullet);
                    if (en_2.Top > 850)
                    {
                        en_2.Top = enemy2.Top + 40;
                        en_2.Left = enemy2.Left + 20;
                        en_2.Image = Properties.Resources.BulletDown;
                    }

                    en_3.Top += (10 + levelbullet);
                    if (en_3.Top > 850)
                    {
                        en_3.Top = enemy3.Top + 40;
                        en_3.Left = enemy3.Left + 20;
                        en_3.Image = Properties.Resources.BulletDown;
                    }
                }
                else if (score >= 100 && score < 200)
                {
                    int i = 500;
                    levelbullet = level * 2 +level;
                    b_1.Top -= 40;
                    if (b_1.Top < player.Top - i)
                    {
                        b_1.Top = player.Top;
                        b_1.Left = player.Left + 10;
                        PlayerShoot();
                        //b_1.Image = Properties.Resources.a2;
                        b_1.Image = resizeImage((Image)bulletnamelv2, new Size(20, 20));
                    }

                    en_1.Top += (10 + levelbullet);
                    if (en_1.Top > 850)
                    {
                        en_1.Top = enemy1.Top + 40;
                        en_1.Left = enemy1.Left + 20;
                        en_1.Image = resizeImage((Image)bulenelv2, new Size(20, 20));
                    }

                    en_2.Top += (10 + levelbullet);
                    if (en_2.Top > 850)
                    {
                        en_2.Top = enemy2.Top + 40;
                        en_2.Left = enemy2.Left + 20;
                        en_2.Image = resizeImage((Image)bulenelv2, new Size(20, 20));
                    }

                    en_3.Top += (10 + levelbullet);
                    if (en_3.Top > 850)
                    {
                        en_3.Top = enemy3.Top + 40;
                        en_3.Left = enemy3.Left + 20;
                        en_3.Image = resizeImage((Image)bulenelv2, new Size(20, 20));
                    }
                }
                else
                {
                    int i = 500;
                    levelbullet = level * 2+ level;
                    b_1.Top -= 40;
                    if (b_1.Top < player.Top - i)
                    {
                        b_1.Top = player.Top;
                        b_1.Left = player.Left + 10;
                        PlayerShoot();
                        //b_1.Image = Properties.Resources.a2;
                        b_1.Image = resizeImage((Image)bulletnamelv3, new Size(20, 20));
                    }

                    en_1.Top += (10 + levelbullet);
                    if (en_1.Top > 850)
                    {
                        en_1.Top = enemy1.Top + 40;
                        en_1.Left = enemy1.Left + 20;
                        en_1.Image = resizeImage((Image)bulenelv3, new Size(20, 20));
                    }

                    en_2.Top += (10 + levelbullet);
                    if (en_2.Top > 850)
                    {
                        en_2.Top = enemy2.Top + 40;
                        en_2.Left = enemy2.Left + 20;
                        en_2.Image = resizeImage((Image)bulenelv3, new Size(20, 20));
                    }

                    en_3.Top += (10 + levelbullet);
                    if (en_3.Top > 850)
                    {
                        en_3.Top = enemy3.Top + 40;
                        en_3.Left = enemy3.Left + 20;
                        en_3.Image = resizeImage((Image)bulenelv3, new Size(20, 20));
                    }
                }
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "en_bullet")
                    {
                        if (b_1.Bounds.IntersectsWith(x.Bounds))
                        {
                            x.Top = 900;
                            b_1.Top = player.Top - 500;
                        }
                    }
                }
           

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "en_bullet")
                {
                    if (b_1.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Top = 900;
                        b_1.Top = player.Top - 500;
                    }
                }
            }

        }
        void spawnenemy()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "enemy")
                {
                    if (score < 100)

                    {
                        x.Top += 5 + level;
                        if (x.Top > 850)
                        {
                            int i;
                            i = rdn.Next(50, 500);
                            x.Location = new Point(i, 100);

                        }
                        if (b_1.Bounds.IntersectsWith(x.Bounds))
                        {
                            score += 5;
                            txtscore.Text = "Score: " + score;
                            if (score < 100)
                            {
                                level = 1;
                            }
                            else if (score >= 100 && score < 200)
                            {
                                level = 2;
                            }
                            else if (score >= 200 && score < 300)
                            {
                                level = 3;
                            }
                            else
                            {
                                level = 4;
                            }
                            txtlevel.Text = "Level: " + level;
                            b_1.Image = Properties.Resources.Detonation;
                            x.Top = 850;
                        }
                    }
                    else if (score >= 100 && score <= 200)
                    {
                        //int i;
                        //i = rdn.Next(200, 500);
                        //x.Location = new Point(50, i);
                        x.BackgroundImage = (Image)tankenelv2;
                        x.Left += 3 + level;
                        if (x.Left > 580)
                        {
                            int i;
                            i = rdn.Next(200, 500);
                            x.Location = new Point(50, i);

                        }
                        if (b_1.Bounds.IntersectsWith(x.Bounds))
                        {
                            score += 5;
                            txtscore.Text = "Score: " + score;
                            if (score < 100)
                            {
                                level = 1;
                            }
                            else if (score >= 100 && score < 200)
                            {
                                level = 2;
                            }
                            else if (score >= 200 )
                            {
                                level = 3;
                            }
                          
                            txtlevel.Text = "Level: " + level;
                            b_1.Image = Properties.Resources.Detonation;
                            x.Left = 600;
                        }
                    }
                    else
                    {
                        x.BackgroundImage = (Image)tankenelv3;
                        x.Left += 3 + level;
                        if (x.Left > 580)
                        {
                            int i;
                            i = rdn.Next(200, 500);
                            x.Location = new Point(50, i);

                        }
                        if (b_1.Bounds.IntersectsWith(x.Bounds))
                        {
                            score += 5;
                            txtscore.Text = "Score: " + score;
                            if (score <100)
                            {
                                level = 1;
                            }
                            else if (score >= 100 && score < 200)
                            {
                                level = 2;
                            }
                            else if (score >= 200)
                            {
                                level = 3;
                            }
                    
                            txtlevel.Text = "Level: " + level;
                            b_1.Image = Properties.Resources.Detonation;
                            x.Left = 600;
                        }
                    }


                }

            }
        }
        void Block()
        {

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "block")
                {
                    if (x.Top > 900)
                    {
                        x.Top = 10;
                        if (score < 100)
                        { x.BackgroundImage = Properties.Resources.BrickWall; }
                        else if (score >= 100 && score < 200)
                        {
                            x.BackgroundImage = (Image)bricknamelv2;
                        }
                        else
                        {
                            x.BackgroundImage = (Image)bricknamelv3;
                        }

                    }

                    else
                        x.Top += 4;

                    if (b_1.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Top = 900;
                        b_1.Top = player.Top - 500;
                    }
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lbl_over.Visible = false;
            eagle.Visible = false;
            eaglelv2.Visible = false;
            eaglelv3.Visible = false;
            HPbar.Enabled = false;
            ea_1.Visible = false;
            ea_2.Visible = false;
            ea_3.Visible = false;
            ea_4.Visible = false;
            ea_1.Enabled = false;
            ea_2.Enabled = false;
            ea_3.Enabled = false;
            ea_4.Enabled = false;
            txtscore.Text = "Score: " + score;
            
            Enum.TryParse(KeyMap.kmglobal.len, out keylen);
            Enum.TryParse(KeyMap.kmglobal.xuong, out keyxuong);
            Enum.TryParse(KeyMap.kmglobal.trai, out keytrai);
            Enum.TryParse(KeyMap.kmglobal.phai, out keyphai);

        }

        private void continuebt_Click(object sender, EventArgs e)
        {
            timer1.Start();
            esc.Hide();
            this.KeyPreview = true;
        }
        
        public void homebt_Click(object sender, EventArgs e)
        {
            this.Close();
             globalform3.sch = score;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form31 = new Form3();
            form31.Show();
            this.Close();
        }

        void move()
        {
            if (right == true)
            {
                if (player.Right < 570)
                {
                    player.Left += 5;
                }
            }
            if (left == true)
            {
                if (player.Right > 70)
                {
                    player.Left -= 5;
                }
            }
            if (up == true)
            {

                if (player.Top > 50)
                {
                    player.Top -= 5;
                }
            }
            if (down == true)
            {
                if (player.Top < 800)
                {
                    player.Top += 5;
                }
            }
        }


        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            move();
            Block();
            spawnenemy();
            Bullets();
            game_result();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == keylen)
            {
                up = true;
            } else if (e.KeyCode == keyxuong)
            {
                down = true;
            }
            else if (e.KeyCode == keytrai)
            {
                left = true;
            }
            else if (e.KeyCode == keyphai)
            {
                right = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                esc.Visible = true;
                timer1.Stop();
                
            }
            

        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == keylen)
            {
                up = false;
            }
            else if (e.KeyCode == keyxuong)
            {
                down = false;
            }
            else if (e.KeyCode == keytrai)
            {
                left = false;
            }
            else if (e.KeyCode == keyphai)
            {
                right = false;
            }
        }
    }
}
