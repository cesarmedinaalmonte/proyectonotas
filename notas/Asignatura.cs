﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace notas
{
    
    public partial class Asignatura : Form

    {
        int poc;
        CRUD obCRUD = new CRUD();//objeto de la clase CRUD 
        public Asignatura()
        {
            InitializeComponent();
        }

        private void Asignatura_Load(object sender, EventArgs e)
        {
            ComboxCuatrimestre.DataSource = obCRUD.ConsultaConResultado("SELECT * FROM cuatrimestre");
            ComboxCuatrimestre.DisplayMember = "nombrecuatrimestre";
            ComboxCuatrimestre.ValueMember = "idcuatrimestre";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            DataTable dt1= obCRUD.ConsultaConResultado("SELECT * FROM asignatura WHERE clave='" + txtclave.Text + "'");
            if (dt1.Rows.Count!=0)
            {
                MessageBox.Show(" Esta Asignatura Existe  ", "Error al Guardar ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (obCRUD.ConsultaSinResultado("INSERT INTO asignatura (clave, nombre_asignatura,ht,hp,cr,idcuatrimestre) VALUES('" + txtclave.Text + "', '" + txtasig.Text + "','" + txtht.Text + "', '" + txthp.Text + "','" + txtcr.Text + "', '" + ComboxCuatrimestre.SelectedValue + "') ")
 )
            {
                DataTable dt = obCRUD.ConsultaConResultado("SELECT TOP(1)  * FROM asignatura ORDER BY idasignatura DESC;");
                String idasignatura = dt.Rows[0][0].ToString();

                if (obCRUD.ConsultaSinResultado("INSERT INTO prerequisito(clave,idasignatura) VALUES('" + txtprereq.Text + "','" + idasignatura + "')"))
                {
                    MessageBox.Show("Datos de Seccion Guardados Correctamente", "Datos Guardados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show(" No se Pudieron Guardar Datos de Seccion  ", "Error al Guardar ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
            DataTable dt =  obCRUD.ConsultaConResultado("SELECT clave, nombre_asignatura,ht,hp,cr FROM asignatura ;");
            dtgdatos.DataSource = dt;
            dtgdatos.Refresh();

        }

        private void dtgdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            Form formp = new inicio();
            formp.Show();

            formp.Visible = true;
            Visible = false;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form formp = new inicio();
            formp.Show();

            formp.Visible = true;
            Visible = false;
        }

        private void dtgdatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgdatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc =dtgdatos.CurrentRow.Index;

            txtclave.Text = dtgdatos.CurrentRow.Cells[0].Value.ToString();
            txtasig.Text = dtgdatos.CurrentRow.Cells[1].Value.ToString();
            txtht.Text = dtgdatos.CurrentRow.Cells[2].Value.ToString();
            txthp.Text = dtgdatos.CurrentRow.Cells[3].Value.ToString();
            txtcr.Text = dtgdatos.CurrentRow.Cells[4].Value.ToString();
            //txtcuatrimestre.Text = dtgdatos.CurrentRow.Cells[5].Value.ToString();
            
        }
        public void  limpiar()
        {
            txtclave.Text = "";
            txtasig.Text = "";
            txtcr.Text = "";
            txthp.Text = "";
            txtht.Text = "";
            txtprereq.Text = "";
            txtprereq2.Text = "";
      
        }
    }
}
