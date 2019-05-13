using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baigiuaky
{
    public partial class main : Form
    {
        Usctrgame us = new Usctrgame();
        public main()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBatdau_Click(object sender, EventArgs e)
        {
            us.xoa();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            us = new hinh1();
            panGame.Controls.Add(us);
            us.BringToFront();
        }


        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            us = new hinh2();
            panGame.Controls.Add(us);
            us.BringToFront();
        }

        public void User(TextBox user)
        {
            labUser.Text = user.Text;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            us = new hinh4();
            panGame.Controls.Add(us);
            us.BringToFront();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            us = new hinh5();
            panGame.Controls.Add(us);
            us.BringToFront();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            us = new hinh3();
            panGame.Controls.Add(us);
            us.BringToFront();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            us = new hinh6();
            panGame.Controls.Add(us);
            us.BringToFront();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            us = new hinh7();
            panGame.Controls.Add(us);
            us.BringToFront();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            us = new hinh8();
            panGame.Controls.Add(us);
            us.BringToFront();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            us = new hinh9();
            panGame.Controls.Add(us);
            us.BringToFront();
        }

        private void btnHuongdan_Click(object sender, EventArgs e)
        {
            Huongdan hd = new Huongdan();
            hd.ShowDialog();
        }

    }
}
