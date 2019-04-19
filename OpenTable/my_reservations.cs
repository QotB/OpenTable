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
    public partial class my_reservations : Form
    {
        string s;
        Form1 past;
        all_restaurants past1;
        making_reservation past2;
        public my_reservations()
        {
            InitializeComponent();
        }
        public my_reservations(Form1 f,string source)
        {
            InitializeComponent();
            s = source;
            past = f;
        }
        public my_reservations(all_restaurants f,string source)
        {
            InitializeComponent();
            s = source;
            past1 = f;
        }
        public my_reservations(making_reservation f,string source)
        {
            InitializeComponent();
            s = source;
            past2 = f;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            this.my_reservations_Load(this, e);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void my_reservations_Load(object sender, EventArgs e)
        {
            if (log_in.logged_in == true)
            {
                label3.Text = "hello, " + log_in.User_Email;
                label3.Visible = true;
                bunifuImageButton3.Visible = true;
            }
            else
            {
                label3.Visible = false;
                bunifuImageButton3.Visible = false;
            }
            for(int i=0;i<4;i++)
            {
                flowLayoutPanel1.Controls.Add(new reservation(this, "Bella","ahmed","saadallah","123123","ahmed@yahoo.com", DateTime.Now.ToString(),"12:00 AM","2","Birthday","1000",true,"My_reservation"));
            }
            for (int i = 0; i < 4; i++)
            {
                flowLayoutPanel1.Controls.Add(new unconfirmed_reservation(this,1, "Bella", DateTime.Now,2, "ahmed", "saadallah", "123123", "ahmed@yahoo.com", "Birthday", false));
            }
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
            //f.Close();
            this.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == true)
                panel4.Visible = false;
            else if (panel4.Visible == false)
                panel4.Visible = true;
        }

        private void Sign_in_button_Click(object sender, EventArgs e)
        {
            Sign_in s = new Sign_in(this, "My_reservation");
            s.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            log_in.logged_in = false;
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
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            My_Profile m_p = new My_Profile(this, "My_reservation");
            m_p.Show();
            this.Hide();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
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
                this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(this);
            f.Show();
            this.Hide();
        }

        private void Sign_up_button_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void bunifuImageButton3_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void bunifuImageButton3_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void button12_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void bunifuImageButton6_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void bunifuImageButton6_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }
    }
}
