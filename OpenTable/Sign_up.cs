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
    public partial class Sign_up : Form
    {
        Form1 past;
        all_restaurants past1;
        making_reservation past2;
        my_reservations past3;
        string s;
        public Sign_up()
        {
            InitializeComponent();
        }
        public Sign_up(Form1 f,string source)
        {
            InitializeComponent();
            s = source;
            past = f;
        }
        public Sign_up(all_restaurants f, string source)
        {
            InitializeComponent();
            s = source;
            past1 = f;
        }
        public Sign_up(making_reservation f, string source)
        {
            InitializeComponent();
            s = source;
            past2 = f;
        }
        public Sign_up(my_reservations f, string source)
        {
            InitializeComponent();
            s = source;
            past3 = f;
        }
        private void bunifuMetroTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Sign_up_Load(object sender, EventArgs e)
        {
            
        }

        private void T_Tick(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
             Code here
             */
            if (s == "Home")
            {
                past.Show();
                past.Form1_Load(past, e);
            }
            else if(s=="Restaurants")
            {
                past1.Show();
                past1.all_restaurants_Load(past1,e);
            }
            else if (s == "Making Reservation")
            {
                past2.Show();
                past2.making_reservation_Load(past2, e);
            }
            this.Hide();
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
            else if (s == "Making Reservation")
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
            if(s=="Home")
            {
                past.Show();
                past.Form1_Load(past,e);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (s == "Home")
            {
                register_Restaurant r = new register_Restaurant(this,past, s);
                r.Show();
            }
            else if (s == "Restaurants")
            {
                register_Restaurant r = new register_Restaurant(this, past1, s);
                r.Show();
            }
            else if (s == "Making Reservation")
            {
                register_Restaurant r = new register_Restaurant(this, past2, s);
                r.Show();
            }
            this.Hide();
        }

        private void Sign_up_FormClosed(object sender, FormClosedEventArgs e)
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

        private void Sign_up_FormClosing(object sender, FormClosingEventArgs e)
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
