using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroEducativo.Clases
{
    public class Docente : Empleado
    {

       private string especialidad;
         
        public Docente(int cedula, string nombre, string apellido, int id, float salario, string puesto,string departamento, string especialidad)
            : base(cedula,nombre,apellido,id,salario,puesto, departamento)
        {
            this.especialidad = especialidad;
        }

        public void ActualizarAsistencia()
        {
            Console.WriteLine("Establecer asistencia");
        }

        public void RealizarReportes()
        {

        }
        
    }

    
}
