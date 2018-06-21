using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace GezondheidsZorg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new DatabaseContext())
            {


                Dropdown.DataSource





            }
        }





        private void Btn_filter_Click(object sender, EventArgs e)
        {

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

        private void klntAdd_Click(object sender, EventArgs e)
        {
            string klantvoor = klntvoornaam.Text;
            string klantacht = klntachternaam.Text;
            string klantadres = klntadres.Text;
            string klantpostcode = klntpostcode.Text;


        }

        private void artsAdd_Click(object sender, EventArgs e)
        {
            string artsvoor = artsvoornaam.Text;
            string artsacht = artsachternaam.Text;
            string artsadres = artsAdres.Text;
            string artspost = artspostcode.Text;
            string artseind = einddatum.Text;
            DateTime artseinddatum = DateTime.Parse(artseind);

            using (var db = new DatabaseContext())
            {
                var arts = new Arts { Voornaam = artsvoor, Achternaam = artsacht, Adres = artsadres, Postcode = artspost, Einddatum = artseinddatum  };
                db.arts.Add(arts);
                db.SaveChanges();

                var query = from b in db.arts
                            orderby b.ArtsID
                            select b;

                dataGridView1.DataSource = query.ToList();

                            
                        
            }

        }
    }
}
