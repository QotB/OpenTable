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
    public partial class reservation : UserControl
    {
        my_reservations m_r;
        string s,res_name, first_name, last_name, phone, E_mail, date, time, number_of_people, occasion, dining_points, reservation_state;
        bool dining_points_option;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
             Code here
             */
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
        public reservation()
        {
            InitializeComponent();
        }
        public reservation(my_reservations f,string _res_name,string _first_name,string _last_name,string _phone,string _E_mail,string _date,string _time,string _number_of_people,string _occasion,string _dining_points,bool _dining_points_option,string source)
        {
            InitializeComponent();
            m_r = f;
            res_name = _res_name;
            first_name = "First Name: "+_first_name;
            last_name = "Last Name: "+_last_name;
            phone = "Phone: "+_phone;
            E_mail = "E_mail"+_E_mail;
            date = _date;
            time = _time;
            number_of_people = _number_of_people +" Persons";
            occasion = "Occasion"+_occasion;
            dining_points = _dining_points;
            dining_points_option= _dining_points_option;
            s = source;
        }
        private void reservation_Load(object sender, EventArgs e)
        {
            if(s== "My_reservation")
            {
                label1.Text = res_name;
                label12.Text = first_name;
                label11.Text = last_name;
                label8.Text = phone;
                label9.Text = E_mail;
                label4.Text = date;
                label2.Text = time;
                label5.Text = number_of_people;
                label3.Text = occasion;
                label6.Text = dining_points;
                checkBox1.Enabled = false;
                checkBox1.Checked = dining_points_option;
                button2.Visible = false;
                button1.Location = new Point(button1.Location.X, button2.Location.Y);
                this.Height -= 30;

            }
        }
    }
}
