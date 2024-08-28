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
    public partial class DiemCao : Form
    {
        public DiemCao()
        {
            InitializeComponent();

        }
        int i = Form3.finalscore;
        private void DiemCao_Load(object sender, EventArgs e)
        {
            if (i > int.Parse(label20.Text) && i <= int.Parse(label21.Text))
            {
                label11.Text = Form2.global.Ten;
                label20.Text = i.ToString();
               
            }
            else if (i > int.Parse(label21.Text) && i <= int.Parse(label22.Text))
            {
                label12.Text = Form2.global.Ten;
                label21.Text = i.ToString();
            }
            else if (i > int.Parse(label22.Text) && i <= int.Parse(label23.Text))
            {
                label13.Text = Form2.global.Ten;
                label22.Text = i.ToString();
            }
            else if (i > int.Parse(label23.Text) && i <= int.Parse(label24.Text))
            {
                label14.Text = Form2.global.Ten;
                label23.Text = i.ToString();
            }
            else if (i > int.Parse(label24.Text) && i <= int.Parse(label25.Text))
            {
                label15.Text = Form2.global.Ten;
                label24.Text = i.ToString();
            }
            else if (i > int.Parse(label25.Text) && i <= int.Parse(label26.Text))
            {
                label16.Text = Form2.global.Ten;
                label25.Text = i.ToString();
            }
            else if (i > int.Parse(label26.Text) && i <=int.Parse(label27.Text))
            {
                label17.Text = Form2.global.Ten;
                label26.Text = i.ToString();
            }
            else if (i > int.Parse(label27.Text) && i <= int.Parse(label28.Text))
            {
                label18.Text = Form2.global.Ten;
                label27.Text = i.ToString();
            }
            else if (i > int.Parse(label28.Text))
            {
                label19.Text = Form2.global.Ten;
                label28.Text = i.ToString();
            };
        }
    }
}
