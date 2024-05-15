using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroEducativo
{
    public abstract class MiembroDeLaComunidad
    {
        //atributos
        private int cedula;
        private string nombre;
        private string apellido;

        //constructor 
        public MiembroDeLaComunidad(int cedula, string nombre, string apellido)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        //metodo
        public abstract void ObtenerInfo();
        public string GetNombre()
        {
            return nombre;
        }
    }
}
