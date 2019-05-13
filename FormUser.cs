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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }
        private delegate void User(TextBox user);

        private void btnVaogame_Click(object sender, EventArgs e)
        {
            Hide();
            if (txtUser.Text == "")
                txtUser.Text = "Người chơi mới";
            main frm = new main();
            User user = new User(frm.User);
            user(this.txtUser);
            frm.ShowDialog();
            this.Close();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnVaogame_Click(sender, e);
            }
        }

    }
}
