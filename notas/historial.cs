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
    public partial class historial : Form
    {
        CRUD obCRUD = new CRUD();//objeto de la clase CRUD 
        public historial()
        {

            InitializeComponent();
            dtgsiglo1.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = obCRUD.ConsultaConResultado("select [clave] as Clave, [nombre_asignatura] as Asignatura, [ano] as 'Año Periodo ', [numero] as 'Numero Periodo ' , [nota] as Nota from asignatura inner join dbo.seleccion  on dbo.asignatura.idasignatura = dbo.seleccion.idasignatura inner join dbo.periodo  on dbo.seleccion.idperiodo = dbo.periodo.idperiodo where periodo.numero = '" + cmbperiodo.Text + "' and periodo.ano = '" + cmbhistorial.Text + "' ; ");

            dtgsiglo1.DataSource = dt;
            dtgsiglo1.Refresh();
        }

        private void historial_Load(object sender, EventArgs e)
        {
            //Codigo para llegar el combobox con la tabla cuatrimestre
            cmbhistorial.DataSource = obCRUD.ConsultaConResultado("SELECT * FROM periodo");
            cmbhistorial.DisplayMember ="ano";
            cmbhistorial.ValueMember ="idperiodo";
            cmbperiodo.DataSource = obCRUD.ConsultaConResultado("SELECT * FROM periodo");
            cmbperiodo.DisplayMember = "numero";
          cmbperiodo.ValueMember = "idperiodo";


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
