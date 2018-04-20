using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace notas
{
 
    public partial class asignacion : Form
    {
        CRUD crud = new CRUD();

        public asignacion()
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

        private void asignacion_Load(object sender, EventArgs e)
        {
            DataTable dt = crud.ConsultaConResultado("Select idcuatrimestre, nombrecuatrimestre from cuatrimestre order by idcuatrimestre");
            cbxcuatrimestre.DataSource = dt;
            cbxcuatrimestre.ValueMember = "idcuatrimestre";
            cbxcuatrimestre.DisplayMember = "nombrecuatrimestre";

            DataTable fr = crud.ConsultaConResultado("select idperiodo, ano, numero from periodo where activo= 1");
            txtperiodo.Text = fr.Rows[0]["idperiodo"].ToString();
            txtdescripcion.Text = fr.Rows[0]["ano"].ToString()+"-" + fr.Rows[0]["numero"].ToString();

            if (cbxcuatrimestre.SelectedValue.ToString() != "") 
            {
                materias(cbxcuatrimestre.SelectedValue.ToString());
            }
        }

        private void materias(String idcua) {        
            DataTable dt = crud.ejecutar("MATERIASDISPONIBLES",new SqlParameter[] { new SqlParameter("@idcuatrimestre",idcua) });
            dataGridView2.DataSource = dt;
        }

        private void btnterminar_Click(object sender, EventArgs e)
        {

        }

        private void cbxcuatrimestre_SelectedValueChanged(object sender, EventArgs e)
        {
            //materias(cbxcuatrimestre.SelectedValue.ToString());
        }
    }
}
