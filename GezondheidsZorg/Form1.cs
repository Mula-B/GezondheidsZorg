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
        DatabaseContext db = new DatabaseContext();

        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.artsen.ToList();

            artsComboBox.ValueMember = "ArtsID";
            artsComboBox.DisplayMember = "Achternaam";
            artsComboBox.DataSource = db.artsen.ToList();
        }
        

        private void Btn_filter_Click(object sender, EventArgs e)
        {
            using (var db = new DatabaseContext())
            {
                if(Dropdown.SelectedItem == "Arts")
                {
                    var query = from a in db.artsen
                                where a.Achternaam.Contains(box_Filter.Text)
                                select a;

                    dataGridView1.DataSource = query.ToList();
                }
                else
                {
                    var query = from k in db.klanten
                                where k.Achternaam.Contains(box_Filter.Text)
                                select k;

                    dataGridView2.DataSource = query.ToList();
                }

                


            }
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
                Klant k = new Klant();

                k.Voornaam = klantvoor;
                k.Achternaam = klantacht;
                k.Adres = klantadres;
                k.Postcode = klantpostcode;

                db.klanten.Add(k);
                db.SaveChanges();

                var query = from a in db.klanten
                            orderby a.KlantID
                            select a;

                dataGridView2.DataSource = query.ToList();

                klntVerz.Text = string.Empty;
                klntvoornaam.Text = string.Empty;
                klntachternaam.Text = string.Empty;
                klntadres.Text = string.Empty;
                klntpostcode.Text = string.Empty;
                

            }
        
        }

        private void artsAdd_Click(object sender, EventArgs e)
        {
            
            string artsvoor = artsvoornaam.Text;
            string artsacht = artsachternaam.Text;
            string artsadres = artsAdres.Text;
            string artspost = artspostcode.Text;
            string artseind = einddatum.Text;
            DateTime artseinddatum = DateTime.Parse(artseind);

            
                var arts = new Arts { Voornaam = artsvoor, Achternaam = artsacht, Adres = artsadres, Postcode = artspost, Einddatum = artseinddatum  };
                db.artsen.Add(arts);
                db.SaveChanges();

                var query = from b in db.artsen
                            orderby b.ArtsID
                            select b;

                dataGridView1.DataSource = query.ToList();

                artsvoornaam.Text = string.Empty;
                artsachternaam.Text = string.Empty;
                artsAdres.Text = string.Empty;
                artspostcode.Text = string.Empty;
                einddatum.Text = string.Empty;


        }

        private void Dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void artsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

                

            
        }
        //Verwijder TODO
        private void verwijderRow_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                Arts a = (Arts)r.DataBoundItem;
                db.artsen.Remove(a);
            }
            db.SaveChanges();
            dataGridView1.DataSource = db.artsen.ToList();

        }

        DataTable table = new DataTable();
        int indexrow;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }
                

        private void Btn_contract_Click(object sender, EventArgs e)
        {

            using (var db = new DatabaseContext())
            {
                DateTime date = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                DateTime newDate = date.AddYears(1);

                DataGridViewRow newDataRow = dataGridView1.Rows[indexrow];
                newDataRow.Cells[5].Value = newDate;
        
            }

            
        }

        private void CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            
        }
    }
}
    

