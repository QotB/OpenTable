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
    public partial class Restaurant_Profile : Form
    {
        string s,res_name;
        all_restaurants past;
        public Restaurant_Profile()
        {
            InitializeComponent();
        }
        public Restaurant_Profile(string source,all_restaurants a_r,string _res_name)
        {
            InitializeComponent();
            s = source;
            past = a_r;
            res_name = _res_name;
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Restaurant_Profile_Load(object sender, EventArgs e)
        {
            /*
             Code Here
             */
            bunifuDropdown2.selectedIndex = 0;
            bunifuDropdown1.selectedIndex = 0;
            bunifuDatepicker1.Value = DateTime.Now;
            
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

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            making_reservation m_r = new making_reservation("Restaurant_profile", this, res_name, bunifuDatepicker1.Value,bunifuDropdown1.selectedValue);
            m_r.Show();
            this.Hide();    
        }
    }
}
