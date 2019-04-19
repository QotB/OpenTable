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
    public partial class all_restaurants : Form
    {
        Form1 past;
        string s="", type="", date, number_of_people;
        public all_restaurants()
        {
            InitializeComponent();
            
        }

        public all_restaurants(Form1 f,string source)
        {
            InitializeComponent();
            past = f;
            s = source;
        }
        public all_restaurants(Form1 f, string _source,string _type,string _date,string _number_of_people)
        {
            InitializeComponent();
            past = f;
            s = _source;
            type = _type;
            _date = date;
            number_of_people = _number_of_people;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(this);
            f.Show();
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            past.Close();
            this.Close();
        }

        public void all_restaurants_Load(object sender, EventArgs e)
        {
            bunifuDropdown1.selectedIndex = 0;
            bunifuDropdown2.selectedIndex = 0;
            bunifuDatepicker1.Value = DateTime.Now;
            for (int i = 0; i < 4; i++)
                flowLayoutPanel1.Controls.Add(new Restaurant(this,"Bella", "97", 10, "italian", "$$", "cairo", 4));
            if (log_in.logged_in == true)
            {
                label3.Text = "hello, " + log_in.User_Email;
                label3.Visible = true;
                bunifuImageButton3.Visible = true;
                Sign_in_button.Visible = false;
                Sign_up_button.Visible = false;
                panel3.Visible = false;
                bunifuImageButton1.Visible = true;

            }
            else
            {
                label3.Visible = false;
                bunifuImageButton3.Visible = false;
                Sign_in_button.Visible = true;
                Sign_up_button.Visible = true;
                panel3.Visible = false;
                bunifuImageButton1.Visible = false;
            }
            if(type== "specified search")
            {

            }
            else
            {

            }
            /*
             
            */
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == true)
                panel3.Visible = false;
            else if (panel3.Visible == false)
                panel3.Visible = true;
        }

        private void Sign_in_button_Click(object sender, EventArgs e)
        {
            Sign_in s = new Sign_in(this, "Restaurants");
            s.Show();
            this.Hide();
        }

        private void Sign_up_button_Click(object sender, EventArgs e)
        {
            Sign_up s = new Sign_up(this, "Restaurants");
            s.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (s == "Home")
            {
                past.Show();
                past.Form1_Load(past, e);
                this.Hide();
            }
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            label2.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            label2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            label4.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            label4.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            label5.Visible = true;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            label5.Visible = false;
        }

        private void all_restaurants_FormClosed(object sender, FormClosedEventArgs e)
        {
            past.Close();
        }

        private void all_restaurants_FormClosing(object sender, FormClosingEventArgs e)
        {
            past.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
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

        private void button6_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
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

        private void bunifuImageButton1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            log_in.logged_in = false;
            this.all_restaurants_Load(this, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            My_Profile m_p = new My_Profile(this, "Home");
            m_p.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
                 Code here
                 */
            string[] arr = bunifuDatepicker1.Value.ToString().Split(' ');
            date = arr[0]+" "+bunifuDropdown2.selectedValue;
            number_of_people = bunifuDropdown1.selectedValue.ToString();
            this.all_restaurants_Load(this,e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            my_reservations m_r = new my_reservations(this, "Restaurants");
            m_r.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void bunifuDropdown4_onItemSelected(object sender, EventArgs e)
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
