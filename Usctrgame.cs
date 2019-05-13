using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace baigiuaky
{
    public partial class Usctrgame : UserControl
    {
        // khai bao bien
        int[] duocdi = new int[20];// kiểm tra hướng di chuyển
        SoundPlayer sound1 = new SoundPlayer(Properties.Resources.click_x);
        SoundPlayer sound2 = new SoundPlayer(Properties.Resources.burp_x);
        int co = 0, dem = 0;
        int n, m;// hàng và cột
        TimeSpan time;
        Random random;
        public Usctrgame()
        {
            InitializeComponent();
            n = m = 4;
        }

        public void xoa()
        {
            this.Dispose();
        }
        private int otrong()
        {
            int i;
            for (i = 0; i <= n * m; i++)
                if (((PictureBox)this.Controls["pictureBox" + i]).Image == null)
                    break;
            return i;
        }
        private void timhuong()// rà soát hướng đi và đưa vào biến được đi những ô có thể di chuyển bằng số 1
        {
            int i = otrong();// biến đếm ô
            int duoi = i + m;
            for (int j = 0; j <= n * m; j++)// reset lại mảng chưa các biến di chuyển
                duocdi[j] = 0;
            if (i - m > 0)// fix lỗi di chuyển ra ngoài biên trên
            {
                duocdi[i - m] = 1;
            }
            if (i + m <= n * m) // fix lỗi di chuyển ra ngoài biên dưới
            {
                duocdi[i + m] = 1;
            }

            if (((i - 1) % m != 0 & i - 1 > 0) | i == 1)// fix lỗi di chuyển ra ngoài biên trái
            {
                duocdi[i - 1] = 1;
            }
            if (i % m != 0 & i < n * m)// fix lỗi di chuyển ra ngoài biên phải
            {
                duocdi[i + 1] = 1;
            }
            if (i == 0) // fix lỗi di chuyển sai khi ở ô số 0
            {
                duocdi[1] = 1;
                duocdi[duoi] = 0;

            }
        }
        private void dichuyen(int k)// bắt đầu các thao tác khi xảy ra 1 di chuyển
        {
            int i = otrong();// tìm đến ô không chứa hình
            if (duocdi[k] == 1)
            {
                if (co == 1)// kiểm tra xem game có đang được bắt đầu hay không
                {
                    dem += 1;
                    labBuocdi.Text = "Bước đi : " + dem;
                }
                // thay đổi hình ảnh của 2 ô cho nhau
                hoandoi(((PictureBox)this.Controls["pictureBox" + i]), ((PictureBox)this.Controls["pictureBox" + k]));
            }
            if (luatchoi() == 1)
            {
                timertinhgio.Stop();
                MessageBox.Show("Chúc mừng bạn đã chiến thắng!!");
                co = 0;
            }


        }
        protected int luatchoi()// hàm luật chơi
        {
            if (co == 0)// loại trường hợp chưa bắt đầu
                return 0;
            // vòng lặp so sánh hình ảnh với ảnh được gắn sẵn
            for (int i = 1; i <= n * m; i++)
                if (((PictureBox)this.Controls["pictureBox" + i]).Image != ((PictureBox)this.Controls["pictureBox" + i]).Tag)
                    return 0;
            return 1;
        }
        private void hoandoi(PictureBox pic1, PictureBox pic2)// hàm thay đổi 2 ảnh cho nhau
        {
            if (pic1.Image == null)
                pic1.Image = pic2.Image;
            pic2.Image = null;

        }
        protected void nhapchuot(object sender, EventArgs e)// xử lý nhấp chuột vào vùng chơi
        {
            PictureBox clicked = (PictureBox)sender; //tạo đối tượng chứa
            //khi chua bat dau game
            if (co == 0)
            {
                reset();
                for (int k = 1; k <= n * m; k++)
                    ((PictureBox)this.Controls["pictureBox" + k]).Tag = ((PictureBox)this.Controls["pictureBox" + k]).Image;
                for (int xt = 1; xt <= 1000; xt++)
                    xaotron();
                co = 1;
                return;
            }
            timertinhgio.Start();
            if (clicked.Image == null)// loại bỏ trường hợp chọn vào ô trống
                return;
            clicked.BackColor = Color.Red;// dùng màu nền để đánh dấu ô vừa chọn
            int i;// tạo biến đếm
            for (i = 0; i <= n * m; i++)// khởi động vòng lặp để đếm
                if (((PictureBox)this.Controls["pictureBox" + i]).BackColor == Color.Red)// chạy đến khi gặp ô đã đánh dấu trước đó
                {
                    clicked.BackColor = Color.Lavender;// trả lại màu nền
                    break;// thoát vòng lặp để giữ biến đếm
                }
            timhuong();// làm mới các hướng được phép di chuyển
            if (duocdi[i] == 1)// kiểm tra biến di chuyển thể thực hiện di chuyển
            {
                dichuyen(i);
                sound1.Play();
            }
            else
                sound2.Play();
        }

        private void timertinhgio_Tick(object sender, EventArgs e)
        {
            time = time.Add(new TimeSpan(0, 0, -1));
            labThoigian.Text = string.Format("Thời gian: {0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);
            if (time.Hours == 0)
                labThoigian.ForeColor = Color.Red;
        }
        protected void xaotron()// di chuyển theo hướng ngẫu nhiên
        {
            timhuong();// xác định hướng có thể di chuyển
            int a;
            do
            {
                a = random.Next(n * m);
            } while (duocdi[a] != 1);// chọn ngẫu nhiên đến khi nào dừng ở ô có thể di chuyển
            dichuyen(a);//di chuyển 2 ô
                
        }
        protected void reset()
        {
            co = 0;
            dem = 0;
            timertinhgio.Stop();
            labBuocdi.Text = string.Format("Bước đi: 0");
            labThoigian.Text = string.Format("Thời gian: 00:00:00");
            labThoigian.ForeColor = Color.Black;
            time = new TimeSpan(5, 0, 0);
            random = new Random();
        }

        private void picMau_Click(object sender, EventArgs e)
        {
            xoa();
        }
        public void pause(int a)
        {
            if (a == 1)
            {
                co = 0;
                timertinhgio.Stop();
            }
        }

    }

}
