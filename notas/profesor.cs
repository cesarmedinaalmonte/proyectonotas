using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notas
{
    public partial class profesor : Form
    {
        CRUD obCRUD = new CRUD();//objeto de la clase CRUD 
        public profesor()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnguardarp_Click(object sender, EventArgs e)
        {
            if (obCRUD.ConsultaSinResultado("INSERT INTO profesor (nombre,correo,telefono) VALUES('" + txtnombrep.Text + "', '" + txtemailp.Text + "','" + txttelp.Text +  "') ")
)
            {

                MessageBox.Show("Datos de Seccion Guardados Correctamente", "Datos Guardados ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show(" No se Pudieron Guardar Datos de Seccion  ", "Error al Guardar ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            Form formp = new inicio();
            formp.Show();

            formp.Visible = true;
            Visible = false;
        }

        private void btnbuscarp_Click(object sender, EventArgs e)
        {
            DataTable dt = obCRUD.ConsultaConResultado("SELECT * FROM profesor;");
            dtgdatosp.DataSource = dt;
            dtgdatosp.Refresh();

        }

        private void dtgdatosp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgdatosp_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombrep.Text = dtgdatosp.CurrentRow.Cells[1].Value.ToString();
            txtemailp.Text = dtgdatosp.CurrentRow.Cells[2].Value.ToString();
            txttelp.Text = dtgdatosp.CurrentRow.Cells[3].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formp = new inicio();
            formp.Show();

            formp.Visible = true;
            Visible = false;
        }
    }
    }

