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
    public partial class CinemaRoom : Form
    {
        public CinemaRoom()
        {
            InitializeComponent();
        }
        public int yerSayi = 9;
        public int topPpos = 30;
        public int LeftPos = 0;
        int count = 1;
        public List<Button> btn_list = new List<Button>();
        private void CinemaRoom_Load(object sender, EventArgs e)
        {
            for (int row = 1; row <= yerSayi; row++)
            {
                LeftPos = 31;
                topPpos += 40;
                for (int column = 1; column <= yerSayi; column++)
                {
                    var btn = new Button();
                    btn.Width = 40;
                    btn.Height = 40;
                    btn.Left = LeftPos;
                    btn.Top = topPpos;
                    btn.Text = (column + "");
                    btn.BackColor = Color.White;
                    LeftPos += btn.Width;
                    Controls.Add(btn);
                    btn.Click += new System.EventHandler(this.Btn_Click); ;
                }
            }
        }

        private void Btn_Click (object sender, EventArgs e)
        {
            Button myBtn = sender as Button;
            if (DataTime.sel_it < count)
            {
                MessageBox.Show("Artiq secim ede bilmersiz");
            }
            else if (myBtn.BackColor == Color.Yellow)
            {
                MessageBox.Show("zanit");
                myBtn.BackColor = Color.Yellow;
            }
            else if (myBtn.BackColor == Color.DarkGray)
            {

                myBtn.BackColor = Color.White;
                if (myBtn.BackColor == Color.White)
                {
                    count--;
                    btn_list.Remove(myBtn);
                }
            }
            else
            {
                count++;
                myBtn.BackColor = Color.DarkGray;

                if (myBtn.BackColor == Color.DarkGray)
                {
                    btn_list.Add(myBtn);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in btn_list)
            {
                item.BackColor = Color.Yellow;
            }
        }
    }
}
