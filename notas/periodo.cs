using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notas.seleccion
{
    public partial class periodo : Form
    {
        CRUD crud = new CRUD();
        private int per = 3;
        public periodo()
        {
            InitializeComponent();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            Form formp = new inicio();
            formp.Show();

            formp.Visible = true;
            Visible = false;
        }

        private void buscar()
        {
            DataTable dt = crud.ConsultaConResultado("select idperiodo as Codigo,ano as Año,numero as Periodo,activo as Activo from periodo order by idperiodo");
            dataGridView1.DataSource = dt;
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            int ano = 0;
            if (txtcrear.Text == "")
            {
                MessageBox.Show("Este campo no puede estar vacio");
                return;
            }
            try
            {
                ano = Convert.ToInt16(txtcrear.Text);
            }
            catch (Exception ex) {
                MessageBox.Show("El año debe ser numerico de 4 digitos");
                txtcrear.Focus();
                return;
            }

            if (txtcrear.Text.Length != 4) {
                MessageBox.Show("El año debe ser numerico de 4 digitos");
                txtcrear.Focus();
                return;
            }

            DataTable dt = crud.ConsultaConResultado("select ano from periodo where ano=" + ano);
            if (dt.Rows.Count > 0) {
                MessageBox.Show("Este año ya esta creado!");
                txtcrear.Clear();
                return;
            }


            objperiodo obj = null;
            for (int i = 1; i <= per; i++) {
                obj = new objperiodo(ano, i, false);
                obj.createperiodo();
                if (!obj.status) {
                    MessageBox.Show(obj.errormesg);
                    break;
                }
            }

            MessageBox.Show("Periodo creado con exito");
            txtcrear.Clear();
        }

        private void periodo_Load(object sender, EventArgs e)
        {
            buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea establecer el periodo " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "-" +
                dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + " como el periodo activo por defecto?", "Activar Periodo", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes) {
                crud.ConsultaSinResultado("update periodo set activo=0");
                if (crud.ConsultaSinResultado("update periodo set activo=1 where idperiodo=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString())) {
                    MessageBox.Show("Periodo activado con exito");
                }

            }
            buscar();
        }
    }
}
