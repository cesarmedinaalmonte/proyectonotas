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
    public partial class Calificaciones : Form
    {
        CRUD obCRUD = new CRUD();//objeto de la clase CRUD 
        public Calificaciones()
        {
            InitializeComponent();
        }

        private void Calificaciones_Load(object sender, EventArgs e)
        {
            //Codigo para llegar el combobox con la tabla cuatrimestre
            cmbano.DataSource = obCRUD.ConsultaConResultado("SELECT * FROM periodo");
            cmbano.DisplayMember = "ano";
            cmbano.ValueMember = "idperiodo";
            cmbperiodoc.DataSource = obCRUD.ConsultaConResultado("SELECT * FROM periodo");
            cmbperiodoc.DisplayMember = "numero";
            cmbperiodoc.ValueMember = "idperiodo";
        }

        private void btnCalificacion_Click(object sender, EventArgs e)
        {
            DataTable dt = obCRUD.ConsultaConResultado("select [clave] as Clave, [nombre_asignatura] as Asignatura, [ano] as 'Año Periodo ', [numero] as 'Numero Periodo ' , [nota] as Nota from asignatura inner join dbo.seleccion  on dbo.asignatura.idasignatura = dbo.seleccion.idasignatura inner join dbo.periodo  on dbo.seleccion.idperiodo = dbo.periodo.idperiodo where periodo.numero = '" + cmbperiodoc.Text + "' and periodo.ano = '" + cmbano.Text + "' ; ");

           dtgcalificacion.DataSource = dt;
            dtgcalificacion.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formp = new historial();
            formp.Show();

            formp.Visible = true;
            Visible = false;
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
