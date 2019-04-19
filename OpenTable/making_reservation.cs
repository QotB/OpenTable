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
    public partial class making_reservation : Form
    {
        string s;
        string res_name,number_of_people;
        DateTime date;
        all_restaurants past;
        Restaurant_Profile past1;
        public making_reservation()
        {
            InitializeComponent();
        }
        public making_reservation(string source,all_restaurants a_r,string _res_name,DateTime _date,string _number_of_people)
        {
            InitializeComponent();
            past = a_r;
            res_name = _res_name;
            date = _date;
            number_of_people=_number_of_people;
            s = source;
        }
        public making_reservation(string source, Restaurant_Profile r, string _res_name, DateTime _date, string _number_of_people)
        {
            InitializeComponent();
            past1 = r;
            res_name = _res_name;
            date = _date;
            number_of_people = _number_of_people;
            s = source;
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

        private void Sign_in_button_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Sign_in_button_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void Sign_up_button_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Sign_up_button_MouseLeave(object sender, EventArgs e)
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

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            past.Close();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            log_in.logged_in = false;
            this.making_reservation_Load(this, e);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == true)
                panel4.Visible = false;
            else if (panel4.Visible == false)
                panel4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            My_Profile m_p = new My_Profile(this, "Making Reservation");
            m_p.Show();
            this.Hide();
        }

        private void Sign_in_button_Click(object sender, EventArgs e)
        {
            Sign_in s = new Sign_in(this, "Making Reservation");
            s.Show();
            this.Hide();
        }

        private void Sign_up_button_Click(object sender, EventArgs e)
        {
            Sign_up s = new Sign_up(this, "Making Reservation");
            s.Show();
            this.Hide();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            
            if (s == "Restaurants")
            {
                past.Show();
                past.all_restaurants_Load(past, e);
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(this);
            f.Show();
            this.Hide();
        }

        private void making_reservation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (s == "Restaurants")
            {
                past.Close();
            }
            
        }

        private void making_reservation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (s == "Restaurants")
            {
                past.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
                 Code here
                 */
            Form1 f = new Form1(past);
            f.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            my_reservations m_r = new my_reservations(this, "Making Reservation");
            m_r.Show();
            this.Hide();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

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

        private void button2_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        public void making_reservation_Load(object sender, EventArgs e)
        {
            /*
                 Code here
                 */
            panel4.Visible = false;
            if (log_in.logged_in == true)
            {
                label3.Text = "hello, " + log_in.User_Email;
                label3.Visible = true;
                bunifuImageButton3.Visible = true;
                Sign_in_button.Visible = false;
                Sign_up_button.Visible = false;
                button2.Location = new Point(button2.Location.X, checkBox1.Location.Y);
                panel5.Height = panel5.Height-10;
                panel5.Location = new Point (panel5.Location.X,label10.Location.Y);
                this.Height=panel5.Location.Y+panel5.Height;
                bunifuMetroTextbox5.Enabled = false;
                bunifuMetroTextbox5.Text = "ahmed@yahoo.com";
            }
            else
            {
                label3.Visible = false;
                bunifuImageButton3.Visible = false;
                Sign_in_button.Visible = true;
                Sign_up_button.Visible = true;
                button2.Location = new Point(button2.Location.X, checkBox1.Location.Y+20);
                panel5.Height = panel5.Height ;
                panel5.Location = new Point(panel5.Location.X, label10.Location.Y+70);
                this.Height = panel5.Location.Y + panel5.Height+20;
                bunifuMetroTextbox5.Enabled = true;
            }
            label1.Text = res_name;
            string[] arr= date.ToString().Split(' ');
            label4.Text = arr[0];
            label2.Text = arr[1];
            label5.Text = number_of_people+" persons";

        }
    }
}
