using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenTable
{
    public partial class pop_restaurant : UserControl
    {
        public pop_restaurant()
        {
            InitializeComponent();
        }
        public pop_restaurant(string restaurant_name,string rating,int number_of_reviews,string cusine,string average_price,string location,int Number_of_reservations)
        {
            InitializeComponent();
            label1.Text = restaurant_name;
            label2.Text = rating + "% recommended | " + number_of_reviews.ToString() + "reviews";
            label3.Text = cusine + " | " + average_price + " | " + location;
            label4.Text = "booked " + Number_of_reservations.ToString() + " times today";
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
