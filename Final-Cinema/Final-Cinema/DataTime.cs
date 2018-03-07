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
    public partial class DataTime : Form
    {
        public DataTime()
        {
            InitializeComponent();
           
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (date_box.SelectedItem != " ")
            {
                label5.Text = "*You don't select Data ";
            }
            else if (time_box.SelectedItem != " ")
            {
                label6.Text = "*You dont Select Time";
            }
            else if (people_box.Text != null)
            {
                label7.Text = "You dont Select tickets";
            }
            else
            {
                var cinemaRoom = new CinemaRoom();
                cinemaRoom.Show();
                this.Hide();
            }
            
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            var movies1 = new Movies();
            movies1.Show();
            this.Hide();
        }
        public static int sel_it;
        private void people_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            sel_it = Convert.ToInt32(people_box.SelectedItem);
            price_show_box.Text = Convert.ToString(sel_it * 6);
        }

        private void price_show_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataTime_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                people_box.Items.Add(i);
            }
            foreach (var item in Cinema.movieList)
            {
                if (Movies.select_cinema==item.movieName)
                {
                    foreach (var item1 in item.movieDate1)
                    {
                        date_box.Items.Add(item1);
                    }
                    foreach (var item2 in item.movieTime1)
                    {
                        time_box.Items.Add(item2);
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void date_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void time_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
