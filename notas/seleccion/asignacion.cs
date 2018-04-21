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

            int idperiodo;
            int.TryParse(txtperiodo.Text, out idperiodo);

            DataTable sel = crud.ejecutar("MATERIASSELECCIONADAS", new SqlParameter[] { new SqlParameter("@idperiodo", idperiodo) });
            foreach(DataRow row in sel.Rows){
                dataGridView1.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(),
                    row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString());
            }

            if (cbxcuatrimestre.SelectedValue.ToString() != "") 
            {
                int id;
                int.TryParse(cbxcuatrimestre.SelectedValue.ToString(), out id);
                materias(id);
            }
            cbxbimestre.SelectedIndex = 0;

            
        }

        private void materias(int idcua) {        
            DataTable dt = crud.ejecutar("MATERIASDISPONIBLES",new SqlParameter[] { new SqlParameter("@idcuatrimestre", idcua) });
            dataGridView2.DataSource = dt;
        }

        private void btnterminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0) {
                MessageBox.Show("No hay materias seleccionadas!");
                return;
            }
            if (MessageBox.Show("Desea guardar esta seleccion?", "Guardar seleccion", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                crud.ConsultaSinResultado("delete from seleccion where idperiodo="+txtperiodo.Text);
                foreach (DataGridViewRow row in dataGridView1.Rows) {
                    String inert = "insert into seleccion (idasignatura,bimestre,idperiodo) values (" + row.Cells[0].Value.ToString() + ",'"+ row.Cells[6].Value.ToString() + "',"+txtperiodo.Text+")";
                    crud.ConsultaSinResultado(inert);
                }
                MessageBox.Show("Seleccion guardada con exito!!");
                btnatras.PerformClick();
            }
        }

        private void cbxcuatrimestre_SelectedValueChanged(object sender, EventArgs e)
        {
            int id;
            int.TryParse(cbxcuatrimestre.SelectedValue.ToString(), out id);
           materias(id);
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows.Count > 0) {
                String idasignatura = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                DataTable dt = crud.ConsultaConResultado("select clave from prerequisito where idasignatura="+idasignatura);
                String clave = "";
                if (dt.Rows.Count >0)
                {
                    clave = dt.Rows[0][0].ToString();
                }
                if (clave == "BR") {
                    addasignatura(idasignatura);
                }
                else
                {
                    DataTable dt2 = crud.ConsultaConResultado("select * from asignatura where clave='" + clave + "' and idasignatura in (select idasignatura from seleccion)");
                    if (dt2.Rows.Count > 0)
                    {
                        addasignatura(idasignatura);
                    }
                    else
                    {

                        MessageBox.Show("Esta materia tiene conflicto de prerequisito no se puede seleccionar");
               
                    }
                }
            }
        }

        private void addasignatura(String id)
        {
            if (dataGridView1.Rows.Count >= 6) {
                MessageBox.Show("Solo se permiten 6 materias por periodo");
                return;
            }
            DataTable dt = crud.ConsultaConResultado("select idasignatura,clave,nombre_asignatura,cr,ht,hp from asignatura where idasignatura=" + id);
            if (dt.Rows.Count > 0)
            {
                if (dataGridView1.Rows.Cast<DataGridViewRow>().Where(x => x.Cells[0].Value != null && x.Cells[0].Value.ToString() == id).Count() == 0) {
                    dataGridView1.Rows.Add(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(),
                    dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(),cbxbimestre.SelectedItem.ToString());
                }   
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
