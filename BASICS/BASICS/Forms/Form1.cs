using AQUA_DATA.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AQUA_DATA
{
    public partial class Form1 : Form
    {

        clsTeste oClsTeste = new clsTeste();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            oClsTeste.Insert(txtInserir.Text);
            MessageBox.Show(oClsTeste.sMensagem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oClsTeste.LoadGrid(dataGridView1, txtInserir.Text);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                string parametro = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                string coluna = dataGridView1.Columns[e.ColumnIndex].Name;
                oClsTeste.LoadField(coluna, parametro, txtTesteSelectBanco);  

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            oClsTeste.LoadCombo(cboTeste);
        }

    }
}
