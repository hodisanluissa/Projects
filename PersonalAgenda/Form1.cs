using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalAgenda
{
    public partial class Form1 : Form
    {
        private List<Persoana> Persoane = new List<Persoana>();
        private int edit_index = -1;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Persoana per = new Persoana();
            per.Nume = txtNume.Text;
            per.Activitate = txtActivitate.Text;
            per.Data = txtData.Text;
            per.Ora = txtOra.Text;


            if (edit_index > -1)
            {
                Persoane[edit_index] = per;
                edit_index = -1;
            }
            else
            {
                Persoane.Add(per);
            }
            
            actualizareGrid();
            clear();
        }
        private void actualizareGrid()
        {
            dgvDate.DataSource = null;
            dgvDate.DataSource = Persoane;
            dgvDate.ClearSelection();
        }

        private void dgvDate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDate_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow select = dgvDate.SelectedRows[0];
            int pos = dgvDate.Rows.IndexOf(select);
            edit_index = pos;
            Persoana per = Persoane[pos];
            txtNume.Text = per.Nume;
            txtActivitate.Text = per.Activitate;
            txtOra.Text = per.Ora;
            txtData.Text = per.Data;

            //MessageBox.Show(pos.ToString());
        }
        private void clear()
        {
            txtNume.Text = "";
            txtActivitate.Text = "";
            txtOra.Text = "";
            txtData.Text = "";
        }

        private void btnEliminat_Click(object sender, EventArgs e)
        {
            if (edit_index > -1)
            {
                Persoane.RemoveAt(edit_index);
                edit_index = -1;
                clear();
                actualizareGrid();
            }
            else
            {
                MessageBox.Show("trebuie introdus petnru a fi eliminate");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            edit_index = -1;
            clear();
            actualizareGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDate.DataSource = Persoane;
        }

       
    }
}
