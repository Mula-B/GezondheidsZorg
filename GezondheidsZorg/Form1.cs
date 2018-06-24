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
            // TODO: This line of code loads data into the '_GezondheidsZorg_DatabaseContextDataSet.Arts' table. You can move, or remove it, as needed.
            this.artsTableAdapter.Fill(this._GezondheidsZorg_DatabaseContextDataSet.Arts);
            using (var db = new DatabaseContext())
            {


                





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

            string arts = artsComboBox.Text;
            string verz = klntVerz.Text;
            string klantvoor = klntvoornaam.Text;
            string klantacht = klntachternaam.Text;
            string klantadres = klntadres.Text;
            string klantpostcode = klntpostcode.Text;

            using(var db = new DatabaseContext())
            {
               
            }
            


            //datagridview2

        }

        private void artsAdd_Click(object sender, EventArgs e)
        {
            if(artsvoornaam.Text + artsachternaam.Text + artsAdres.Text + artspostcode.Text + einddatum.Text == "")
            {
                MessageBox.Show("Geen arts gegevens opgegeven!");
            }

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

                artsvoornaam.Text = string.Empty;
                artsachternaam.Text = string.Empty;
                artsAdres.Text = string.Empty;
                artspostcode.Text = string.Empty;
                einddatum.Text = string.Empty;

            }

        }

        private void Dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Dropdown.SelectedItem == "Arts")
            {
               using (var db = new DatabaseContext())
                {
                    var query = from a in db.arts
                                orderby a.ArtsID
                                select a;

                    dataGridView1.DataSource = query.ToList();
                }
            }
            else
            {
                using (var db = new DatabaseContext())
                {
                    var query = from k in db.klant
                                orderby k.KlantID
                                select k;

                    dataGridView1.DataSource = query.ToList();
                }
            }
        }

        private void artsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new DatabaseContext())
            {
                artsComboBox.ValueMember = "ArtsID";
                artsComboBox.DisplayMember = "Achternaam";
                artsComboBox.DataSource = db.arts;
                
            }

            
        }
        //Verwijder TODO
        private void verwijderRow_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Btn_contract_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());

            DateTime newDate = date.AddYears(1);

            
        }
    }
}
    

