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
    public partial class Form1 : Form
    {
        all_restaurants past ;
        making_reservation past1;
        my_reservations past2;
        string s = "";
        public Form1()
        {
            InitializeComponent();
            log_in.store();
        }
        public Form1(all_restaurants a)
        {
            InitializeComponent();
            past = a;
            s = "all_restaurants";
            log_in.occasions.Add("Birthday", 0);
            log_in.occasions.Add("Anniversary", 1);
            log_in.occasions.Add("Date night", 2);
            log_in.occasions.Add("Business Meal", 3);
            log_in.occasions.Add("Celebration", 4);
        }
        public Form1(making_reservation m_r)
        {
            InitializeComponent();
            past1 =m_r ;
            s = "Making Reservation";
        }
        public Form1(my_reservations f)
        {
            InitializeComponent();
            past2 = f;
            s = "My_reservation";
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            /*
             Code here
             */
            label1.Location =new Point((panel1.Width / 2)-(label1.Width/2),panel1.Location.Y+panel1.Height+15);
            bunifuDropdown2.selectedIndex = 0;
            bunifuDropdown1.selectedIndex = 0;
            bunifuDatepicker1.Value = DateTime.Now;
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < 4; i++)
                flowLayoutPanel1.Controls.Add(new pop_restaurant("Bella","97",10,"italian","$$","cairo",4));
            if (log_in.logged_in == true)
            {
                label3.Text = "hello, " + log_in.User_Email;
                label3.Visible = true;
                bunifuImageButton3.Visible = true;
                Sign_in_button.Visible = false;
                Sign_up_button.Visible = false;
                panel3.Visible = false;
            }
            else
            {
                label3.Visible = false;
                bunifuImageButton3.Visible = false;
                Sign_in_button.Visible = true;
                Sign_up_button.Visible = true;
                panel3.Visible = false;
            }
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button4.Visible = true;
            Cursor = Cursors.Hand;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button4.Visible = false;
            Cursor = Cursors.Arrow;
        }

        private void Sign_in_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Sign_in_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void Sign_up_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Sign_up_MouseLeave(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Form1_Load(this,e);           
        }


        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (s == "Restaurants")
            {
                past.Close();
            }
            else if (s == "Making Reservation")
            {
                past1.Close();
            }
            else if (s == "My_reservation")
            {
                past2.Close();
            }
            this.Close();
        }

        private void bunifuImageButton2_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void bunifuImageButton2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void Sign_up_Click(object sender, EventArgs e)
        {
            Sign_up s = new Sign_up(this,"Home");
            s.Show();
            this.Hide();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Sign_in_button_Click(object sender, EventArgs e)
        {
            Sign_in s = new Sign_in(this,"Home");
            s.Show();
            this.Hide();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == true)
                panel3.Visible = false;
            else if (panel3.Visible == false)
                panel3.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            My_Profile m_p = new My_Profile(this, "Home");
            m_p.Show();
            this.Hide();
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
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

        private void button5_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            log_in.logged_in = false;
            this.Form1_Load(this, e);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bunifuDatepicker1.Value.ToShortDateString().ToString());
           
           /*
            CODE HERE
            */
            string[] arr = bunifuDatepicker1.Value.ToString().Split(' ');
            all_restaurants a = new all_restaurants(this,"Home","specified search",arr[0]+" "+bunifuDropdown2.selectedValue,bunifuDropdown1.selectedValue);
            a.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
                CODE HERE
            */
            all_restaurants f = new all_restaurants(this,"Home");
            f.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (s == "all_restaurants")
                past.Close();
            if (s == "Making Reservation")
                past1.Close();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (s == "all_restaurants")
                past.Close();
            if (s == "Making Reservation")
                past1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            my_reservations m_r = new my_reservations(this,"Home");
            m_r.Show();
            this.Hide();
        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {

        }
    }
}
