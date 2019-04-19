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
    public partial class unconfirmed_reservation : UserControl
    {
        my_reservations past;
        int res_id;
        string res_name, first_name, last_name, phone, email, occasion;
         int number_of_people;

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             Code here
             */
            //MessageBox.Show(bunifuDatepicker1.Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
             Code here
             */
        }

        bool Dining_points_option;
        DateTime date;
        public unconfirmed_reservation()
        {
            InitializeComponent();
        }
        public unconfirmed_reservation(my_reservations f,int _res_id,string _res_name,DateTime _date,int _number_of_people,string _first_name,string _last_name,string _phone,string _email,string _occasion,bool _Dining_points_option)
        {
            InitializeComponent();
            res_name = _res_name;
            date = _date;
            number_of_people = _number_of_people;
            first_name = _first_name;
            last_name = _last_name;phone = _phone;
            email = _email;
            occasion = _occasion;
            Dining_points_option = _Dining_points_option;
            res_id = _res_id;
            past = f;
        }
        private void unconfirmed_reservation_Load(object sender, EventArgs e)
        {
            label1.Text = res_name;
            bunifuDatepicker1.Value = date;
            bunifuDropdown3.selectedIndex = number_of_people - 1;
            bunifuMetroTextbox4.Text = first_name;
            bunifuMetroTextbox3.Text = last_name;
            bunifuMetroTextbox1.Text = phone;
            bunifuMetroTextbox5.Text = email;
            bunifuDropdown2.selectedIndex = log_in.occasions[occasion];
            checkBox1.Checked = Dining_points_option;
        }
    }
}
