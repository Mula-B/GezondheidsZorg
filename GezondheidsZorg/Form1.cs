using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GezondheidsZorg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Database connect = new Database();
        int index;

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> lijst = new List<string>() { "Klant", "Arts" };
            Dropdown.DataSource = lijst;

            Btn_filter_Click(sender, e);
        }


        private void Btn_filter_Click(object sender, EventArgs e)
        {
            index = Dropdown.SelectedIndex;





        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }


    }
}
