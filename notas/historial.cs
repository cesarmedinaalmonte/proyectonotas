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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = obCRUD.ConsultaConResultado("SELECT * FROM asignatura INNER JOIN seleccion on asignatura.idasignatura = seleccion.idasignatura ; ");

            dtgsiglo1.DataSource = dt;
            dtgsiglo1.Refresh();
        }

        private void historial_Load(object sender, EventArgs e)
        {
            //Codigo para llegar el combobox con la tabla cuatrimestre
            cmbhistorial.DataSource = obCRUD.ConsultaConResultado("SELECT * FROM periodo");
            cmbhistorial.DisplayMember = "ano";
            cmbhistorial.ValueMember = "idperiodo";
        }
    }
}
