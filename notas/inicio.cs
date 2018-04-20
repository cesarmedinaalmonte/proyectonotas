using notas.seleccion;
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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formp = new Asignatura();
            formp.Show();

            formp.Visible = true;
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formp = new profesor();
            formp.Show();

            formp.Visible = true;
            Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Form formp = new historial();
            //formp.Show();

            //formp.Visible = true;
            //Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formp = new periodo();
            formp.Show();

            formp.Visible = true;
            Visible = false;
        }

        private void btnSeleccionAsignatura_Click(object sender, EventArgs e)
        {
            Form formp = new asignacion();
            formp.Show();

            formp.Visible = true;
            Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form formp = new Calificaciones();
            formp.Show();

            formp.Visible = true;
            Visible = false;
        }
    }
}
