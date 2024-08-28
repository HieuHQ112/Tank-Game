using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleCity
{
    public partial class KeyMap : Form
    {
        public KeyMap()
        {
            InitializeComponent();
        }
        public static class kmglobal
        {
            public static string len = "W";
            public static string xuong = "S";
            public static string trai = "A";
            public static string phai = "D";
        }
        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            textBox1.Text = "" + e.KeyCode;
            MessageBox.Show("Đã thay đổi hotkey!!!", "Thành công");
            kmglobal.len = "" + e.KeyCode;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            textBox2.Text = "" + e.KeyCode;
            MessageBox.Show("Đã thay đổi hotkey!!!", "Thành công");
            kmglobal.xuong = "" + e.KeyCode;
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            textBox3.Text = "" + e.KeyCode;
            MessageBox.Show("Đã thay đổi hotkey!!!", "Thành công");
            kmglobal.trai = "" + e.KeyCode;
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            textBox4.Text = "" + e.KeyCode;
            MessageBox.Show("Đã thay đổi hotkey!!!", "Thành công");
            kmglobal.phai = "" + e.KeyCode;
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.SelectionLength = 0;
        }

        private void textBox2_MouseMove(object sender, MouseEventArgs e)
        {
            textBox2.SelectionLength = 0;
        }

        private void textBox3_MouseMove(object sender, MouseEventArgs e)
        {
            textBox3.SelectionLength = 0;
        }

        private void textBox4_MouseMove(object sender, MouseEventArgs e)
        {
            textBox4.SelectionLength = 0;
        }
    }
}
