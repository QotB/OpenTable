using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenTable
{
    public partial class Sign_in : Form
    {
        string s;
        Form1 past;
        all_restaurants past1;
        making_reservation past2;
        my_reservations past3;
        public Sign_in()
        {
            InitializeComponent();
        }
        public Sign_in(Form1 f,string source)
        {
            InitializeComponent();
            s = source;
            past = f;
        }
        public Sign_in(all_restaurants f, string source)
        {
            InitializeComponent();
            s = source;
            past1 = f;
        }
        public Sign_in(making_reservation f, string source)
        {
            InitializeComponent();
            s = source;
            past2 = f;
        }
        public Sign_in(my_reservations f, string source)
        {
            InitializeComponent();
            s = source;
            past3 = f;
        }
        private void Sign_in_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void bunifuImageButton2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void bunifuImageButton1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void bunifuImageButton1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            if (s == "Home")
            {
                past.Close();
            }
            else if (s == "Restaurants")
            {
                past1.Close();
            }
            else if(s== "Making Reservation")
            {
                past2.Close();
            }
            else if (s == "My_reservation")
            {
                past3.Close();
            }
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (s == "Home")
            {
                past.Show();
                past.Form1_Load(past, e);
            }
            else if (s == "Restaurants")
            {
                past1.Show();
                past1.all_restaurants_Load(past1, e);
            }
            else if (s == "Making Reservation")
            {
                past2.Show();
                past2.making_reservation_Load(past2, e);
            }
            else if (s == "My_reservation")
            {
                past3.Show();
                past3.my_reservations_Load(past3, e);
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
                 Code here
                 */
            if (bunifuMetroTextbox1.Text=="ahmed"&&bunifuMetroTextbox2.Text=="ahmed")
            {
                log_in.logged_in = true;
                log_in.User_Email = bunifuMetroTextbox1.Text;
                if (s == "Home")
                {
                    past.Show();
                    past.Form1_Load(past, e);
                }
                else if (s == "Restaurants")
                {
                    past1.Show();
                    past1.all_restaurants_Load(past1, e);
                }
                else if (s == "Making Reservation")
                {
                    past2.Show();
                    past2.making_reservation_Load(past2, e);
                }
                else if (s == "My_reservation")
                {
                    past3.Show();
                    past3.my_reservations_Load(past3, e);
                }
                this.Hide();
            }

        }

        private void Sign_in_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (s == "Home")
            {
                past.Close();
            }
            if (s == "Restaurants")
            {
                past1.Close();
            }
            if (s == "Making Reservation")
            {
                past2.Close();
            }
        }
    }
}
