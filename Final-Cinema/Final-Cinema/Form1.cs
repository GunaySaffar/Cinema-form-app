using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            var user_login= log_user.Text;
            var pass_login = log_pass.Text;
            foreach (var item in User.users_list)
            {
                if (user_login == item.Username && pass_login == item.Password && user_login != null && pass_login != null)
                {
                    Movies movies_form = new Movies();
                    movies_form.Show();
                    this.Hide();
                }
                else
                {
                    error_label.Text = "*Enter correct username or password";
                }
            }
        }

        private void registr_btn_Click(object sender, EventArgs e)
        {
            Registr form_regist = new Registr();
            form_regist.Show();
            this.Hide();
        }
    }
}
