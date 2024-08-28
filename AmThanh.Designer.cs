
namespace BattleCity
{
    partial class AmThanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmThanh));
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.Btn_play = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.TrackList = new System.Windows.Forms.ListBox();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.Volume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_select.ForeColor = System.Drawing.Color.Red;
            this.btn_select.Location = new System.Drawing.Point(56, 481);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(83, 36);
            this.btn_select.TabIndex = 0;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.Red;
            this.btn_next.Location = new System.Drawing.Point(145, 481);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(83, 36);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // Btn_play
            // 
            this.Btn_play.BackColor = System.Drawing.SystemColors.Desktop;
            this.Btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_play.ForeColor = System.Drawing.Color.Red;
            this.Btn_play.Location = new System.Drawing.Point(234, 481);
            this.Btn_play.Name = "Btn_play";
            this.Btn_play.Size = new System.Drawing.Size(83, 36);
            this.Btn_play.TabIndex = 2;
            this.Btn_play.Text = "Play";
            this.Btn_play.UseVisualStyleBackColor = false;
            this.Btn_play.Click += new System.EventHandler(this.Btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.ForeColor = System.Drawing.Color.Red;
            this.btn_pause.Location = new System.Drawing.Point(323, 481);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(83, 36);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.ForeColor = System.Drawing.Color.Red;
            this.btn_stop.Location = new System.Drawing.Point(412, 481);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(83, 36);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // p_bar
            // 
            this.p_bar.Location = new System.Drawing.Point(56, 459);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(439, 16);
            this.p_bar.TabIndex = 5;
            // 
            // TrackList
            // 
            this.TrackList.BackColor = System.Drawing.Color.DimGray;
            this.TrackList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TrackList.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TrackList.ForeColor = System.Drawing.Color.DarkSalmon;
            this.TrackList.FormattingEnabled = true;
            this.TrackList.ItemHeight = 21;
            this.TrackList.Location = new System.Drawing.Point(12, 120);
            this.TrackList.Name = "TrackList";
            this.TrackList.Size = new System.Drawing.Size(439, 315);
            this.TrackList.TabIndex = 6;
            this.TrackList.SelectedIndexChanged += new System.EventHandler(this.TrackList_SelectedIndexChanged);
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(12, 21);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(510, 93);
            this.Player.TabIndex = 7;
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(477, 120);
            this.Volume.Maximum = 100;
            this.Volume.Name = "Volume";
            this.Volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Volume.Size = new System.Drawing.Size(45, 319);
            this.Volume.TabIndex = 8;
            this.Volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Volume.Scroll += new System.EventHandler(this.Volume_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(475, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Volume";
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.BackColor = System.Drawing.Color.Black;
            this.lbl_track_start.Font = new System.Drawing.Font(".VnBahamasBH", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_start.ForeColor = System.Drawing.Color.Lime;
            this.lbl_track_start.Location = new System.Drawing.Point(12, 47);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(117, 54);
            this.lbl_track_start.TabIndex = 10;
            this.lbl_track_start.Text = "00:00";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(323, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Desktop;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(56, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Âm Thanh: Bật";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AmThanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BattleCity.Properties.Resources._GetPaidStock_com__61b348ad62353;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 611);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.TrackList);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.Btn_play);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_select);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AmThanh";
            this.Text = "Cài Đặt Âm Thanh";
            this.Load += new System.EventHandler(this.AmThanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button Btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.ListBox TrackList;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.TrackBar Volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
    }
}