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
    public partial class My_Profile : Form
    {
        string s;
        all_restaurants past;
        making_reservation past1;
        my_reservations past2;
        Form1 f;
        public My_Profile()
        {
            InitializeComponent();
        }
        public My_Profile(Form1 past,string source)
        {
            InitializeComponent();
            f = past;
            s = source;
        }
        public My_Profile(all_restaurants _past, string source)
        {
            InitializeComponent();
            past = _past;
            s = source;
        }
        public My_Profile(making_reservation _past, string source)
        {
            InitializeComponent();
            past1 = _past;
            s = source;
        }
        public My_Profile(my_reservations _past, string source)
        {
            InitializeComponent();
            past2 = _past;
            s = source;
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (s == "Home")
            {
                f.Close();
            }
            else if (s == "Restaurants")
            {
                past.Close();
            }
            else if(s== "Making Reservation")
            {
                past1.Close();
            }
            else if (s == "My_reservation")
            {
                past2.Close();
            }
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
            if (s == "Home")
            {
                f.Show();
                f.Form1_Load(f, e);
            }
            else if (s == "Restaurants")
            {
                past.Show();
                past.all_restaurants_Load(past, e);
            }
            else if (s == "Making Reservation")
            {
                past1.Show();
                past1.making_reservation_Load(past1, e);
            }
            else if (s == "My_reservation")
            {
                past2.Show();
                past2.my_reservations_Load(past2, e);
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
                 Code here
                 */
            if (s == "Home")
            {
                f.Show();
                f.Form1_Load(f, e);
            }
            else if (s == "Restaurants")
            {
                past.Show();
                past.all_restaurants_Load(past, e);
            }
            else if (s == "Making Reservation")
            {
                past1.Show();
                past1.making_reservation_Load(past1, e);
            }
            else if (s == "My_reservation")
            {
                past2.Show();
                past2.my_reservations_Load(past2, e);
            }
            this.Hide();
        }

        private void My_Profile_Load(object sender, EventArgs e)
        {
            /*
             Code here
             */
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

        private void button2_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }
    }
}
