using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notas.seleccion
{
    class objperiodo
    {
        CRUD crud = new CRUD();
        public int idperiodo { set; get; }
        public int ano { set; get; }
        public int numero { set; get; }
        public bool activo { set; get; }
        public bool status { set; get; }
        public String errormesg { set; get; }

        public objperiodo(int ano, int numero, bool activo) {
            this.ano = ano;
            this.numero = numero;
            this.activo = activo;
        }

        public void createperiodo() {
            String insert = "insert into periodo (ano,numero,activo) values (" + this.ano + "," + this.numero + "," + Convert.ToInt32(this.activo) + ")";
            status = crud.ConsultaSinResultado(insert);
            if (!status)
            {
                errormesg = "Fallo la creacion del periodo";
            }
            else {
                errormesg = "Periodo creado con exito";
            }
        }

        public void updateperiodo() {
            if (idperiodo <= 0)
            {
                status = false;
                errormesg = "Debe espesificar el periodo a actualizar";
            }
            else {
                String update = "update periodo set ano=" + this.ano + ",numero=" + this.numero + ",activo=" + Convert.ToInt32(this.activo) + " where idperiodo=" + this.idperiodo;
                status = crud.ConsultaSinResultado(update);
                if (status)
                {
                    errormesg = "Fallo la actualizacion del periodo";
                }
                else
                {
                    errormesg = "Periodo actualizado con exito";
                }
            }
        }
    }
}
