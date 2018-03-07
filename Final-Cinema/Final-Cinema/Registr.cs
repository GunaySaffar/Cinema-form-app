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
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
        }

        private void registr_btn_Click(object sender, EventArgs e)
        {
            
            string name = name_regist.Text;
            string email = email_regist.Text;
            string username = username_regist.Text;
            string password = password_regist.Text;
            string conf_pass = conf_pass_regist.Text;
            User users = new User(name, email, username, password);
            if (password==conf_pass)
            {
                Form1 form_1 = new Form1();
                form_1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sifreler ust uste dushmur");
            }
        }

        private void Registr_Load(object sender, EventArgs e)
        {

        }
    }
    class User
    {
        public static List<User> users_list = new List<User>();
        public string Name;
        public string Email;
        public string Username;
        public string Password;
        public User(string _name,string _email,string _username,string _pass)
        {
            Name = _name;
            Email = _email;
            Username = _username;
            Password = _pass;
            users_list.Add(this);
        }
    }
}
