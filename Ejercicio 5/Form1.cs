using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (txtfila.Text == "" || txtcolumna.Text == "")
            {
                MessageBox.Show("Datos incompletos");
            }
            else
            {
                int n = Convert.ToInt32(txtfila.Text);
                int m = Convert.ToInt32(txtcolumna.Text);
                int[,] matriz = new int[n, m];
                Random r = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matriz[i, j] = r.Next(1, 51);
                    }
                }
                dgvmatriz.ColumnCount = m;
                dgvmatriz.RowCount = n;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        dgvmatriz.Rows[i].Cells[j].Value = matriz[i, j].ToString();
                    }
                }
                txtcolumna.Enabled = false;
                txtfila.Enabled = false;
            }
        }      

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtfila.Enabled = true;
            txtcolumna.Enabled = true;
            txtfila.Text = "";
            txtcolumna.Text = "";
            dgvmatriz.Columns.Clear();
        }

        private void txtfila_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtcolumna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
