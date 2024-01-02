using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _20230112_GUI
{
    public partial class Form1 : Form
    {
        string[] beolvas;
        public Form1()
        {
            InitializeComponent();
            beolvas = File.ReadAllLines("szamok.txt");
            foreach (var item in beolvas)
            {
                lbx.Items.Add(item);
            }
        }

        private void btnkilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbx.Focus();
        }

        private void btnhozzaad_Click(object sender, EventArgs e)
        {
            string inputText = tbx.Text.Trim();
            if (!string.IsNullOrEmpty(inputText)) 
            {
                lbx.Items.Add(inputText);
                tbx.Clear();
            }
        }

        private void btnrendezes_Click(object sender, EventArgs e)
        {

        }

        private void btnathelyezes_Click(object sender, EventArgs e)
        {
            if (lbx.SelectedItem != null)
            {
                string helyez = lbx.SelectedItem.ToString();
                tbx.Text = helyez;
                lbx.Items.Remove(helyez);
            }
        }

        private void btnment_Click(object sender, EventArgs e)
        {
            if (tbx.Text != "" )
            {
                string kiir = tbx.Text + ";" + "\n";
                File.AppendAllText("szamok.txt", kiir);
                Form1 f = new Form1();
                f.Show();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Valami üres");
            }
        }
    }
}
