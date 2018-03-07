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
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            
        }
        public static string select_cinema;

        private void button1_Click(object sender, EventArgs e)
        {
            select_cinema = film1.Text;
            var kino1 = new Cinema(1, "Me Before You");
            kino1.AddDate("12 mart");
            kino1.AddDate("15 mart");
            kino1.AddDate("18 mart");
            kino1.AddDate("19 mart");
            kino1.AddTime("15:00");
            kino1.AddTime("17:00");
            kino1.AddTime("19:00");
            var date_time = new DataTime();
            date_time.Show();
            this.Hide();
        }

        private void film2_Click(object sender, EventArgs e)
        {
            select_cinema = film2.Text;
            var kino2 = new Cinema(2, "Pride&Prejudice");
            kino2.AddDate("11 mart");
            kino2.AddDate("12 mart");
            kino2.AddDate("17 mart");
            kino2.AddDate("28 mart");
            kino2.AddTime("15:00");
            kino2.AddTime("17:00");
            kino2.AddTime("19:00");
            var date_time = new DataTime();
            date_time.Show();
            this.Hide();
        }

        private void film3_Click(object sender, EventArgs e)
        {
            select_cinema = film3.Text;
            var kino3 = new Cinema(3, "Dear John");
            kino3.AddDate("11 mart");
            kino3.AddDate("12 mart");
            kino3.AddDate("17 mart");
            kino3.AddDate("27 mart");
            kino3.AddTime("15:00");
            kino3.AddTime("17:00");
            kino3.AddTime("19:00");
            var date_time = new DataTime();
            date_time.Show();
            this.Hide();
        }

        private void film4_Click(object sender, EventArgs e)
        {
            select_cinema = film4.Text;
            var kino4 = new Cinema(4, "The Best Of Me");
            kino4.AddDate("11 mart");
            kino4.AddDate("22 mart");
            kino4.AddDate("17 mart");
            kino4.AddDate("23 mart");
            kino4.AddTime("15:00");
            kino4.AddTime("17:00");
            kino4.AddTime("19:00");
            var date_time = new DataTime();
            date_time.Show();
            this.Hide();
        }

        private void film5_Click(object sender, EventArgs e)
        {
            select_cinema = film5.Text;
            var kino5 = new Cinema(5, "Lalaland");
            kino5.AddDate("11 mart");
            kino5.AddDate("12 mart");
            kino5.AddDate("17 mart");
            kino5.AddDate("24 mart");
            kino5.AddTime("15:00");
            kino5.AddTime("17:00");
            kino5.AddTime("19:00");
            var date_time = new DataTime();
            date_time.Show();
            this.Hide();
        }
    }
    class Cinema
    {
        public static List<Cinema> movieList = new List<Cinema>();
        public int Id;
        public string movieName;
        public List<string> movieDate1 = new List<string>();
        public List<string> movieTime1 = new List<string>();
        public Cinema(int _id, string _moviename)
        {
            Id = _id;
            movieName = _moviename;
            movieList.Add(this);
        }
        public void AddDate(string _date)
        {
            movieDate1.Add(_date);
        }
        public void AddTime(string _time)
        {
            movieTime1.Add(_time);
        }
    }
}
