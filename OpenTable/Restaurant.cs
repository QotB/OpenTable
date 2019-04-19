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
    public partial class Restaurant : UserControl
    {
        all_restaurants past1;
        string res_name;
        public Restaurant()
        {
            InitializeComponent();
        }
        public Restaurant(all_restaurants a_r,string restaurant_name, string rating, int number_of_reviews, string cusine, string average_price, string location, int Number_of_reservations)
        {
            InitializeComponent();
            label1.Text = restaurant_name;
            label2.Text = rating + "% recommended | " + number_of_reviews.ToString() + "reviews";
            label3.Text = cusine + " | " + average_price + " | " + location;
            label4.Text = "booked " + Number_of_reservations.ToString() + " times today";
            past1 = a_r;
            for (int i = 0; i < 4; i++)
                flowLayoutPanel1.Controls.Add(new specific_time(a_r,"Bella","12:00 AM", 1000));
            for (int i = 0; i < 4; i++)
                flowLayoutPanel1.Controls.Add(new specific_time(a_r, "Bella", "12:00 AM", 0));
            for (int i = 0; i < 4; i++)
                flowLayoutPanel1.Controls.Add(new specific_time(a_r, "Bella", "12:00 AM", 0));
            res_name = restaurant_name;
            
        }
        
        private void Restaurant_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Restaurant_Profile r = new Restaurant_Profile("Restaurants", past1, res_name);
        }
    }
}
