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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            var card1 = new Cards("Master");
            var card2 = new Cards("Visa");
            var card3 = new Cards("Maestro");
            foreach (var item in Cards.myCards)
            {
                card_box.Items.Add(item.Name);
            }
        }

        private void end_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Emeliyyat ughurla basha chatdi");
        }
    }
    class Cards
    {
        public static List<Cards> myCards = new List<Cards>();
        public string Name;
        public Cards(string _name)
        {
            this.Name = _name;
            myCards.Add(this);
        }
    }
}
