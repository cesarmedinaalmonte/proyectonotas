﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace notas
{
    public class conexion1
    {

        public static SqlConnection octenerconexion()
        {
            SqlConnection conn = new SqlConnection("Data Source=GREGORY-PC;Initial Catalog=asignaturas;Integrated Security=True");
            conn.Open();

            return conn;
        }
    }
}
