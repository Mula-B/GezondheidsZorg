﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Drawing.Printing;

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

            dataGridView2.DataSource = db.klanten.ToList();

            dataGridView3.DataSource = db.medicaties.ToList();

        }
        

        private void Btn_filter_Click(object sender, EventArgs e)
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

        
        private void klntAdd_Click(object sender, EventArgs e)
        {

            string arts = artsComboBox.Text;
            string verz = klntVerz.Text;
            string klantvoor = klntvoornaam.Text;
            string klantacht = klntachternaam.Text;
            string klantadres = klntadres.Text;
            string klantpostcode = klntpostcode.Text;

                Arts c = (Arts)artsComboBox.SelectedItem;

                Klant k = new Klant();                
                k.Voornaam = klantvoor;
                k.Achternaam = klantacht;
                k.Adres = klantadres;
                k.Postcode = klantpostcode;
                
                Arts x = c;
                x.Klanten.Add(k);
                 
                Medicatie m = new Medicatie();
                m.MedicatieNaam = soortMed.Text;
                
                db.medicaties.Add(m);
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
                soortMed.Text = string.Empty;
                  
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
                soortMed.Text = string.Empty;
        }

        
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

                
        private void Btn_contract_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow r = dataGridView1.SelectedRows[0];
                Arts a = (Arts)r.DataBoundItem;
                DateTime date = a.Einddatum.AddYears(1);

                a.Einddatum = date;

                db.SaveChanges();
                dataGridView1.DataSource = db.artsen.ToList();

            }
           
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1) {

                DataGridViewRow r = dataGridView1.SelectedRows[0];
                Arts a = (Arts)r.DataBoundItem;

                var query = db.klanten.Where(k => k.ArtsId == a.ArtsID);

                dataGridView2.DataSource = query.ToList();
            }
        }


        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
           if(dataGridView2.SelectedRows.Count == 1) {

                DataGridViewRow r = dataGridView2.SelectedRows[0];
                Klant a = (Klant)r.DataBoundItem;

                var query = db.medicaties.Where(k => k.KlantID == a.KlantID);

                dataGridView3.DataSource = query.ToList();

            }
            else
            {
                dataGridView3.DataSource = null;
            }
           

        }


        public List<string> gegevens = new List<string>();

        private void btnPrint_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                gegevens.Add("Naam: " + row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString() + ", Adres: " + row.Cells[3].Value.ToString() + ", Postcode: " + row.Cells[4].Value.ToString());
            }
            PrintDocument print = new PrintDocument();
            print.PrintPage += new PrintPageEventHandler(PrintImage);
            print.Print();
            gegevens.Clear();
        }


        public void PrintImage(object ob, PrintPageEventArgs e)
        {
            float x = 6f;
            float y = 6f;
            Font font = new Font("Arial", 10);
            SolidBrush color = new SolidBrush(Color.Black);
            PointF point = new PointF(x, y);

            foreach(string item in gegevens)
            {
                e.Graphics.DrawString(item, font, color, point);
                y += 16f;
                point = new PointF(x, y);
            }
        }
    }
}
    

