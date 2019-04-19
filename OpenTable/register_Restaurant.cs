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
    public partial class register_Restaurant : Form
    {
        Form1 past1;
        all_restaurants past2;
        making_reservation past3;
        string s;
        Sign_up temp_past;
        public register_Restaurant()
        {
            InitializeComponent();
        }
        public register_Restaurant(Sign_up s_u,Form1 f,string source)
        {
            InitializeComponent();
            temp_past = s_u;
            past1 = f;
            s = source;
        }
        public register_Restaurant(Sign_up s_u, all_restaurants f, string source)
        {
            InitializeComponent();
            temp_past = s_u;
            past2 = f;
            s = source;
        }
        public register_Restaurant(Sign_up s_u, making_reservation f, string source)
        {
            InitializeComponent();
            temp_past = s_u;
            past3 = f;
            s = source;
        }
        private void register_Restaurant_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            temp_past.Close();
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            temp_past.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
                 Code here
                 */
            if (s=="Home")
            {
                past1.Show();
                past1.Form1_Load(past1, e);
            }
            else if (s == "Restaurants")
            {
                past2.Show();
                past2.all_restaurants_Load(past2, e);
            }
            else if (s == "Making Reservation")
            {
                past3.Show();
                past3.making_reservation_Load(past3, e);
            }
            this.Hide();
        }

        private void bunifuMetroTextbox11_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
